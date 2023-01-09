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
using System.IO;
using System.Drawing.Imaging;

namespace controlPrestamos.Presentation
{
    public partial class frmCobradores : Form
    {
        private bool accionEdiGuarCob = false;
        private int id_Cobrador = 0;

        //-----------------------------------------------------

        public frmCobradores()
        {
            InitializeComponent();
        }

        private void refreshDGVCobradores()
        {
            if (CrudCobradores.Cobradores() != null)
            {
                dgvCobradores.DataSource = CrudCobradores.Cobradores().Tables[0].DefaultView;
                dgvCobradores.Columns[7].Visible = false;
            }
            else { MessageBox.Show("NO EXISTEN COBRADORES"); }
            
        }
        private void validaCamposCobradores()
        {
            var validar = !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido1.Text) && !string.IsNullOrEmpty(txtApellido2.Text) &&
                !string.IsNullOrEmpty(txtMunicipio.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtZona.Text);

            btnGuardar.Enabled = validar;
        }

        private void EnabledCamp(bool check) {
            if (check == true)
            {
                txtNombre.Enabled = false;
                txtApellido1.Enabled = false;
                txtApellido2.Enabled = false;
                txtMunicipio.Enabled = false;
                txtZona.Enabled = false;
                txtTelefono.Enabled = false;
            }
            else {
                txtNombre.Enabled = true;
                txtApellido1.Enabled = true;
                txtApellido2.Enabled = true;
                txtMunicipio.Enabled = true;
                txtZona.Enabled = true;
                txtTelefono.Enabled = true;
            }
        
        }

        private void frmCobradores_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            limpiarCampos();
            refreshDGVCobradores();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvCobradores.DataSource;
            bs.Filter = "Nombre like '%" + txtBuscar.Text + "%'";
            dgvCobradores.DataSource = bs;
        }

        private void limpiarCampos()
        {
            //----------------- CAMPOS DE COBRADORES
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtMunicipio.Text = "";
            txtZona.Text = "";
            txtTelefono.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            //pcbFoto.Image.Save(ms, ImageFormat.Jpeg);
            if (accionEdiGuarCob == true)
            {
                try
                {
                    CrudCobradores.editar_Cobrador(1, txtNombre.Text.ToString().Trim(), txtApellido1.Text.ToString().Trim(), txtApellido2.Text.ToString().Trim(), txtMunicipio.Text.ToString().Trim(), txtZona.Text.ToString().Trim(), txtTelefono.Text.ToString().Trim(), ms.GetBuffer(), id_Cobrador);
                    limpiarCampos();
                    refreshDGVCobradores();
                    accionEdiGuarCob = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR A GUARDAR REGISTROS", ex.ToString());
                }
            }
            else
            {
                try
                {
                    CrudCobradores.Insertar_Cobradores(1, txtNombre.Text.ToString().Trim(), txtApellido1.Text.ToString().Trim(), txtApellido2.Text.ToString().Trim(), txtMunicipio.Text.ToString().Trim(), txtZona.Text.ToString().Trim(), txtTelefono.Text.ToString().Trim(), ms.GetBuffer());
                    refreshDGVCobradores();
                    limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL GUARDAR REGISTROS", ex.ToString());
                }
            }



            //byte[] image = ms.ToArray();
        }

        private void btnEditarCobrador_Click(object sender, EventArgs e)
        {
            EnabledCamp(true);
            accionEdiGuarCob = true;
            var filaSelectedCobra = dgvCobradores.CurrentRow;
            if (filaSelectedCobra != null)
            {

                try
                {
                    id_Cobrador = (int)filaSelectedCobra.Cells[0].Value;
                    txtNombre.Text = (string)filaSelectedCobra.Cells[1].Value;
                    txtApellido1.Text = (string)filaSelectedCobra.Cells[2].Value;
                    //txtApellido2.Text = CrudCobradores.Cobradores().Tables[0].Rows[0]["SEGUNDO APELLIDO"].ToString(); ---> Ejemplo para tomar un dato en espeficico de un DS
                    txtApellido2.Text = (string)filaSelectedCobra.Cells[3].Value;
                    txtMunicipio.Text = (string)filaSelectedCobra.Cells[4].Value;
                    txtZona.Text = (string)filaSelectedCobra.Cells[5].Value;
                    txtTelefono.Text = (string)filaSelectedCobra.Cells[6].Value;
                    byte[] imagen = new byte[0];
                    //imagen = (byte[])filaSelectedCobra.Cells[7].Value;

                    //MessageBox.Show(imagen.ToString());
                    //MemoryStream ms = new MemoryStream(imagen);
                    ///pcbFoto.Image = Bitmap.FromStream(ms);

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

        private void btnEliminarCob_Click(object sender, EventArgs e)
        {
            if (GlobalUser.provilegioUsuario == "SUPERADMINISTRADOR")
            {
                var filaSelectedCobra = dgvCobradores.CurrentRow;
                if (filaSelectedCobra != null)
                {
                    id_Cobrador = (int)filaSelectedCobra.Cells[0].Value;

                    DialogResult result = MessageBox.Show("¿CONFIRME PARA ELIMINAR COBRADOR?", "SALIR", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        CrudCobradores.DeleteCobrador(id_Cobrador);
                        refreshDGVCobradores();
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione una Columna");
                }
            }
            else { MessageBox.Show("NO TIENES PRIVILEGIOS PARA REALIZAR ESTA ACCIÓN"); }
            
        }
        private void btnReporteCob_Click(object sender, EventArgs e)
        {
            frmReportCobradores abrirCob = new frmReportCobradores();
            abrirCob.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validaCamposCobradores();
        }

        private void txtApellido1_TextChanged(object sender, EventArgs e)
        {
            validaCamposCobradores();
        }

        private void txtApellido2_TextChanged(object sender, EventArgs e)
        {
            validaCamposCobradores();
        }

        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {
            validaCamposCobradores();
        }

        private void txtZona_TextChanged(object sender, EventArgs e)
        {
            validaCamposCobradores();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            validaCamposCobradores();
        }

        private void btnDesbloq_Click(object sender, EventArgs e)
        {
            EnabledCamp(false);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
