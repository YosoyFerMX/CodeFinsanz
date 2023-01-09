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
    public partial class frmCuotasVencidas : Form
    {
        public frmCuotasVencidas()
        {
            InitializeComponent();
        }

        private void frmCuotasVencidas_Load(object sender, EventArgs e)
        {
            if (InformesQuery.InformeCuotasVencidas() != null)
            {
                DataSets.DataSetCliCob dsv = new DataSets.DataSetCliCob();
                Conexion.sqlDA.Fill(dsv, "tbCuotasVencidas");
                repViewCuotVenci.ProcessingMode = ProcessingMode.Local;
                repViewCuotVenci.LocalReport.DataSources.Clear();
                repViewCuotVenci.LocalReport.DataSources.Add(new ReportDataSource("DataSetCuotasVencidas", dsv.Tables["tbCuotasVencidas"]));
                repViewCuotVenci.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportCuotasVencidas.rdlc";
                //reportViewer1.Width = 600;
                //reportViewer1.Height = 400;

                this.repViewCuotVenci.RefreshReport();
                repViewCuotVenci.SetDisplayMode(DisplayMode.PrintLayout);
            }
            else
            {
                MessageBox.Show("AUN NO EXISTEN REGISTROS");
            }
        }
    }
}
