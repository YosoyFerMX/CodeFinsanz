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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
            tmrFechayHora.Enabled = true;
            if (CrudClientes.Clientes() != null)
            {
                int count = CrudClientes.Clientes().Tables[0].Rows.Count;
                lblName.Text = count.ToString();
            }
            else {
                lblName.Text = "0";
            }

            if (CrudCobradores.Cobradores() != null)
            {
                int countCob = CrudCobradores.Cobradores().Tables[0].Rows.Count;
                lblCob.Text = countCob.ToString();
            }
            else {
                lblCob.Text = "0";
            }

            

            //chartInicio.Series[0].Points.DataBindY();
            string filt = null;
            if (CrudFolio.querySelecPrestamo(filt) != null)
            {
                int countPrestamos = CrudFolio.querySelecPrestamo(filt).Tables[0].Rows.Count;
                lblPres.Text = countPrestamos.ToString();
            }
            else {
                lblPres.Text = "0";
            }
            

        }

        private void tmrFechayHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("H:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("D");
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            frmAjustes abrirAjustes = new frmAjustes();
            abrirAjustes.ShowDialog();
        }
    }
}
