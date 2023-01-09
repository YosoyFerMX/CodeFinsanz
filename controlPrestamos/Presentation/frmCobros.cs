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
    public partial class frmCobros : Form, IPrestamo, IMoratoria
    {
        public decimal restantePagar = 0;
        public bool validateDate = false;
        public int rowIndex { get; set; } // para capturar eñ cick derecjo del Mause
        private decimal mora = -1; //Proviene del formulario ver moratoria
        bool toBuyDinamic = false;//PARA IDENTIFICAR SI ES UN PAGO DINAMICO, O SEA VARIOS PAGOS
        //PARA CAPTURAR DATOS AL DAR DOBLE CLICK
        int folio = 0;
        private int cuota;
        private string fecha;
        private decimal canTCuota = 0;
        private string estado = "";
        decimal montoPagar = 0;
        public frmCobros()
        {
            InitializeComponent();
        }


        void IMoratoria.EjecutarMoratoria(decimal moratoria)
        {
            this.mora = moratoria;
        }
        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            ln.Clear();
            frmSelecPrestamo abroLisPrestamos = new frmSelecPrestamo();
            abroLisPrestamos.prestamo = this;
            abroLisPrestamos.ShowDialog();
            
        }

        private void mostrarDGV()
        {
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "FOLIO";
            dgvCuotas.Columns.Add(columna1);

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "CUOTA";
            dgvCuotas.Columns.Add(columna2);

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "FECHA";
            dgvCuotas.Columns.Add(columna3);

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "MONTO";
            dgvCuotas.Columns.Add(columna4);

            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "ESTADO";
            dgvCuotas.Columns.Add(columna5);


        }



        public void EjecutarPrestamos(int folio, int claveCliente, string nombre, string apellido1, string apellido2, string telefono, DateTime fecha, decimal montoPagar, decimal restante, decimal interes, string modalidad)
        {
            this.txtFolio.Text = folio.ToString();
            this.txtNombreCli.Text = nombre;
            this.txtApellido1Cli.Text = apellido1;
            this.txtApellido2Cli.Text = apellido2;
            this.txtTelefonoCli.Text = telefono;
            this.txtClaveCli.Text = claveCliente.ToString();
            this.txtMontoPagar.Text = montoPagar.ToString("C2");
            this.montoPagar = montoPagar;
            this.calendarPres.Value = fecha;
            this.txtAdeudoRest.Text = restante.ToString("C2");
            this.restantePagar = restante;
            this.lblInteres.Text = interes.ToString();
            this.lblModalidad.Text = modalidad;

            if (CrudFolio.queryDetallePres(folio) != null)
            {
                dgvCuotas.Columns.Clear();
                dgvCuotas.DataSource = CrudFolio.queryDetallePres(folio).Tables[0];

            }
            else { MessageBox.Show("AUN NO HAY REGISTROS"); }
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            int sizeList = ln.Count;
            decimal cash = montoPagar / dgvCuotas.Rows.Count;
            if (txtAbono.Text != "" && txtFolio.Text != "")
            {
                if (canTCuota != 0 && sizeList < 2)
                {

                    toPaySh(cuota);
                    
                }
                else
                {
                    //PARA ABONAR SEGUN EL NUMERO DE INIDICES SELECCIONADOS

                    if ((decimal.Parse(txtAbono.Text) / sizeList) >= cash)
                    {
                        toBuyDinamic = true;
                        foreach (int i in ln)
                        {
                            int num = i;

                            exitData(num);
                            toPaySh(num);
                        }
                    }
                    else { MessageBox.Show("EL MONTO NO ES SUFICIENTE"); }

                    toBuyDinamic = false;
                    txtAbono.Text = "";

                }
            }
            else { MessageBox.Show("ASEGURESE DE QUE EXISTA UN FOLIO O QUE SE ESTÁ AGREGANDO EL MONTO"); }
            ln.Clear();

        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(sender, e);
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {

            if (txtFolio.Text != "")
            {
                frmReportePrestamoDetalles abrirRepor = new frmReportePrestamoDetalles(int.Parse(txtFolio.Text));
                abrirRepor.Show();
            }
            else
            {
                MessageBox.Show("SELECCIONE UN CLIENTE");
            }



        }

        private void dgvCuotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCuotas.CurrentRow.Index;
            
            exitData(index);
        }



        private void dgvCuotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.dgvCuotas.Columns[e.ColumnIndex].Name == "FECHA")
            {

                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        if (Convert.ToDateTime(e.Value) < DateTime.Now.Date)
                        {
                            validateDate = true;
                        }
                    }

                }
                catch (NullReferenceException ex) { MessageBox.Show("Campo Nulo " + ex); }


            }

            if (this.dgvCuotas.Columns[e.ColumnIndex].Name == "ESTADO")
            {
                try
                {

                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        if (Convert.ToString(e.Value) == "PENDIENTE" && validateDate == true)
                        {
                            e.CellStyle.ForeColor = Color.Orange;
                            validateDate = false;
                        }

                    }
                }
                catch (NullReferenceException ex) { MessageBox.Show("Campo Nulo " + ex); }

            }
        }

        private void dgvCuotas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //PARA ABRIR SUBMENU CON EL CLICK DERECHO
            if (e.Button == MouseButtons.Right)
            {
                this.dgvCuotas.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvCuotas.CurrentCell = this.dgvCuotas.Rows[e.RowIndex].Cells[0];
                this.contextMenuVerMoratoria.Show(this.dgvCuotas, e.Location);
                contextMenuVerMoratoria.Show(Cursor.Position);

            }
        }

        private void contextMenuVerMoratoria_Click(object sender, EventArgs e)
        {

            int index = dgvCuotas.CurrentRow.Index;

            showWinMora(index);



        }

        private decimal calcularDias(DateTime fechaCuota)
        {

            TimeSpan difFechas = DateTime.Now.Date - fechaCuota;
            decimal dias = difFechas.Days;

            return dias;
        }

        private void frmCobros_Load(object sender, EventArgs e)
        {
            mostrarDGV();
        }

        //LISTA PARA ALMACENAR LOS INIDICES QUE SERÁN ABONADOS
        List<int> ln = new List<int>();
        private void dgvCuotas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // SELECCION MULTIPLE
            int n = dgvCuotas.CurrentRow.Index;
            dgvCuotas.Rows[n].Selected = false;
            dgvCuotas.ClearSelection();

            if (ln.Contains(n))
            {
                ln.Remove(n);
            }
            else
            {
                ln.Add(n);
            }

            foreach (int i in ln)
            {
                dgvCuotas.Rows[i].Selected = true;
            }
        }

        private void toPaySh(int index)
        {
            decimal diaMes = 0;
            

                decimal tipoAbono = decimal.Parse(txtAbono.Text) / canTCuota;
                //--------------- PAGO MORA----------------
                if (estado != "PAGADO")
                {

                    if (mora <= 0 && Convert.ToDateTime(fecha) < DateTime.Now.Date)
                    {
                        MessageBox.Show("POR FAVOR INGRESE LA MORATORIA");
                        if (toBuyDinamic) {
                            showWinMora(index);
                            toPaySh(index);//Recursividad
                        }
                            
                }
                    else
                    {
                        if (decimal.Parse(txtAbono.Text) >= canTCuota)
                        {

                            MessageBox.Show("SE ABONARÁ A LA CUOTA " + cuota + " DE LA FECHA: " + fecha);
                            try
                            {
                                CrudFolio.AbonoCuota(int.Parse(this.txtFolio.Text.Trim()), cuota, decimal.Parse(txtAbono.Text), "PAGADO");
                            }
                            catch (Exception m)
                            {
                                MessageBox.Show("ERROR AL INSERTAR A LA BASE DE DATOS " + m.ToString()); ;
                            }

                            //VALIDACION PARA INSERTAR ENN TBMORAS
                            if (Convert.ToDateTime(fecha) < DateTime.Now.Date)
                            {
                                decimal dias = calcularDias(Convert.ToDateTime(fecha));
                                if (lblModalidad.Text == "DIARIO")
                                {
                                    diaMes = dias;
                                }
                                else if (lblModalidad.Text == "SEMANAL")
                                {
                                    diaMes = dias / 7; // SI ES SEMANAL SE DIVIDE ENTRE 7
                                }


                                try
                                {
                                    CrudFolio.InsertMora(folio, cuota, Convert.ToDateTime(fecha), lblModalidad.Text, Convert.ToInt32(Math.Ceiling(diaMes)), mora);
                                }
                                catch (Exception me)
                                {
                                    MessageBox.Show("ERROR AL INSERTAR MORATORIA A LA BD" + me.ToString());
                                }

                            }

                            if (cuota == dgvCuotas.RowCount)
                            {
                                CrudFolio.LiquidacionCuotas(folio);//PARA ACTUALIZAR EL ESTADO DEL FOLIO PRINCIPAL estadoPres EN LA TABLA TBFOLIO
                            }
                            dgvCuotas.DataSource = CrudFolio.queryDetallePres(folio).Tables[0];
                            decimal restante = restantePagar - decimal.Parse(txtAbono.Text);
                            restantePagar = restante;
                            txtAdeudoRest.Text = restante.ToString("C2");
                            mora = -1;
                            //break;
                        }
                        else
                        {
                            MessageBox.Show("LA CANTIDAD A ABONAR NO DEBE SER MENOR AL PAGO CORRESPONDIENTE"); //*break;
                        }
                    }

                }

            
        }

        private void exitData(int index) {

                decimal diasAdeudo = (decimal)dgvCuotas.Rows[index].Cells[3].Value;
                txtAbono.Text = diasAdeudo.ToString();
                this.folio = (int)dgvCuotas.Rows[index].Cells[0].Value;
                this.cuota = (int)dgvCuotas.Rows[index].Cells[1].Value;
                this.fecha = (dgvCuotas.Rows[index].Cells[2].Value).ToString().Trim();
                this.canTCuota = (decimal)dgvCuotas.Rows[index].Cells[3].Value;
                this.estado = (dgvCuotas.Rows[index].Cells[4].Value).ToString().Trim();

        }



        //PARA ABRIR LA VENTANA DE MORAOTIA
        private void showWinMora(int index) {

                DateTime fechaCuota = (DateTime)dgvCuotas.Rows[index].Cells[2].Value;
                string estado = (string)dgvCuotas.Rows[index].Cells[4].Value;

                try
                {
                    if (estado == "PENDIENTE" && fechaCuota < DateTime.Now)
                    {
                         frmVerMoratoria abrirMora = new frmVerMoratoria();

                        //TimeSpan difFechas = DateTime.Now - fechaCuota;
                        decimal dias = calcularDias(fechaCuota);//SE CITA EL METODO QUE CALCULA LA DIFERENCIA EN DIAS

                        if (this.lblModalidad.Text == "DIARIO")
                        {
                            abrirMora.moras(lblModalidad.Text, txtNombreCli.Text, txtApellido1Cli.Text, txtApellido2Cli.Text, Convert.ToInt32(dias));
                        }
                        else if (lblModalidad.Text == "SEMANAL")
                        {
                            decimal semana = dias / 7;
                            abrirMora.moras(lblModalidad.Text, txtNombreCli.Text, txtApellido1Cli.Text, txtApellido2Cli.Text, Convert.ToInt32(Math.Ceiling(semana)));
                        }
                   
                    abrirMora.mora = this;
                    abrirMora.ShowDialog();
                }
                    else { MessageBox.Show("SIN MORATORIA"); }

                }
                catch (Exception i)
                {
                    MessageBox.Show("ERROR AL CALCULAR FECHAS" + i.ToString());
                }

        }
    }

    
}
