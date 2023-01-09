using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlPrestamos.Presentation
{
    class validaciones
    {
        public static void SoloNumeros(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            else if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
