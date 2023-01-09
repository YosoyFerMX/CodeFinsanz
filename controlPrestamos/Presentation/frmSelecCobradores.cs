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
    public partial class frmSelecCobradores : Form
    {
        public ICobradores cob { get; set; }
        public frmSelecCobradores()
        {
            InitializeComponent();
        }
        private void selectIndex()
        {
            var filaSel = dgvSelecCobrador.CurrentRow;
            if (filaSel != null)
            {
                cob.Ejecutar_Cobradores((int)filaSel.Cells[0].Value, (string)filaSel.Cells[1].Value);
                this.Close();
                CrudCobradores.Cobradores().Tables[0].Clear();


            }
            else { MessageBox.Show("Seleccione alguna fila"); }
        }
        private void frmSelecCobradores_Load(object sender, EventArgs e)
        {
            if (CrudCobradores.Cobradores() != null)
            {
                dgvSelecCobrador.DataSource = CrudCobradores.Cobradores().Tables[0].DefaultView;
                dgvSelecCobrador.Columns[7].Visible = false;
            }
            else { MessageBox.Show("AUN NO EXISTEN REGISTROS"); }
           
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSelecCobrador_DoubleClick(object sender, EventArgs e)
        {
            selectIndex();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvSelecCobrador.DataSource;
            bs.Filter = "Nombre like '%" + txtSearchName.Text + "%'";
            dgvSelecCobrador.DataSource = bs;
        }
    }
}
