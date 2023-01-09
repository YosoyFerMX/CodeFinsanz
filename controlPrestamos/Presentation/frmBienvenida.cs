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

namespace controlPrestamos.Presentation
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }
        
        private void tmrBienvenida_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100) {
                tmrBienvenida.Stop();
                tmrBienve2.Start();
            }
        }

        private void tmrBienve2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if (this.Opacity == 0) {
                tmrBienve2.Stop();
                frmMain Main = new frmMain();
                this.Close();
                
                
                Main.Show();
            }
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            lblUser.Text = GlobalUser.nombreUsuario; 
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            tmrBienvenida.Start();

        }
    }
}
