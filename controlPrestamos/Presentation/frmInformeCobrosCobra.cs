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
    public partial class frmInformeCobrosCobra : Form
    {
        public frmInformeCobrosCobra()
        {
            InitializeComponent();
        }

        private void EjecutarVeporViewer(DateTime fechaFil) {
            if (InformesQuery.InformeMontoCobra(fechaFil) != null)
            {
                DataSets.DataSetDetallesPrestamo dsv = new DataSets.DataSetDetallesPrestamo();
                Conexion.sqlDA.Fill(dsv, "tbInfMontosCobra");
                repViewInfMontosCob.ProcessingMode = ProcessingMode.Local;
                repViewInfMontosCob.LocalReport.DataSources.Clear();
                repViewInfMontosCob.LocalReport.DataSources.Add(new ReportDataSource("DataSetInfMontoCobra", dsv.Tables["tbInfMontosCobra"]));
                repViewInfMontosCob.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportInformesCobrosCobrador.rdlc";

                repViewInfMontosCob.SetDisplayMode(DisplayMode.PrintLayout);
                this.repViewInfMontosCob.RefreshReport();
            }
            else
            {
                MessageBox.Show("SIN MOVIENTOS");

            }

        }

        private void frmInformeCobrosCobra_Load(object sender, EventArgs e)
        {
            EjecutarVeporViewer(DateTime.Now);   
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaFiltrar = dtmFiltrarInf.Value;
            EjecutarVeporViewer(fechaFiltrar);
        }
    }
}
