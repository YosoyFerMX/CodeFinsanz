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

namespace controlPrestamos.Presentation
{
    public partial class frmAjustes : Form
    {
        public frmAjustes()
        {

            InitializeComponent();
        }

        private void resp_Enter(object sender, EventArgs e)
        {

        }

        private void btnGenCop_Click(object sender, EventArgs e)
        {
            string nombreCopia = (DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-" + "ControlPrestamos");
            string comandoConsul = "BACKUP DATABASE [dbControlClientes] TO  DISK = N'C:\\backUp\\"+nombreCopia+"' WITH NOFORMAT, NOINIT,  NAME = N'dbControlClientes-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            //InformesQuery.Respaldo(comandoConsul);

            Conexion.backUpBD(comandoConsul);
        }

        private void frmAjustes_Load(object sender, EventArgs e)
        {
            this.nUpDawnMorDia.Value = (decimal)MorasQuery.CtrolMoratorias().Tables[0].Rows[0]["dia"];
            this.numericUpDownMorSem.Value = (decimal)MorasQuery.CtrolMoratorias().Tables[0].Rows[0]["semanal"];
        }

        private void btnBorrarPrestamos_Click(object sender, EventArgs e)
        {
            if (GlobalUser.provilegioUsuario == "SUPERADMINISTRADOR")
            {

                DialogResult result = MessageBox.Show("¿CONFIRME PARA ELIMINAR REGISTROS?", "SALIR", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    CrudFolio.EliminarPrestamos();
                    CrudFolio.EliminarDetallesPres();
                    CrudFolio.EliminarMoras();

                }

            }
            else {
                MessageBox.Show("NO TIENES LOS PRIVILEGIOS PARA REALIZAR ESTA ACCIÓN");
            }

        }

        private void btnBorrarClientes_Click(object sender, EventArgs e)
        {
            if (GlobalUser.provilegioUsuario == "SUPERADMINISTRADOR") {

                DialogResult result = MessageBox.Show("¿CONFIRME PARA ELIMINAR REGISTROS?", "SALIR", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    CrudClientes.EliminarTodosCli();
                }

            }
            else
            {
                MessageBox.Show("NO TIENES LOS PRIVILEGIOS PARA REALIZAR ESTA ACCIÓN");
            }

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
                try
                {
                    MorasQuery.UpdateMoratoriasCtrl(this.nUpDawnMorDia.Value, this.numericUpDownMorSem.Value);
                    MessageBox.Show("¡¡ HECHO !!");
                }
                catch(Exception n) { MessageBox.Show("ERROR AL ACTUALIZAR EL MONTO " + n); }
                
        }
    }
}
