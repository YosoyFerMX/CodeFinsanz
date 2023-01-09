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
    public partial class frmPrestamosGanancias : Form
    {
        public frmPrestamosGanancias()
        {
            InitializeComponent();
        }

        private void frmPrestamosGanancias_Load(object sender, EventArgs e)
        {
            rbTodos.Checked = true;
            this.repViewPrestamosGanan.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string estadoPrestamo = "";
            if (rbTodos.Checked == true) {
               
            }
            else if (rdLiquidados.Checked == true) {
                estadoPrestamo = "PENDIENTE";
            }
            else if (rbPendientes.Checked == true) {
                estadoPrestamo = "LIQUIDADO";
            }
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;
            


            if (InformesQuery.InformePrestamosGanancias(fechaDesde, fechaHasta, estadoPrestamo) != null)
            {
                DataSets.DataSetCliCob dsv = new DataSets.DataSetCliCob();
                Conexion.sqlDA.Fill(dsv, "tbPrestamosGanancias");
                repViewPrestamosGanan.ProcessingMode = ProcessingMode.Local;
                repViewPrestamosGanan.LocalReport.DataSources.Clear();
                repViewPrestamosGanan.LocalReport.DataSources.Add(new ReportDataSource("DataSetPrestamoGanancia", dsv.Tables["tbPrestamosGanancias"]));
                repViewPrestamosGanan.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportPrestamosGanancias.rdlc";
                //reportViewer1.Width = 600;
                //reportViewer1.Height = 400;

                this.repViewPrestamosGanan.RefreshReport();
                repViewPrestamosGanan.SetDisplayMode(DisplayMode.PrintLayout);
            }
            else
            {
                MessageBox.Show("AUN NO EXISTEN REGISTROS");
            }
        }
    }
}
