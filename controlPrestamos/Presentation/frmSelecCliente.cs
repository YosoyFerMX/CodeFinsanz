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
    public partial class frmSelecCliente : Form
    {
        public IClientes cli { get; set; }
        public frmSelecCliente()
        {
            InitializeComponent();
        }

        private void frmSelecCliente_Load(object sender, EventArgs e)
        {
            if (CrudClientes.Clientes() != null)
            {
                dgvSelecClient.DataSource = CrudClientes.Clientes().Tables[0];
                dgvSelecClient.Columns[10].Visible = false;
            }
            else { MessageBox.Show("NO EXISTEN CLIENTES PARA MOSTRAR"); }
            
        }

        private void dgvSelecClient_DoubleClick(object sender, EventArgs e)
        {
            var filaSel = dgvSelecClient.CurrentRow;
            if (filaSel != null)
            {
                cli.EjecutarClientes((int)filaSel.Cells[0].Value, (string)filaSel.Cells[1].Value, (string)filaSel.Cells[2].Value, (string)filaSel.Cells[3].Value, (string)filaSel.Cells[5].Value, (string)filaSel.Cells[7].Value, (string)filaSel.Cells[8].Value, (string)filaSel.Cells[9].Value);
                this.Close();
                CrudClientes.Clientes().Tables[0].Clear();


            }
            else { MessageBox.Show("Seleccione alguna fila"); }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvSelecClient.DataSource;
            bs.Filter = "Nombre like '%" + txtSearchName.Text + "%'";
            dgvSelecClient.DataSource = bs;
        }

    }
}
