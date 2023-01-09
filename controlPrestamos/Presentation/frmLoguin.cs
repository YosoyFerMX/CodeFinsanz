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
using controlPrestamos.Presentation;

namespace controlPrestamos.Presentation
{
    public partial class frmLoguin : Form
    {
        private string usuario;
        private string pssw;
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLoguin_Load(object sender, EventArgs e)
        {
            txtUsuario.Size = new Size(290,35);
        }

        private void btnLoguin_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool validarCampos()
        {
            bool ok = true;

            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                ok = false;
                erProvUsuario.SetError(txtUsuario, "Ingresar Usuario");
                errorProvPass.SetError(txtPassword, "Ingresar Contraseña");
            }

            return ok;
        }
        private void btnLoguin_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                this.usuario = this.txtUsuario.Text;
                this.pssw = this.txtPassword.Text;

                if (CrudUsuarios.UsuariosLog(usuario, pssw) != null)
                {
                    string privilegio = CrudUsuarios.UsuariosLog(usuario, pssw).Tables[0].Rows[0]["privilegiosU"].ToString();
                    GlobalUser globalUser = new GlobalUser(usuario,privilegio);
                    
                    frmBienvenida bv = new frmBienvenida();
                    this.Hide();
                    bv.Show();
                    

                }
                else { MessageBox.Show("DATOS INCORRECTOS"); }
                
            }
            
        }


        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nombreDeTuBoton.PerformClick();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnLoguin.PerformClick();
            }
        }
    }
}
