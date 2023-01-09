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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using controlPrestamos.Date;

namespace controlPrestamos.Presentation
{
    public partial class frmReporteClientes : Form
    {
        public frmReporteClientes()
        {
            InitializeComponent();
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-BOHPIVK\\YSYFERMX;Initial Catalog=dbControlClientes;Integrated Security=true");
            //string sql = "select nombreCli, apellido1Cli, apellido2Cli, telCli, domicilioCli, municipioCli, nombreCob, apellido1Cob, apellido2Cob " +
            //    "from tbClientes INNER JOIN tbCobrador " +
            //    "ON tbClientes.idCobrador = tbCobrador.id order by tbCobrador.id desc";
            //SqlDataAdapter dapv = new SqlDataAdapter(sql,con);
            CrudClientes.InformeClientesCobra();
            DataSets.DataSetCliCob dsv = new DataSets.DataSetCliCob();
            Conexion.sqlDA.Fill(dsv, "tbCliCob");
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetCientesCobradores", dsv.Tables["tbCliCob"]));
            reportViewer1.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportCliCob.rdlc";
            //reportViewer1.Width = 600;
            //reportViewer1.Height = 400;

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            //
            rbTodos.Checked = true;
            txtMpioCli.Enabled = false;
        }

        private void btnCountPres_Click(object sender, EventArgs e)
        {
            CrudClientes.InformeClientesCantPres();
            DataSets.DataSetCliCob dsv = new DataSets.DataSetCliCob();
            Conexion.sqlDA.Fill(dsv, "tbCountPresPorCli");
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dsv.Tables["tbCountPresPorCli"]));
            reportViewer1.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.Report1.rdlc";
            //reportViewer1.Width = 600;
            //reportViewer1.Height = 400;

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

        }

        private void btnReportCli_Click(object sender, EventArgs e)
        {
            
        }

        private void rbMunicipio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMunicipio.Checked == true)
            {
                txtMpioCli.Enabled = true;
            }
            else
            {
                txtMpioCli.Enabled = false;
            }
        }

        private void reportview() {
            DataSets.DataSetCliCob dsv = new DataSets.DataSetCliCob();
            Conexion.sqlDA.Fill(dsv, "tbCliCob");
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetCientesCobradores", dsv.Tables["tbCliCob"]));
            reportViewer1.LocalReport.ReportEmbeddedResource = "controlPrestamos.Informes.ReportCliCob.rdlc";

            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true) {
                if (CrudClientes.InformeClientesCobra() != null)
                {
                    reportview();
                }
                else {MessageBox.Show("NO EXISTEN REGISTROS"); }
               
                
            } else if (rbMunicipio.Checked == true) {
                if (txtMpioCli.Text != "")
                {
                    if (CrudClientes.InformeClientesMunicipio(txtMpioCli.Text) != null) {
                        reportview();
                    }
                    else { MessageBox.Show("NO EXISTEN REGISTROS"); }


                }
                else { MessageBox.Show("SELECCIONE UN MUNICIPIO"); }
            } 
        }
    }
}
