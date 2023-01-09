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
    public partial class frmUsuarios : Form
    {

        private bool accionEditarUsuario = false; //Para saber que tipo de accion eligio el usuario si editar o eliminar usario
        private int idUser = 0; //Para eliminar y editar cliente
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshDGVUsuarios()
        {


            if (CrudUsuarios.Usuarios() != null)
            {
                dgvUsuarios.DataSource = CrudUsuarios.Usuarios().Tables[0];
            }
            else {
                MessageBox.Show("Sin usuarios");
            }
        }

        private void limpiarCampos()
        {


            // CAmpos USUARIOS
            txtContraseUsu.Text = "";
            txtBuscarUsuario.Text = "";
            txtNomUsua.Text = "";
            txtApellidosUsua.Text = "";
            cmbPrivilegiosUs.Text = "";

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            refreshDGVUsuarios();
            limpiarCampos();
            //btnGuardarUsuario.Enabled = false;

        }

        private void btnEditarUsuario_Click_1(object sender, EventArgs e)
        {
            accionEditarUsuario = true;
            var filaSelectedCobra = dgvUsuarios.CurrentRow;
            if (filaSelectedCobra != null)
            {

                idUser = (int)filaSelectedCobra.Cells[0].Value;
                if (idUser != 1)
                {
                    try
                    {

                        txtNomUsua.Text = (string)filaSelectedCobra.Cells[1].Value;
                        txtApellidosUsua.Text = (string)filaSelectedCobra.Cells[2].Value;
                        cmbPrivilegiosUs.Text = (string)filaSelectedCobra.Cells[3].Value;
                        txtContraseUsu.Text = (string)filaSelectedCobra.Cells[4].Value;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al exportar los datos del usuario: " + ex.ToString());
                    }
                }
                else {
                    MessageBox.Show("NO PUEDE EDITAR A SUPERADMINISTRADOR");
                }

                


            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            var filaSelectedCobra = dgvUsuarios.CurrentRow;
            if (filaSelectedCobra != null)
            {
                idUser = (int)filaSelectedCobra.Cells[0].Value;

                if (idUser != 1 && idUser != 2)
                {
                    DialogResult result = MessageBox.Show("¿CONFIRME PARA ELIMINAR USUARIO?", "SALIR", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        CrudUsuarios.EliminarUsuario(idUser);
                        refreshDGVUsuarios();
                    }
                    
                }
                else {
                    MessageBox.Show("NO PUEDE ELIMINAR A ESTE USUARIO");
                }

                

            }
            else
            {
                MessageBox.Show("Seleccione una Columna");
            }
        }

        private void btnGuardarUsuario_Click_1(object sender, EventArgs e)
        {
            if (txtNomUsua.Text != "" && txtApellidosUsua.Text != "" && txtContraseUsu.Text != "")
            {
                if (accionEditarUsuario == true)
                {
                    try
                    {
                        CrudUsuarios.Editar_Usuario(txtNomUsua.Text.Trim(), txtApellidosUsua.Text.Trim(), cmbPrivilegiosUs.Text.Trim(), txtContraseUsu.Text.Trim(), idUser);
                        accionEditarUsuario = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR AL ACTUALIZAR LOS DATOS DEL USUARIO: " + ex.ToString());
                    }

                }
                else
                {
                    try
                    {
                        CrudUsuarios.Insertar_USuario(txtNomUsua.Text.Trim(), txtApellidosUsua.Text.Trim(), txtContraseUsu.Text.Trim(), cmbPrivilegiosUs.Text.Trim());



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR AL EXPORTAR LOS DATOS DEL USUARIO: " + ex.ToString());
                    }


                }
                refreshDGVUsuarios();
                limpiarCampos();

            }
            else { MessageBox.Show("NO DEJE CAMPOS VACIOS"); }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
