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
    public partial class frmReportCobradores : Form
    {
        public frmReportCobradores()
        {
            InitializeComponent();
        }

        private void frmReportCobradores_Load(object sender, EventArgs e)
        {

            if (InformesQuery.InformeCobradores() != null)
            {
                DataSets.DataSetCliCob dsv = new DataSets.DataSetCliCob();
                Conexion.sqlDA.Fill(dsv, "tbCobradores");
                repViewCobradores.ProcessingMode = ProcessingMode.Local;
                repViewCobradores.LocalReport.DataSources.Clear();
                repViewCobradores.LocalReport.DataSources.Add(new ReportDataSource("DataSetCobradores", dsv.Tables["tbCobradores"]));
                repViewCobradores.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportCobradores.rdlc";
                //reportViewer1.Width = 600;
                //reportViewer1.Height = 400;

                this.repViewCobradores.RefreshReport();
                repViewCobradores.SetDisplayMode(DisplayMode.PrintLayout);
            }
            else {
                MessageBox.Show("AUN NO EXISTEN REGISTROS");
            }
            
        }
    }
}
