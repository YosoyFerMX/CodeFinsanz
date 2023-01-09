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
    class CrudUsuarios
    {
        public static DataSet Usuarios()
        {
            var query = Conexion.transacBD("select idUser AS CLAVE, nombreU AS NOMBRE, apellidosU AS APELLIDOS, privilegiosU AS PRIVILEGIO, contraseñaU AS CONTRASEÑA from tbUsers where idUser != 1", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }



        public static int Insertar_USuario(string nombre, string apellidos, string contraseña, string privilegio)
        {
            var query = Conexion.transacBD("INSERT INTO tbUsers VALUES ('"+nombre+"','"+apellidos+"','"+privilegio+"','"+contraseña+"')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        public static int EliminarUsuario(int id)
        {
            var query = Conexion.transacBD("delete from tbUsers where idUser = '" + id + "';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        public static int Editar_Usuario(string nonmbre,string apellidos, string privilegio, string password,int idUsuario)
        {
            var query = Conexion.transacBD("UPDATE tbUsers SET nombreU = '" +nonmbre+ "', apellidosU = '" + apellidos + "', privilegiosU = '" + privilegio + "',contraseñaU = '" + password + "' WHERE idUser = '"+idUsuario+"'", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        //PARA VALIDAR EL USUARIO A INGRESAR AL SISTEMA
        public static DataSet UsuariosLog(string usuario, string contraseña)
        {
            var query = Conexion.transacBD("select nombreU, privilegiosU  from tbUsers where nombreU COLLATE Latin1_General_CS_AS  = '"+usuario+"' AND contraseñaU COLLATE Latin1_General_CS_AS = '"+contraseña+"'", true);
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
