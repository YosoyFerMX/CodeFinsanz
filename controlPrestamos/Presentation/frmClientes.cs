using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlPrestamos.Presentation;
using controlPrestamos.Business;
using System.Drawing.Imaging;
using System.IO;

namespace controlPrestamos.Presentation
{
    public partial class frmClientes : Form, ICobradores
    {
        public int idSelectCob = 0;
        private int idCliente = 0;
        private int idUser = 0; //Para eliminar y editar cliente
        private bool accionEditCli = false;

        public frmClientes()
        {
            InitializeComponent();
        }
        public void Ejecutar_Cobradores(int id, string nombre)
        {
            idSelectCob = id;
            txtasigCob.Text = nombre;
        }

        private void refreshDGVClient()
        {
            if (CrudClientes.Clientes() != null)
            {
                dgvClient.DataSource = CrudClientes.Clientes().Tables[0].DefaultView;
                dgvClient.Columns[10].Visible = false;

            }
            else { MessageBox.Show("NO EXISTEN CLIENTES PARA MOSTRAR"); }
            
        }

        // ------------ VALIDACIONES DE CAMPOS-----------------------------
        private void validaCamposClientes()
        {
            var validar = !string.IsNullOrEmpty(txtNomCli.Text) && !string.IsNullOrEmpty(txtPrimApCli.Text) && !string.IsNullOrEmpty(txtSegApCli.Text) &&
                !string.IsNullOrEmpty(txtGenCli.Text) && !string.IsNullOrEmpty(txttelCli.Text) && !string.IsNullOrEmpty(txtMpioCli.Text) && !string.IsNullOrEmpty(txtDirCli.Text)
                && !string.IsNullOrEmpty(txtEdoCli.Text) && !string.IsNullOrEmpty(txtasigCob.Text);

            btnGuardarCli.Enabled = validar;
        }

        //----------------------------------------------------------------------------------------

        private void frmInicio_Load(object sender, EventArgs e)
        {
            txtasigCob.Enabled = false;
            btnGuardarCli.Enabled = false;
            refreshDGVClient();

        }

        private void enabledCampos (bool check){
            if (check == true)
            { //comprueba si el usuarui quiere ver al cliente para bloquear los texts box con un true
                txtNomCli.Enabled = false;
                txtPrimApCli.Enabled = false;
                txtSegApCli.Enabled = false;
                txtGenCli.Enabled = false;
                txttelCli.Enabled = false;
                txtDirCli.Enabled = false;
                txtMpioCli.Enabled = false;
                txtEdoCli.Enabled = false;
                txtasigCob.Enabled = false;
                btnBuscarCobrador.Enabled = false;
            }
            else {
                txtNomCli.Enabled = true;
                txtPrimApCli.Enabled = true;
                txtSegApCli.Enabled = true;
                txtGenCli.Enabled = true;
                txttelCli.Enabled = true;
                txtDirCli.Enabled = true;
                txtMpioCli.Enabled = true;
                txtEdoCli.Enabled = true;
                txtasigCob.Enabled = true;
                btnBuscarCobrador.Enabled = true;
            }
        }


        private void limpiarCampos()
        {
            //----------------- CAMPOS DE CLIENTES
            txtNomCli.Text = "";
            txtPrimApCli.Text = "";
            txtSegApCli.Text = "";
            txtGenCli.Text = "";
            txttelCli.Text = "";
            txtDirCli.Text = "";
            txtMpioCli.Text = "";
            txtEdoCli.Text = "";
            txtasigCob.Text = "";
        }


        private void btnBuscarCobrador_Click_1(object sender, EventArgs e)
        {
            frmSelecCobradores OpenCob = new frmSelecCobradores();
            OpenCob.cob = this;
            OpenCob.ShowDialog();
        }

        private void btnEditarCliente_Click_1(object sender, EventArgs e)
        {
            enabledCampos(true);
            accionEditCli = true;
            var filaSelectedCobra = dgvClient.CurrentRow;
            if (filaSelectedCobra != null)
            {

                try
                {
                    idCliente = (int)filaSelectedCobra.Cells[0].Value;
                    txtNomCli.Text = (string)filaSelectedCobra.Cells[1].Value;
                    txtPrimApCli.Text = (string)filaSelectedCobra.Cells[2].Value;
                    //txtApellido2.Text = CrudCobradores.Cobradores().Tables[0].Rows[0]["SEGUNDO APELLIDO"].ToString(); ---> Ejemplo para tomar un dato en espeficico de un DS
                    txtSegApCli.Text = (string)filaSelectedCobra.Cells[3].Value;
                    txtGenCli.Text = (string)filaSelectedCobra.Cells[4].Value;
                    txtMpioCli.Text = (string)filaSelectedCobra.Cells[5].Value;
                    txtEdoCli.Text = (string)filaSelectedCobra.Cells[6].Value;
                    txttelCli.Text = (string)filaSelectedCobra.Cells[7].Value;
                    txtDirCli.Text = (string)filaSelectedCobra.Cells[8].Value;
                    txtasigCob.Text = (string)filaSelectedCobra.Cells[9].Value;
                    idSelectCob = (int)filaSelectedCobra.Cells[10].Value;
                    byte[] imagen = new byte[0];
                    //imagen = (byte[])filaSelectedCobra.Cells[7].Value;

                    //MessageBox.Show(imagen.ToString());
                    //MemoryStream ms = new MemoryStream(imagen);
                    //pcbFoto.Image = Bitmap.FromStream(ms);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
                }


            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnEliminarCliente_Click_1(object sender, EventArgs e)
        {
            if (GlobalUser.provilegioUsuario == "SUPERADMINISTRADOR")
            {
                var filaSelectedCobra = dgvClient.CurrentRow;
                if (filaSelectedCobra != null)
                {
                    idCliente = (int)filaSelectedCobra.Cells[0].Value;

                    DialogResult result = MessageBox.Show("¿CONFIRME PARA ELIMINAR CLIENTE?", "SALIR", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        CrudClientes.EliminaCliente(idCliente);
                        refreshDGVClient();
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione una Columna");
                }
            }
            else {
                MessageBox.Show("NO TIENES PRIVILEGIOS PARA REALIZAR ESTA ACCIÓN");
            }
            
        }

        private void btnBuscarFotoCli_Click(object sender, EventArgs e)
        {
        }

        private void txtNomCli_TextChanged(object sender, EventArgs e)
        {
            validaCamposClientes();
        }

        private void txtPrimApCli_TextChanged(object sender, EventArgs e)
        {
            validaCamposClientes();
        }

        private void txtSegApCli_TextChanged(object sender, EventArgs e)
        {
            validaCamposClientes();
        }

        private void txtGenCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            validaCamposClientes();
        }

        private void txttelCli_TextChanged(object sender, EventArgs e)
        {
            validaCamposClientes();
        }

        private void txtDirCli_TextChanged(object sender, EventArgs e)
        {
            validaCamposClientes();
        }

        private void txtMpioCli_TextChanged(object sender, EventArgs e)
        {
            validaCamposClientes();
        }

        private void txtEdoCli_TextChanged(object sender, EventArgs e)
        {
            validaCamposClientes();
        }

        private void txtasigCob_TextChanged(object sender, EventArgs e)
        {
            validaCamposClientes();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvClient.DataSource;
            bs.Filter = "Nombre like '%" + txtSearchName.Text + "%'";
            dgvClient.DataSource = bs;
        }

        private void btnGuardarCli_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            string mpioCli = txtMpioCli.Text.ToString().Trim();
            string nombre = txtNomCli.Text.ToString().Trim();
            string apellido1 = txtPrimApCli.Text.ToString().Trim();
            string ape2 = txtSegApCli.Text.ToString().Trim();
            string gen = txtGenCli.Text.ToString().Trim();
            string tel = txttelCli.Text.ToString().Trim();
            string dir = txtDirCli.Text.ToString().Trim();
            string sdo = txtEdoCli.Text.Trim();
            // pcbFotoCliente.Image.Save(ms, ImageFormat.Jpeg);//PENDIENTE
            if (accionEditCli == true)
            {
                try
                {
                    CrudClientes.Editar_Clientes(1, idSelectCob, nombre, apellido1, ape2, gen, tel, dir, mpioCli, sdo, null, idCliente);
                    refreshDGVClient();
                    idSelectCob = 0;
                    limpiarCampos();
                    accionEditCli = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR AL GUARDAR REGISTROS" + ex.ToString());
                }



            }
            else
            {
                try
                {
                    CrudClientes.Insertar_Clientes(1, idSelectCob, nombre, apellido1, ape2, gen, tel, dir, mpioCli, sdo, ms.GetBuffer());
                    refreshDGVClient();
                    idSelectCob = 0;
                    limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL GUARDAR REGISTROS" + ex.ToString());
                }

            }

        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {

            frmReporteClientes abrirreporteCli = new frmReporteClientes();
            abrirreporteCli.Show();
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            enabledCampos(false);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

    }
}
