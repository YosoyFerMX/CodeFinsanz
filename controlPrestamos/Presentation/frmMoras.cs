using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlPrestamos.Business;

namespace controlPrestamos.Presentation
{
    public partial class frmMoras : Form, IPrestamo
    {
        private decimal restantePagar = 0;
        public int folio;
        public frmMoras()
        {
            InitializeComponent();
        }

        public void EjecutarPrestamos(int folio, int claveCliente, string nombre, string apellido1, string apellido2, string telefono, DateTime fecha, decimal montoPagar, decimal restante, decimal interes , string modalidad)
        {
            this.txtFolio.Text = folio.ToString();
            this.folio = folio;
            this.txtNombreCli.Text = nombre;
            this.txtApellido1Cli.Text = apellido1;
            this.txtApellido2Cli.Text = apellido2;
            this.txtTelefonoCli.Text = telefono;
            this.txtClaveCli.Text = claveCliente.ToString();
            this.txtMontoPagar.Text = montoPagar.ToString("C2");
            this.calendarPres.Value = fecha;
            this.txtAdeudoRest.Text = restante.ToString("C2");
            this.restantePagar = restante;
            this.lblModalidad.Text = modalidad;
            dgvMoras.DataSource = "";

            if (modalidad == "DIARIO")
            {
                if (CrudFolio.queryMoraPres(folio) != null)
                {
                    dgvMoras.Columns.Clear();
                    dgvMoras.DataSource = CrudFolio.queryMoraPres(folio).Tables[0];

                }
                else { MessageBox.Show("ESTE CLIENTE NO TIENE MORAS");
                    dgvMoras.Columns.Clear();
                    mostrarDGV();
                }
            }
            else if (modalidad == "SEMANAL" || modalidad == "QUINCENAL") {
                if (CrudFolio.queryMoraPresSemanas(folio) != null)
                {
                    dgvMoras.Columns.Clear();
                    dgvMoras.DataSource = CrudFolio.queryMoraPresSemanas(folio).Tables[0];

                }
                else { MessageBox.Show("ESTE CLIENTE NO TIENE MORAS");
                    dgvMoras.Columns.Clear();
                    mostrarDGV();
                }
            }
            else if (modalidad == "MENSUAL") {
                if (CrudFolio.queryMoraPresMes(folio) != null)
                {
                    dgvMoras.Columns.Clear();
                    dgvMoras.DataSource = CrudFolio.queryMoraPresMes(folio).Tables[0];
                }
                else { MessageBox.Show("ESTE CLIENTE NO TIENE MORAS");
                    dgvMoras.Columns.Clear();
                    mostrarDGV(); }
            }
            
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            frmSelecPrestamo abroLisPrestamos = new frmSelecPrestamo();
            abroLisPrestamos.prestamo = this;
            abroLisPrestamos.ShowDialog();
        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(sender, e);
        }

        private void mostrarDGV() {
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "FOLIO";
            dgvMoras.Columns.Add(columna1);

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "CUOTA";
            dgvMoras.Columns.Add(columna2);

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "FECHA";
            dgvMoras.Columns.Add(columna3);

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "MODALIDAD";
            dgvMoras.Columns.Add(columna4);

            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "DIAS/ SEMANAS ATRASO";
            dgvMoras.Columns.Add(columna5);

            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "MORATORIA";
            dgvMoras.Columns.Add(columna6);

            DataGridViewTextBoxColumn columna7 = new DataGridViewTextBoxColumn();
            columna7.HeaderText = "ESTADO";
            dgvMoras.Columns.Add(columna7);
        }

        private void dgvMoras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSel = dgvMoras.CurrentRow;
            if (filaSel != null)
            {
                decimal adeudo = (decimal)filaSel.Cells[5].Value;
                txtAbono.Text = adeudo.ToString();


            }
            else { MessageBox.Show("Seleccione alguna fila"); }
        }

        private void frmMoras_Load(object sender, EventArgs e)
        {
            mostrarDGV();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            int folio = 0;

            if (txtFolio.Text != "")
            {
                if (txtAbono.Text != "")
                {
                    for (int i = 0; i <= dgvMoras.RowCount -1; i++) {
                        folio = (int)dgvMoras.Rows[i].Cells[0].Value;
                        int cuota = (int)dgvMoras.Rows[i].Cells[1].Value;
                        string estado = (string)dgvMoras.Rows[i].Cells[6].Value;

                        if (estado != "LIQUIDADO") {
                            try {
                                CrudFolio.AbonarMoratoria(folio,cuota);
                                MessageBox.Show("¡¡HECHO!!");

                                break;
                                

                            }
                            catch (Exception msj) {
                                MessageBox.Show("NO SE PUDO ABONAR LA MORATORIA", msj.ToString());
                            }
                        
                        }


                    }

                }
                else { MessageBox.Show("AGREGUE LA CANTIDAD A ABONAR"); }


            }
            else { MessageBox.Show("NO EXISTE UN FOLIO"); }

            if (lblModalidad.Text == "DIARIO")
            {
                if (CrudFolio.queryMoraPres(folio) != null)
                {
                    dgvMoras.DataSource = CrudFolio.queryMoraPres(folio).Tables[0];
                }
                else { MessageBox.Show("NO EXISTEN REGISTROS"); }
                
            }
            else if (lblModalidad.Text == "SEMANAL")
            {
                if (CrudFolio.queryMoraPresSemanas(folio) != null)
                {
                    dgvMoras.DataSource = CrudFolio.queryMoraPresSemanas(folio).Tables[0];
                }
                else { MessageBox.Show("NO EXISTEN REGISTROS"); }
                
            }
            txtAbono.Text = "";
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            frmReporteMoratorio abrirMora = new frmReporteMoratorio(folio);
            abrirMora.Show();
        }
    }
}
