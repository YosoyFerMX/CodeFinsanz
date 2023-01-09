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
    public partial class frmReportePrestamoDetalles : Form
    {
        public int folioPrestamo;

        public frmReportePrestamoDetalles(int follio)
        {
            InitializeComponent();
            this.folioPrestamo = follio;
        }

        private void frmReportePrestamoDetalles_Load(object sender, EventArgs e)
        {
            if (InformesQuery.InformeDetallePrestamo(folioPrestamo) != null)
            {
                DataSets.DataSetDetallesPrestamo dsv = new DataSets.DataSetDetallesPrestamo();
                Conexion.sqlDA.Fill(dsv, "tbDetallePres");
                repViewDetallesPres.ProcessingMode = ProcessingMode.Local;
                repViewDetallesPres.LocalReport.DataSources.Clear();
                repViewDetallesPres.LocalReport.DataSources.Add(new ReportDataSource("DataSetDetallesPrestamo", dsv.Tables["tbDetallePres"]));
                repViewDetallesPres.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportDetallePrest.rdlc";

                repViewDetallesPres.SetDisplayMode(DisplayMode.PrintLayout);
                this.repViewDetallesPres.RefreshReport();

            }
            else {
                MessageBox.Show("AUN NO EXISTEN REGISTROS");
                this.Close();
            }
            
            
            
        }
    }
}
