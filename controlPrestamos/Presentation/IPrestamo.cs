using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlPrestamos.Presentation
{
    public interface IPrestamo
    {
        void EjecutarPrestamos(int folio, int claveCliente, string nombre, string apellido1, string apellido2, string telefono, DateTime fecha, decimal montoPagar, decimal restante, decimal interes, string modalidad);
    }
}
