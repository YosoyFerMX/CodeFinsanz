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
using controlPrestamos.Date;
using Microsoft.Reporting.WinForms;

namespace controlPrestamos.Presentation
{
    public partial class frmGananciaMoras : Form
    {
        public frmGananciaMoras()
        {
            InitializeComponent();
        }

        private void frmGananciaMoras_Load(object sender, EventArgs e)
        {
            EjecutarReporViewer(DateTime.Now);
            
        }

        private void EjecutarReporViewer(DateTime fechaFil) {
            if (InformesQuery.GananciasMoras(fechaFil) != null)
            {
                DataSets.DataSetDetallesPrestamo dsv = new DataSets.DataSetDetallesPrestamo();
                Conexion.sqlDA.Fill(dsv, "tbMorasGanancias");
                rVGananciasMoras.ProcessingMode = ProcessingMode.Local;
                rVGananciasMoras.LocalReport.DataSources.Clear();
                rVGananciasMoras.LocalReport.DataSources.Add(new ReportDataSource("DataSetGananciasMoras", dsv.Tables["tbMorasGanancias"]));
                rVGananciasMoras.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportGananciasMoratoria.rdlc";

                rVGananciasMoras.SetDisplayMode(DisplayMode.PrintLayout);
                this.rVGananciasMoras.RefreshReport();
            }
            else
            {
                MessageBox.Show("SIN MOVIENTOS");

            }


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaFiltrar = dtmFiltrarInf.Value;
            EjecutarReporViewer(fechaFiltrar);
        }
    }
}
