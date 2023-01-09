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
    public partial class frmGanancias : Form
    {
        public frmGanancias()
        {
            InitializeComponent();
        }

        private void frmGanancias_Load(object sender, EventArgs e)
        {

        }

        private void EjecutarQuery() {

            


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;


            if (InformesQuery.InformeGanancias(fechaDesde, fechaHasta) != null)
            {
                DataSets.DataSetCliCob dsv = new DataSets.DataSetCliCob();
                Conexion.sqlDA.Fill(dsv, "tnGananciasCuotas");
                repViewGanancias.ProcessingMode = ProcessingMode.Local;
                repViewGanancias.LocalReport.DataSources.Clear();
                repViewGanancias.LocalReport.DataSources.Add(new ReportDataSource("DataSetGanancias", dsv.Tables["tnGananciasCuotas"]));
                repViewGanancias.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportGanancias.rdlc";
                //reportViewer1.Width = 600;
                //reportViewer1.Height = 400;

                this.repViewGanancias.RefreshReport();
                repViewGanancias.SetDisplayMode(DisplayMode.PrintLayout);
            }
            else
            {
                MessageBox.Show("AUN NO EXISTEN REGISTROS");
            }

        }
    }
}
