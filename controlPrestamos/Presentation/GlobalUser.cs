using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using controlPrestamos.Presentation;

namespace controlPrestamos.Presentation
{
    public class GlobalUser
    {
        public static string nombreUsuario;
        public static string provilegioUsuario;


        public GlobalUser(string nombreU, string priv){
            nombreUsuario = nombreU;
            provilegioUsuario = priv;
        }

    }
}
