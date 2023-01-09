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
    class CrudClientes
    {
        public static DataSet Clientes()
        {
            var query = Conexion.transacBD("select tbClientes.id AS CLAVE, nombreCli AS NOMBRE, apellido1Cli AS 'PRIMER APELLIDO', apellido2Cli AS 'SEGUNDO APELLIDO', generoCli AS GENERO, municipioCli AS MUNICIPIO,estadoCli AS ESTADO,telCli AS TELEFONO , tbClientes.domicilioCli AS DIRECCION, nombreCob AS COBRADOR, idCobrador from tbClientes INNER JOIN tbCobrador ON tbClientes.idCobrador = tbCobrador.id", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        public static int Insertar_Clientes(int user, int idCobrador, string nombre, string primerApe, string segundoApe, string genero, string telCli, string domicilioCli, string municipioCli, string estadoCli, byte[] foto)
        {
            var query = Conexion.transacBD("INSERT INTO tbClientes VALUES ('" +user+ "','" + idCobrador + "','" +nombre+ "','" +primerApe+ "','" +segundoApe+ "','" +genero+ "','" +telCli+ "','" +domicilioCli+ "','"+municipioCli+"','"+estadoCli+"','"+foto+"');", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        public static int Editar_Clientes(int user, int idCobrador, string nombre, string primerApe, string segundoApe, string genero, string telCli, string domicilioCli, string municipioCli, string estadoCli, byte[] foto, int idCliente)
        {
            var query = Conexion.transacBD("UPDATE tbClientes SET idUser = '" + user + "', idCobrador = '" + idCobrador + "', nombreCli = '" + nombre + "',apellido1Cli = '" + primerApe + "',apellido2Cli = '" + segundoApe + "',generoCli = '" + genero + "',telCli = '" + telCli + "',domicilioCli = '" + domicilioCli + "',municipioCli = '" + municipioCli + "',estadoCli = '" + estadoCli + "',fotoCli ='" + foto + "' WHERE id = '" + idCliente + "'", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        public static int EliminaCliente(int id)
        {
            var query = Conexion.transacBD("delete from tbClientes where id = '" + id + "';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }
        //PARA INFORME CLI COBRADOR
        public static DataSet InformeClientesCobra()
        {
            var query = Conexion.transacBD("select nombreCli, apellido1Cli, apellido2Cli, telCli, domicilioCli, municipioCli, nombreCob, apellido1Cob, apellido2Cob " +
                "from tbClientes INNER JOIN tbCobrador " +
                "ON tbClientes.idCobrador = tbCobrador.id order by tbCobrador.id desc", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }


        //PARA FILTRAR CLIENTES POR SU MUNICIPIO
        public static DataSet InformeClientesMunicipio(string municipio)
        {
            var query = Conexion.transacBD("select nombreCli, apellido1Cli, apellido2Cli, telCli, domicilioCli, municipioCli, nombreCob, apellido1Cob, apellido2Cob from tbClientes INNER JOIN tbCobrador ON tbClientes.idCobrador = tbCobrador.id where municipioCli = '"+municipio+"' order by tbCobrador.id desc", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }


        //PARA INFORMe DE LA CANTIDAD DE PRESTAMOS POR CLIENTE
        public static DataSet InformeClientesCantPres()
        {
            var query = Conexion.transacBD("select tbClientes.id,nombreCli,apellido1Cli,apellido2Cli, COUNT(tbFolioPrestamos.folioPrestamo) AS PRESTAMOS from tbClientes INNER JOIN tbFolioPrestamos " +
                "ON tbFolioPrestamos.idCliente = tbClientes.id " +
                "group by tbClientes.id, nombreCli, apellido1Cli, apellido2Cli order by PRESTAMOS desc", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //---------------------- ELIMINAR CLIENTES---------------------------
        public static int EliminarTodosCli()
        {
            var query = Conexion.transacBD("delete from tbClientes", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }
    }
}
