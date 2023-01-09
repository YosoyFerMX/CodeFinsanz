using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using controlPrestamos.Date;

namespace controlPrestamos.Business
{
    class CrudCobradores
    {
        public static DataSet Cobradores()
        {
            var query = Conexion.transacBD("select id AS CLAVE, nombreCob AS NOMBRE, apellido1Cob AS 'PRIMER APELLIDO', apellido2Cob AS 'SEGUNDO APELLIDO', MunicipioCob AS MUNICIPIO, zonaCob AS ZONA, telefonoCob AS TELÉFONO, fotoCobra AS IMAGEN from tbCobrador", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }


        //INSERT
        public static int Insertar_Cobradores(int user, string nombre, string primerApe,string segundoApe, string municipio, string zona,string telefono, byte[] foto)
        {
            var query = Conexion.transacBD("INSERT INTO tbCobrador VALUES ('"+user+"','"+nombre+"','"+primerApe+"','"+segundoApe+"','"+municipio+"','"+zona+"','"+telefono+"','"+foto+"')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;

            
            return Conexion.conf;

        }


        //ACTUALIZAR
        public static int editar_Cobrador(int user, string nombre, string primerApe, string segundoApe, string municipio, string zona, string telefono, byte[] foto, int idWhere)
        {
            var query = Conexion.transacBD("UPDATE tbCobrador SET idUSer = '"+user+"', nombreCob = '"+nombre+"',apellido1Cob = '"+primerApe+"',apellido2Cob = '"+segundoApe+"',MunicipioCob = '"+municipio+"',zonaCob = '"+zona+"',telefonoCob = '"+telefono+"',fotoCobra = '"+foto+"' WHERE id = '"+idWhere+"'", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }


        //ELIMINAR
        public static int DeleteCobrador(int id)
        {
            var query = Conexion.transacBD("delete from tbCobrador where id = '" + id + "';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }


        //PARA CONSULTAR LA FOTO DEL COBRADOR
        public static DataSet Foto_Cobrado(int id)
        {
            var query = Conexion.transacBD("select * from tbCobrador where id = '"+id+"'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }
    }
}
