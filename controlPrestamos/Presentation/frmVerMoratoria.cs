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
    public partial class frmVerMoratoria : Form
    {
        private int semanaDia = 0;
        private decimal reacargoMoratorio = 0;

        public IMoratoria mora { get; set; }
        public frmVerMoratoria()
        {
            InitializeComponent();
        }

        public void moras(string modalidad, string cliente, string ape1, string ape2, int semDias) {
            this.lblModalidad.Text = modalidad;
            this.lblCli.Text = cliente + " " + ape1 + " " + ape2;
            this.semanaDia = 1;
            this.txtDiaAdeu.Text = semanaDia.ToString();

            if (modalidad == "SEMANAL") {
                upDawnMonto.Text = MorasQuery.CtrolMoratorias().Tables[0].Rows[0]["semanal"].ToString();
            } else if (modalidad == "DIARIO") {
                upDawnMonto.Text = MorasQuery.CtrolMoratorias().Tables[0].Rows[0]["dia"].ToString();
            }

            decimal montoDia = decimal.Parse(upDawnMonto.Text);
            this.reacargoMoratorio = (semanaDia * montoDia);
            txtMoraTotal.Text = "$" + reacargoMoratorio.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            frmCobros cobros = new frmCobros();

            mora.EjecutarMoratoria(reacargoMoratorio);
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtMoraTotal.Text = (int.Parse(txtDiaAdeu.Text)* upDawnMonto.Value).ToString();
        }
    }
}
