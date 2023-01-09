using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using controlPrestamos.Date;
using System.Data;

namespace controlPrestamos.Business
{
    class MorasQuery
    {
        // QUERY QUE ME TRAE LOS REGISTROS DE MORATORIASCTRL
        public static DataSet CtrolMoratorias()
        {
            var query = Conexion.transacBD("select * from tbMoratoriasCtrl", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }


        //PARA REALIZAR LA ACTUALIZACION DE LA PENALIZACION DE LAS MORATORIAS
        public static int UpdateMoratoriasCtrl(decimal montoMorDia,decimal montoMoratoriaSem)
        {
            var query = Conexion.transacBD("update tbMoratoriasCtrl SET dia = '"+montoMorDia+"', semanal = '"+ montoMoratoriaSem + "'", false); ;
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;
        }
    }
}
