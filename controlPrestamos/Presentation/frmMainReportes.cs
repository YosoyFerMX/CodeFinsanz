using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlPrestamos.Presentation
{
    public partial class frmMainReportes : Form
    {
        public frmMainReportes()
        {
            InitializeComponent();
        }

        private void btnPagosHoy_Click(object sender, EventArgs e)
        {
            frmInformeCobrosCobra abrirInf = new frmInformeCobrosCobra();
            abrirInf.Show();
        }

        private void btPrestamosGanancias_Click(object sender, EventArgs e)
        {
            if (GlobalUser.provilegioUsuario == "SUPERADMINISTRADOR" || GlobalUser.provilegioUsuario == "Administrador")
            {
                frmPrestamosGanancias abrir = new frmPrestamosGanancias();
                abrir.Show();
            }
            else { MessageBox.Show("NO TIENE ACCESO A ESTE MÓDULO"); }
            
        }

        private void btnPrestamosAtrazados_Click(object sender, EventArgs e)
        {
            frmCuotasVencidas abrir = new frmCuotasVencidas();
            abrir.Show();
        }

        private void frmMainReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            if (GlobalUser.provilegioUsuario == "SUPERADMINISTRADOR")
            {
                frmGanancias abrir = new frmGanancias();
                abrir.Show();

            }
            else { MessageBox.Show("NO TIENE EL PRIVILEGIO PARA INGRESAR A ESTE MÓDULO"); }
        }

        private void btnMoratoria_Click(object sender, EventArgs e)
        {
            frmGananciaMoras abrirMorasGanancias = new frmGananciaMoras();
            abrirMorasGanancias.ShowDialog();
        }
    }
}
