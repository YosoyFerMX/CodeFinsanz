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
    public partial class frmReporteMoratorio : Form
    {
        public int folioPrestamo;
        public frmReporteMoratorio(int folio)
        {
            InitializeComponent();
            this.folioPrestamo = folio;
        }

        private void frmReporteMoratorio_Load(object sender, EventArgs e)
        {

            if (InformesQuery.InformeDetalleMoras(folioPrestamo) != null)
            {
                DataSets.DataSetDetallesPrestamo dsv = new DataSets.DataSetDetallesPrestamo();
                Conexion.sqlDA.Fill(dsv, "tbMoraDetalles");
                rvMoratorios.ProcessingMode = ProcessingMode.Local;
                rvMoratorios.LocalReport.DataSources.Clear();
                rvMoratorios.LocalReport.DataSources.Add(new ReportDataSource("DataSetDetalleMoras", dsv.Tables["tbMoraDetalles"]));
                rvMoratorios.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportMoratorias.rdlc";

                rvMoratorios.SetDisplayMode(DisplayMode.PrintLayout);
                this.rvMoratorios.RefreshReport();

            }
            else
            {
                MessageBox.Show("AUN NO EXISTEN REGISTROS");
                this.Close();
            }

        }
    }
}
