using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlPrestamos.Presentation
{
    public interface ICobradores
    {
        void Ejecutar_Cobradores(int id, string nombre);
    }
}
