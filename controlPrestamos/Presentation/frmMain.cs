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
using System.Drawing.Imaging;
using System.IO;
using controlPrestamos.Presentation;

namespace controlPrestamos
{
    public partial class frmMain : Form
    {






        public frmMain()
        {
            InitializeComponent();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrMain.Enabled = true;
            AbritFotmHijo(new frmInicio());
            this.btnInicio.BackColor = Color.FromArgb(249, 158, 9);
            lblUsuarioLog.Text = GlobalUser.nombreUsuario;
        }

        //PROBAR PANEL
        private void AbritFotmHijo(Form fh) {
            if (this.pnlContenedor.Controls.Count > 0) {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            AbritFotmHijo(new frmClientes());//Abre el formulario INicio

            this.btnClient.BackColor = Color.FromArgb(249, 158, 9);
            this.btnInicio.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobradores.BackColor = Color.FromArgb(32, 47, 66);
            this.btnUsuarios.BackColor = Color.FromArgb(32, 47, 66);
            this.btnPrestamos.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobros.BackColor = Color.FromArgb(32, 47, 66);
            this.button6.BackColor = Color.FromArgb(32, 47, 66);
            this.btnMoras.BackColor = Color.FromArgb(32, 47, 66);


        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbritFotmHijo(new frmInicio());
            this.btnInicio.BackColor = Color.FromArgb(249, 158, 9);
            this.btnClient.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobradores.BackColor = Color.FromArgb(32, 47, 66);
            this.btnUsuarios.BackColor = Color.FromArgb(32, 47, 66);
            this.btnPrestamos.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobros.BackColor = Color.FromArgb(32, 47, 66);
            this.button6.BackColor = Color.FromArgb(32, 47, 66);
            this.btnMoras.BackColor = Color.FromArgb(32, 47, 66);

        }



        private void btnCobros_Click(object sender, EventArgs e)
        {
            AbritFotmHijo(new frmCobros());//Abre el nuevo formulario 


            this.btnCobros.BackColor = Color.FromArgb(249, 158, 9);
            this.btnPrestamos.BackColor = Color.FromArgb(32, 47, 66);
            this.btnClient.BackColor = Color.FromArgb(32, 47, 66);
            this.btnInicio.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobradores.BackColor = Color.FromArgb(32, 47, 66);
            this.btnUsuarios.BackColor = Color.FromArgb(32, 47, 66);
            this.button6.BackColor = Color.FromArgb(32, 47, 66);
            this.btnMoras.BackColor = Color.FromArgb(32, 47, 66);
        }

        private void btnCobradores_Click(object sender, EventArgs e)
        {
            if (GlobalUser.provilegioUsuario == "Cajero")
            {
                MessageBox.Show("NO TIENE PRIVILEGIOS PARA INGRESAR A ESTE MODULO");

            }
            else {
                //AbritFotmHijo(new frmCobradores());
                var form = Application.OpenForms.OfType<frmCobradores>().FirstOrDefault();
                frmCobradores cobradores = form ?? new frmCobradores();
                AbritFotmHijo(cobradores);
                this.btnCobradores.BackColor = Color.FromArgb(249, 158, 9);
                this.btnClient.BackColor = Color.FromArgb(32, 47, 66);
                this.btnInicio.BackColor = Color.FromArgb(32, 47, 66);
                this.btnUsuarios.BackColor = Color.FromArgb(32, 47, 66);
                this.btnPrestamos.BackColor = Color.FromArgb(32, 47, 66);
                this.btnCobros.BackColor = Color.FromArgb(32, 47, 66);
                this.button6.BackColor = Color.FromArgb(32, 47, 66);
                this.btnMoras.BackColor = Color.FromArgb(32, 47, 66);
            }
    
        }



        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (GlobalUser.provilegioUsuario == "Cajero" || GlobalUser.provilegioUsuario == "Cobrador")
            {
                MessageBox.Show("NO TIENE PRIVILEGIOS PARA INGRESAR A ESTE MODULO");
                
            }
            else {
                //AbritFotmHijo(new frmUsuarios());
                var form = Application.OpenForms.OfType<frmUsuarios>().FirstOrDefault();
                frmUsuarios usuarios = form ?? new frmUsuarios();
                AbritFotmHijo(usuarios);
                this.btnUsuarios.BackColor = Color.FromArgb(249, 158, 9);
                this.btnClient.BackColor = Color.FromArgb(32, 47, 66);
                this.btnInicio.BackColor = Color.FromArgb(32, 47, 66);
                this.btnCobradores.BackColor = Color.FromArgb(32, 47, 66);
                this.btnPrestamos.BackColor = Color.FromArgb(32, 47, 66);
                this.btnCobros.BackColor = Color.FromArgb(32, 47, 66);
                this.button6.BackColor = Color.FromArgb(32, 47, 66);
                this.btnMoras.BackColor = Color.FromArgb(32, 47, 66);
            }
      

        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbritFotmHijo(new frmPrestamos());//Abre el nuevo formulario 

            this.btnPrestamos.BackColor = Color.FromArgb(249, 158, 9);
            this.btnClient.BackColor = Color.FromArgb(32, 47, 66);
            this.btnInicio.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobradores.BackColor = Color.FromArgb(32, 47, 66);
            this.btnUsuarios.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobros.BackColor = Color.FromArgb(32, 47, 66);
            this.button6.BackColor = Color.FromArgb(32, 47, 66);
            this.btnMoras.BackColor = Color.FromArgb(32, 47, 66);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialogRes = MessageBox.Show("¿SEGURO DESEA SALIR?","CERRAR SESIÓN", MessageBoxButtons.OKCancel);
            if (dialogRes == DialogResult.OK)
            {
                Application.Restart();

            }
            else if (dialogRes == DialogResult.Cancel) { 
            
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbritFotmHijo(new frmMainReportes());//Abre el nuevo formulario 

            this.button6.BackColor = Color.FromArgb(249, 158, 9);
            this.btnPrestamos.BackColor = Color.FromArgb(32, 47, 66);
            this.btnClient.BackColor = Color.FromArgb(32, 47, 66);
            this.btnInicio.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobradores.BackColor = Color.FromArgb(32, 47, 66);
            this.btnUsuarios.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobros.BackColor = Color.FromArgb(32, 47, 66);
            this.btnMoras.BackColor = Color.FromArgb(32, 47, 66);
        }

        private void btnMoras_Click(object sender, EventArgs e)
        {
            AbritFotmHijo(new frmMoras());//Abre el nuevo formulario 
            this.btnMoras.BackColor = Color.FromArgb(249, 158, 9);
            this.button6.BackColor = Color.FromArgb(32, 47, 66);
            this.btnPrestamos.BackColor = Color.FromArgb(32, 47, 66);
            this.btnClient.BackColor = Color.FromArgb(32, 47, 66);
            this.btnInicio.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobradores.BackColor = Color.FromArgb(32, 47, 66);
            this.btnUsuarios.BackColor = Color.FromArgb(32, 47, 66);
            this.btnCobros.BackColor = Color.FromArgb(32, 47, 66);
        
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("D");
        }
    }
    
}
