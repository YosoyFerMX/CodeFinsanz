using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlPrestamos.Presentation
{
    public interface IClientes
    {
        void EjecutarClientes(int id, string nombre, string apellido1, string apellido2, string telefono,string municipio, string direccion, string cobAsignado );
    }
}
