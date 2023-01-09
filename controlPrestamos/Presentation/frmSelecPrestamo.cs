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
    public partial class frmSelecPrestamo : Form
    {
        public bool accionCnPresta; //INICIALIZA CON FALSO (SU FUNCION ES SABER SI SE PIDE LA APERTURA DE ESTA VENTANA DESDE LA VENTANA DE PRESTAMOS)
        public IPrestamo prestamo { get; set; }
        public frmSelecPrestamo()
        {
            InitializeComponent();
        }

        private void frmSelecPrestamo_Load(object sender, EventArgs e)
        {
            if (CrudFolio.querySelecPrestamo("LIQUIDADO") != null)
            {
                dgvSelecPrestamo.DataSource = CrudFolio.querySelecPrestamo("LIQUIDADO").Tables[0];
            }
            else {
                MessageBox.Show("NO EXISTEN PRESTAMOS ");
            }
            
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvSelecPrestamo.DataSource;
            bs.Filter = "Nombre like '%" + txtSearchName.Text + "%'";
            dgvSelecPrestamo.DataSource = bs;
        }

        private void dgvSelecPrestamo_DoubleClick(object sender, EventArgs e)
        {
            int folio = 0;
            int claveCli = 0;
            string nombre = "";
            string ape1 = "";
            string ape2 = "";
            string tel = "";
            decimal montoPres = 0;
            decimal restPres = 0;
            decimal interes = 0;
            DateTime fecha = DateTime.Now;
            string modalidad = "";

            var filaSel = dgvSelecPrestamo.CurrentRow;
            if (filaSel != null)
            {
                folio = (int)filaSel.Cells[0].Value;
                claveCli = (int)filaSel.Cells[1].Value;
                nombre = (string)filaSel.Cells[2].Value;
                 ape1 = (string)filaSel.Cells[3].Value;
                 ape2 = (string)filaSel.Cells[4].Value;
                 tel = (string)filaSel.Cells[5].Value;
                 montoPres = (decimal)filaSel.Cells[6].Value;
                 restPres = (decimal)filaSel.Cells[7].Value;
                 interes = (decimal)filaSel.Cells[8].Value;
                 fecha = (DateTime)filaSel.Cells[9].Value;
                 modalidad = (string)filaSel.Cells[10].Value;
            }
            else { MessageBox.Show("Seleccione alguna fila"); }


            if (accionCnPresta == true)
            {
                txtNombreCli.Text = nombre;
                txtFolio.Text = folio.ToString();
               
            }
            else {
                prestamo.EjecutarPrestamos(folio, claveCli, nombre, ape1, ape2, tel, fecha, montoPres, restPres, interes, modalidad);
                this.Close();
            }


            //CrudClientes.Clientes().Tables[0].Clear();



        }

        private void radioButon(RadioButton button) {
            if (tbLiquidado.Checked == true) {
                if (CrudFolio.querySelecPrestamo("PENDIENTE") != null)
                {
                    dgvSelecPrestamo.DataSource = CrudFolio.querySelecPrestamo("PENDIENTE").Tables[0];
                }
                else { MessageBox.Show("NO EXISTEN PRESTAMOS REGISTROS"); }
                
            }
            else if (rbPendiente.Checked) {
                if (CrudFolio.querySelecPrestamo("LIQUIDADO") != null)
                {
                    dgvSelecPrestamo.DataSource = CrudFolio.querySelecPrestamo("LIQUIDADO").Tables[0];
                }
                else { MessageBox.Show("NO EXISTEN PRESTAMOS REGISTROS"); }
                
            }
            else if (rbTodos.Checked) {
                if (CrudFolio.querySelecPrestamo(null) != null)
                {
                    dgvSelecPrestamo.DataSource = CrudFolio.querySelecPrestamo(null).Tables[0];
                }
                else { MessageBox.Show("NO EXISTEN PRESTAMOS REGISTROS"); }
                
            }
        }

        private void tbLiquidado_CheckedChanged(object sender, EventArgs e)
        {
            radioButon(tbLiquidado);
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            radioButon(rbTodos);
        }

        private void rbPendiente_CheckedChanged(object sender, EventArgs e)
        {
            radioButon(rbTodos);
        }

        private void btnEliminarPres_Click(object sender, EventArgs e)
        {
            if (GlobalUser.provilegioUsuario == "SUPERADMINISTRADOR")
            {
                DialogResult dialog = MessageBox.Show("¿CONFIRME PARA ELIMINAR PRESTAMOS?", "ELIMINAR PRESTAMOS", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    try {
                        CrudFolio.DeletePrest(int.Parse(txtFolio.Text));
                        MessageBox.Show("¡HECHO¡");
                        dgvSelecPrestamo.DataSource = CrudFolio.querySelecPrestamo("LIQUIDADO").Tables[0];
                    }
                    catch (Exception ms) { MessageBox.Show("NO SE REALIZÓ LA ACCIÓN  "); }
                    
                }
                

            }
            else {
                MessageBox.Show("NO TIENES PERMISO PARA REALIZAR ESTA ACCIÓN");
            }
        }
    }
    
}
