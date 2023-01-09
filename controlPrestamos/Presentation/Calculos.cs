using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlPrestamos.Presentation
{
    class Calculos
    {
        public static decimal calculo_Monto(decimal monto, decimal porcentaje) {
            decimal montoTotal;
            montoTotal = (monto * porcentaje) / 100;

            return montoTotal + monto;
        }
    }
}
