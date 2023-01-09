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
using controlPrestamos.Informes;

namespace controlPrestamos.Presentation
{
    public partial class frmPrestamos : Form, IClientes
    {
        private int folioPres;
        private int idClientePres = 0;
        private decimal abonoxCuot = 0;
        decimal montoTotal = 0;//varible privada donde se almacena el monto total del prestamo
        int n = 0; //GUARDA LAS ACUOTAS DEL PRESTAMO
        DateTime nuevaFecha; //VARIABLE ASIGNADA PARA GUARDAR LA FECHA DEL PRESTAMO
        bool insertarDetallePres = false; //CUANDO SE LE INSERTAR PASARA A VERDADERO Y SE INSERTARA A LA BD LOS REGISTROS DEL CALCULO DEFECHAS Y MONTPOS
        
        
        public frmPrestamos()
        {
            InitializeComponent();
        }

        public void EjecutarClientes(int id, string nombre, string apellido1, string apellido2, string municipio, string telefono, string direccion, string cobAsignado)
        {
            // Se traen los dtaos
            this.idClientePres = id;
            this.txtNombreCli.Text = nombre;
            this.txtApellido1Cli.Text = apellido1;
            this.txtApellido2Cli.Text = apellido2;
            this.txtTelefonoCli.Text = telefono;
            this.txtMunicipioCli.Text = municipio;
            this.txtDireccionCli.Text = direccion;
            this.txtCobAsigAcli.Text = cobAsignado;
            //txtApellido2.Text = CrudCobradores.Cobradores().Tables[0].Rows[0]["SEGUNDO APELLIDO"].ToString()
            
            int moras = (int)CrudFolio.queryMorasPendientesRenovacion(id).Tables[0].Rows[0]["ConteoMoras"];
            int pendientes = (int)CrudFolio.queryPendientesRenovacion(id).Tables[0].Rows[0]["ConteoMoras"];
            int cuotasPend = 0;
            string modalidadCuotas = "";
            if (null == CrudFolio.queryCountCoutRest(id)) {
                cuotasPend = 0;
                modalidadCuotas = "";
            }
            else {
                cuotasPend = (int)CrudFolio.queryCountCoutRest(id).Tables[0].Rows[0]["sumPagosPendientes"];
                modalidadCuotas = (string)CrudFolio.queryCountCoutRest(id).Tables[0].Rows[0]["modalidadPago"];

               
            }

            if (modalidadCuotas == "DIARIO")
            {
                int cuotaReal = 32 - cuotasPend;

                if (moras > 2 && pendientes > 2 && cuotaReal <= 30)
                {
                    MessageBox.Show("PARA RENOVAR ESTE CLIENTE SERÁ HASTA LA CUOTAS 30 A 32 DE SU PRESTAMO ACTUAL");
                    txtMonto.Enabled = false;
                }
                else if (moras == 0 && pendientes == 0 && cuotaReal <= 25)
                {
                    MessageBox.Show("PARA RENOVAR ESTE CLIENTE SERÁ HASTA LA CUOTA 25 DE SU PRESTAMO ACTUAL");
                    txtMonto.Enabled = false;
                }
                else if (3 >= moras || 3 >= pendientes && cuotaReal <= 25)
                {
                    MessageBox.Show("ESTE CLIENTE TIENE CUOTAS O MORAS ATRASADAS. POR FAVOR, PARA RENOVAR UN PRESTAMO LIQUIDE LAS CUOTAS ATRAZADAS Y MORAS PERMITIDAS PARA RENOVAR EL PRESTANO.");
                    txtMonto.Enabled = false;
                }

            } else if (modalidadCuotas == "SEMANAL") {

                int cuotaReal = 12 - cuotasPend;

                if (moras > 2 && pendientes > 2 && cuotaReal <= 12)
                {
                    MessageBox.Show("PARA RENOVAR ESTE CLIENTE SERÁ HASTA LA CUOTAS 12 DE SU PRESTAMO ACTUAL");
                    txtMonto.Enabled = false;
                }
                else if (moras == 0 && pendientes == 0 && cuotaReal < 10)
                {
                    MessageBox.Show("PARA RENOVAR ESTE CLIENTE SERÁ HASTA LA CUOTA 10 DE SU PRESTAMO ACTUAL");
                    txtMonto.Enabled = false;
                }
                else if (3 >= moras || 3 >= pendientes && cuotaReal <= 10)
                {
                    MessageBox.Show("ESTE CLIENTE TIENE CUOTAS O MORAS ATRASADAS. POR FAVOR, PARA RENOVAR UN PRESTAMO LIQUIDE LAS CUOTAS ATRAZADAS Y MORAS PERMITIDAS PARA RENOVAR EL PRESTANO.");
                    txtMonto.Enabled = false;
                }

            }






        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            frmSelecCliente abrirCli = new frmSelecCliente();
            abrirCli.cli = this;
            abrirCli.ShowDialog();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(sender,e);
        }


        private void detallePrestamoInsert(int i) {
            dgvCuotas.Rows.Clear();

            for (i = 1; i <= n; i++)
            {
                int r = dgvCuotas.Rows.Add();
                //SE ESCOGE LA MODALIDAD DE PAGO
                if (cmbFormaPago.SelectedIndex == 3)
                {
                    nuevaFecha = nuevaFecha.AddMonths(1);
                }
                else if (cmbFormaPago.SelectedIndex == 2) {
                    nuevaFecha = nuevaFecha.AddDays(15);
                }
                else if (cmbFormaPago.SelectedIndex == 1)
                {
                    nuevaFecha = nuevaFecha.AddDays(7);
                }
                else if (cmbFormaPago.SelectedIndex == 0)
                {
                    nuevaFecha = nuevaFecha.AddDays(1);
                }



                dgvCuotas.Rows[r].Cells[0].Value = txtFolio.Text;
                dgvCuotas.Rows[r].Cells[1].Value = i;
                dgvCuotas.Rows[r].Cells[2].Value = nuevaFecha.ToString("MM-dd-yyyy");
                dgvCuotas.Rows[r].Cells[3].Value = (montoTotal / n).ToString("C2");
                dgvCuotas.Rows[r].Cells[4].Value = "PENDIENTE";

                if (insertarDetallePres == true) {
                    CrudFolio.Insertar_DetalleFolioPres(folioPres, i,nuevaFecha.ToString("MM-dd-yyyy"), (montoTotal/n),"PENDIENTE");
                    btnGuardarPrestamo.Enabled = false;
                   
                }
            }
            if (insertarDetallePres == true)
            { MessageBox.Show("PRESTAMO GUARDADO"); }
                insertarDetallePres = false;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text != "")
            {
                dgvCuotas.Rows.Clear();
                nuevaFecha = calendarPres.Value; //El control DataTimerPicker le envia su fecha al nuevo objeto para recalcular la suma de las fechas
                montoTotal = Calculos.calculo_Monto(decimal.Parse(txtMonto.Text), nUpDawnInteres.Value);
                txtMontoPagar.Text = montoTotal.ToString("C2");


                n = (int)nUpDawnCuotas.Value;
                abonoxCuot = (montoTotal / n);
                lblValxCuot.Text = abonoxCuot.ToString("C");
                lblInteres.Text = ((montoTotal) - (decimal.Parse(txtMonto.Text))).ToString("C2");
                detallePrestamoInsert(1);
            }
            else {
                MessageBox.Show("ESCRIBA EL MONTO DEL PRESTAMO");
            }
           
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            
            if (CrudFolio.Folio() != null)
            {
                int folio = (int)CrudFolio.Folio().Tables[0].Rows[0]["folio"] + 1;
                txtFolio.Text = folio.ToString();
            }
            else {
                txtFolio.Text = "1000";
            }


            cmbFormaPago.Text = "DIARIO";
        }

        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            if (txtNombreCli.Text != "" && txtMonto.Text != "")
            {
                folioPres = int.Parse(txtFolio.Text); //Se captura el folio para guardar en detalles

                int idUser = 1;
                decimal restantePrestamo = this.montoTotal;
                string modalidadPrestamo = this.cmbFormaPago.Text;
                int cuotaPrestamo = this.n;
                decimal interesPrestamo = this.nUpDawnInteres.Value;

                //string observaciones = this.richtxtObserv.Text;
                //DateTime fechaInsert = calendarPres.Value;
                nuevaFecha = calendarPres.Value;
                insertarDetallePres = true;

                try {
                    CrudFolio.Insertar_NvoFolio(idUser, idClientePres, montoTotal, restantePrestamo, modalidadPrestamo, cuotaPrestamo, interesPrestamo, "Todos los dias", nuevaFecha.ToString("MM-dd-yyyy"), "");


                    detallePrestamoInsert(1);

                }
                catch (Exception ex) {
                    MessageBox.Show("ERROR AL GUARDAR REGISTROS" + ex.ToString());
                }

               

            }
            else {
               MessageBox.Show("SELECCIONE UN CLIENTE Y AGREGUE EL MONTO DEL PRESTAMO");
            
            }
            
            
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            frmSelecPrestamo abrirPres = new frmSelecPrestamo();
            abrirPres.accionCnPresta = true;
            abrirPres.ShowDialog();
            
        }

        private void printContrato_Click(object sender, EventArgs e)
        {


            if (txtApellido1Cli.Text != "" && txtNombreAval.Text != "")
            {
                int cuot = Convert.ToInt32(nUpDawnCuotas.Value);
                string nomCli = txtNombreCli.Text + " " + txtApellido1Cli.Text + " " + txtApellido2Cli.Text;
                ContratoPrestamo.PrintContrato(nomCli, txtMontoPagar.Text, nUpDawnCuotas.Value.ToString(), txtDireccionCli.Text + " " + txtMunicipioCli.Text, txtTelefonoCli.Text, txtNombreAval.Text, txtDirAval.Text, txtTelAval.Text, decimal.Parse(txtMonto.Text), nUpDawnInteres.Value, cuot, calendarPres.Value, abonoxCuot, cmbFormaPago.SelectedIndex, idClientePres.ToString());
            }
            else {
                MessageBox.Show("Seleccione un cliente");
            }
                
        }

        private void btnPrintAmorti_Click(object sender, EventArgs e)
        {

        }
    }
}
