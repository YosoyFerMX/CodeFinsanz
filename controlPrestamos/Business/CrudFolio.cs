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
    class CrudFolio
    {
        public static DataSet Folio()
        {
            var query = Conexion.transacBD("select * from tbFolio", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        public static int Insertar_NvoFolio(int idUser, int idCliente, decimal montoPres, decimal restantePres, string modPres, int cuotasPres, decimal interesPres, string tipoDiario, string fechaPres, string ObservacionesPres)
        {
            var query = Conexion.transacBD("INSERT INTO tbFolioPrestamos VALUES ('" + idUser + "','" + idCliente + "','" + montoPres + "','" + restantePres + "', '" + modPres + "','" + cuotasPres + "','" + interesPres + "','" + tipoDiario + "','" + fechaPres + "','" + ObservacionesPres + "', 'PENDIENTE')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        public static int Insertar_DetalleFolioPres(int folio, int numCuota, string fechaCuota, decimal montoCuota, string estado)
        {
            var query = Conexion.transacBD("INSERT INTO tbControlPrestamo VALUES ('" + folio + "','" + numCuota + "','" + fechaCuota + "','" + montoCuota + "','" + estado + "', null   )", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }
        // QUERY QUE TRAE UN INNER JOIN CON LAS TABLAS DE CLIENTES Y PRESTAMOS
        public static DataSet querySelecPrestamo(string estadoPrestamo)
        {
            var query = Conexion.transacBD("select folioPrestamo AS FOLIO, idCliente AS 'CLAVE CLIENTE',nombreCli AS NOMBRE, apellido1Cli AS 'PRIMER APELLIDO', apellido2Cli AS ' SEGUNDO APELLIDO',telCli AS TELEFONO, montoPres AS 'MONTO DEL PRESTAMO',restantePres AS RESTANTE,interesPres AS INTERESES, fechaPres AS FECHA,modalidadPago as MODALIDAD from tbFolioPrestamos INNER JOIN tbClientes ON tbFolioPrestamos.idCliente = tbClientes.id where estadoPres != '" + estadoPrestamo + "'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //QUERY PARA TRAER LOS DETALLES DE UN FOLIO DETERMINADO
        public static DataSet queryDetallePres(int folioPres)
        {
            var query = Conexion.transacBD("select folioPrestamo AS FOLIO, numCuota AS CUOTA, fechaCuota AS FECHA, montoCuota AS MONTO, estado AS ESTADO from tbcontrolPrestamo where folioPrestamo = '" + folioPres + "'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //QUERY PARA GUARDAE LAS CUOTAS EN LA TABLA CONTROLPRESTAMOS
        public static int AbonoPres(int folio, int numCuota, string fechaCuota, decimal montoCuota, string estado)
        {
            var query = Conexion.transacBD("INSERT INTO tbControlPrestamo VALUES ('" + folio + "','" + numCuota + "','" + fechaCuota + "','" + montoCuota + "','" + estado + "')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;
        }

        //QUERY PARA REALIZAR ABONOS A LAS CUOTAS
        public static int AbonoCuota(int folioPres, int numCuota, decimal montoCuota, string estado)
        {
            var query = Conexion.transacBD("UPDATE tbcontrolPrestamo SET estado = '" + estado + "',montoCuota = '" + montoCuota + "', fechaAbono = '" + DateTime.Now.ToString("MM-dd-yyyy") + "'  WHERE folioPrestamo = '" + folioPres + "' and numCuota = '" + numCuota + "';", false); ;
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;


        }

        //PARA REALIZAR LA ACTUALIZACION DEL ESTADO DEL FOLIO PRINCIPAL
        public static int LiquidacionCuotas(int folioPres)
        {
            var query = Conexion.transacBD("UPDATE tbFolioPrestamos SET estadoPres = 'LIQUIDADO' WHERE folioPrestamo = '" + folioPres + "';", false); ;
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;
        }

        //------------------------------ M O R A S ---------------------------------------------------------------
        // PARA TRAER DE LA TABLA CONTROLPESTAMOS LAS MORAS Y DIFERENCIA DE DIAS DE CADA CLIENTE ATRAZADO
        public static DataSet queryMoraPres(int folioPres)
        {
            var query = Conexion.transacBD("select folioPrestamo as FOLIO, cuota as CUOTA, fechaCuota as FECHA, modalidad as MODALIDAD, diaMesMoratoria AS 'DIAS ATRASADOS', cantMoratoria as MORATORIA, estadoMora AS ESTADO  from tbMoras where folioPrestamo = '" + folioPres + "'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        // PARA TRAER DE LA TABLA CONTROLPESTAMOS LAS MORAS Y DIFERENCIA DE SEMANAS DE CADA CLIENTE ATRAZADO
        public static DataSet queryMoraPresSemanas(int folioPres)
        {
            var query = Conexion.transacBD("select folioPrestamo as FOLIO, cuota as CUOTA, fechaCuota as FECHA, modalidad as MODALIDAD, diaMesMoratoria AS 'SEMANAS ATRASADAS', cantMoratoria as MORATORIA, estadoMora AS ESTADO from tbMoras where folioPrestamo = '" + folioPres + "'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        // PARA TRAER DE LA TABLA CONTROLPESTAMOS LAS MORAS Y DIFERENCIA DE MESES DE CADA CLIENTE ATRAZADO
        public static DataSet queryMoraPresMes(int folioPres)
        {
            var query = Conexion.transacBD("select folioPrestamo as FOLIO, numCuota as CUOTA, fechaCuota as FECHA, DATEDIFF(MONTH, fechaCuota, GETDATE()) AS 'MESES DE ADEUDO' from tbcontrolPrestamo where estado = 'PENDIENTE' and fechaCuota < GETDATE() AND folioPrestamo = '" + folioPres + "'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        // PARA INSERTAR LAS MORAS CONGELADAS EN LA TABLA DE MORAS
        public static int InsertMora(int folio, int numCuota, DateTime fechaCuota, string modalidad, int diasMesMoratoria, decimal cantMoratoria)
        {
            var query = Conexion.transacBD("INSERT INTO tbMoras VALUES ('" + folio + "','" + numCuota + "','" + fechaCuota.ToString("MM-dd-yyyy") + "','" + modalidad + "','" + diasMesMoratoria + "', '" + cantMoratoria + "', null,'SIN LIQUIDAR')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;
        }


        // PARA ACTUALIZAR LA TABLA DE MORAS AL PAGAR EL RECARGO DEL CLIENTE

        public static int AbonarMoratoria(int folio, int cuota)
        {
            var query = Conexion.transacBD("UPDATE tbMoras SET fechaPagoMoratoria = '" + DateTime.Now.ToString("MM-dd-yyyy") + "', estadoMora = 'LIQUIDADO' where folioPrestamo = '" + folio + "' and cuota = '" + cuota + "'", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;
        }


        //PARA SABER SI EXISTEN MORAS PENDIENTES EN LA RENOVACION DE UN NUEVO PRESTAMO AL MISMO CLIENTE
        public static DataSet queryMorasPendientesRenovacion(int idCliente)
        {
            var query = Conexion.transacBD("select COUNT(tbMoras.folioPrestamo) AS ConteoMoras from tbMoras INNER JOIN tbFolioPrestamos ON tbMoras.folioPrestamo = tbFolioPrestamos.folioPrestamo INNER JOIN tbClientes ON tbFolioPrestamos.idCliente = tbClientes.id where  estadoMora = 'SIN LIQUIDAR' AND tbClientes.id = '" + idCliente + "'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }



        //PARA CORROBORAR DE PENDIENTES CON MORATORIA

        public static DataSet queryPendientesRenovacion(int idCliente)
        {
            var query = Conexion.transacBD("select COUNT(tbcontrolPrestamo.folioPrestamo) AS ConteoMoras from tbcontrolPrestamo INNER JOIN tbFolioPrestamos ON tbcontrolPrestamo.folioPrestamo = tbFolioPrestamos.folioPrestamo INNER JOIN tbClientes ON tbFolioPrestamos.idCliente = tbClientes.id where  estado = 'PENDIENTE'  AND fechaCuota < GETDATE() AND tbClientes.id = '" + idCliente + "'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //PARA CORROBORAR LAS CUOTAS RESTANTES DE UN PRESTAMO

        public static DataSet queryCountCoutRest(int idCliente)
        {
            var query = Conexion.transacBD("select COUNT (numCuota) as sumPagosPendientes, modalidadPago from tbcontrolPrestamo " +
                "INNER JOIN tbFolioPrestamos ON tbcontrolPrestamo.folioPrestamo = tbFolioPrestamos.folioPrestamo " +
                "INNER JOIN tbClientes ON tbFolioPrestamos.idCliente = tbClientes.id " +
                "where  estado = 'PENDIENTE'  AND tbClientes.id = '" + idCliente + "' " +
                "and tbFolioPrestamos.folioPrestamo = (select top 1 folioPrestamo from tbFolioPrestamos where idCliente = '" + idCliente + "' order by tbFolioPrestamos.folioPrestamo desc) " +
                "group by modalidadPago", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }
        //---------------------------------- END MORAS ---------------------------------------------------------



        // -------------------------------- PARA ELIMINAR REGISTROS DE PRESTAMOS Y DEMAS TABLAS ------------------
        public static int EliminarPrestamos()
        {
            var query = Conexion.transacBD("delete from tbFolioPrestamos", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        // -------------------------------- PARA ELIMINAR REGISTROS DE LA TABLA CONTROLPRESTAMOS ------------------
        public static int EliminarDetallesPres()
        {
            var query = Conexion.transacBD("delete from tbcontrolPrestamo", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        // -------------------------------- PARA ELIMINAR REGISTROS DE LA TABLA MORAS ------------------
        public static int EliminarMoras()
        {
            var query = Conexion.transacBD("delete from tbMoras", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }


        // ---------------------------------- PARA ELIMINAR UN PRESTAMO ---------------
        public static int DeletePrest (int folioPres)
        {
            var query = Conexion.transacBD("DELETE FROM tbFolioPrestamos WHERE folioPrestamo = '" + folioPres + "';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

    }

}
