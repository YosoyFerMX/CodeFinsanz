using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using controlPrestamos.Date;
using System.Data;

namespace controlPrestamos.Business
{
    class InformesQuery
    {
        //--------------------------------------------------------------------PARA SABER LOS DETALES DE LAS CUOTAS DLE PRESTAMO-----------------------------------------------------------------
        public static DataSet InformeDetallePrestamo(int folio)//CAST((montoPres - (((montoPres)*(interesPres))/(100 + interesPres))) as decimal (36,2)) AS prestamo
        {
            var query = Conexion.transacBD("Select tbFolioPrestamos.folioPrestamo As Folio, montoPres, restantePres, modalidadPago, CuotasPres, interesPres, fechaPres, observacionPres, nombreCli, apellido1Cli, apellido2Cli, telCli, domicilioCli, municipioCli, " +
                "numCuota, fechaCuota, montoCuota, estado, nombreCob, apellido1Cob, apellido2Cob,CAST((select montoPres - (((montoPres)*(interesPres))/(100 + interesPres)) AS 'CANTIDAD PRESTADA' from tbFolioPrestamos where folioPrestamo = '"+folio+ "') as decimal (36,2)) AS prestamoNeto, estadoPres from tbFolioPrestamos INNER JOIN tbClientes ON tbClientes.id = tbFolioPrestamos.idCliente INNER JOIN tbcontrolPrestamo " +
                "ON tbcontrolPrestamo.folioPrestamo = tbFolioPrestamos.folioPrestamo INNER JOIN tbCobrador ON tbClientes.idCobrador = tbCobrador.id  where tbcontrolPrestamo.folioPrestamo = '"+folio+"'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //--------------------------------------------------------------------PARA SABER LOS DETALES DE LAS MORATORIAS-----------------------------------------------------------------
        public static DataSet InformeDetalleMoras(int folio)
        {
            var query = Conexion.transacBD("Select tbFolioPrestamos.folioPrestamo As Folio, montoPres, restantePres, modalidadPago, CuotasPres, interesPres, " +
                "fechaPres, observacionPres, nombreCli + ' ' + apellido1Cli + ' ' + apellido2Cli AS nombreCli, telCli, domicilioCli, municipioCli, cuota, " +
                "fechaCuota, diaMesMoratoria, cantMoratoria, fechaPagoMoratoria, estadoMora, nombreCob + ' ' + apellido1Cob AS nombreCob, " +
                "CAST((select montoPres - (((montoPres) * (interesPres)) / (100 + interesPres)) AS cantPres " +
                "from tbFolioPrestamos where folioPrestamo = '"+folio+"') as decimal(36,2)) AS prestamoNeto, estadoPres from tbFolioPrestamos INNER JOIN tbClientes ON tbClientes.id = tbFolioPrestamos.idCliente " +
                "INNER JOIN tbMoras ON tbMoras.folioPrestamo = tbFolioPrestamos.folioPrestamo INNER JOIN tbCobrador ON tbClientes.idCobrador = tbCobrador.id  where tbMoras.folioPrestamo = '"+folio+"'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        public static DataSet InformeCobradores()
        {
            var query = Conexion.transacBD("select nombreCob, apellido1Cob, apellido2Cob, MunicipioCob, zonaCob, telefonoCob from tbCobrador", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //------------------------ PARA INFORME DONDE SE CALCULA EL MONTO TOTAL COBRADO A LOS CLIENTES POR LOS CONRADORES ------------------
        public static DataSet InformeMontoCobra(DateTime fecha)
        {

            var query = Conexion.transacBD("select tbCobrador.id, nombreCob +' '+apellido1Cob +' '+ apellido2Cob AS COBRADOR,telefonoCob,fechaAbono, SUM(montoCuota) AS TotalCuotas, nombreCli +' '+ apellido1Cli +' '+ apellido2Cli as cliente from tbcontrolPrestamo INNER JOIN tbFolioPrestamos ON tbcontrolPrestamo.folioPrestamo = tbFolioPrestamos.folioPrestamo INNER JOIN tbClientes ON tbClientes.id = tbFolioPrestamos.idCliente INNER JOIN tbCobrador ON tbClientes.idCobrador = tbCobrador.id where fechaAbono = '"+fecha.ToString("MM-dd-yyyy")+"' and estado = 'PAGADO' GROUP BY  tbCobrador.id, nombreCob, apellido1Cob, apellido2Cob, telefonoCob, fechaAbono, nombreCli, apellido1Cli, apellido2Cli ORDER BY TotalCuotas desc", true); ;
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //----------------------- TRAE LA LISTA DE PRESTAMOS Y LAS GANANCIAS DE LAS MISMAS POR FECHAS
        public static DataSet InformePrestamosGanancias(DateTime fechaDesde, DateTime fechaHasta, string estaPres)
        {
            var query = Conexion.transacBD("select folioPrestamo, montoPres,interesPres,CAST((montoPres - (((montoPres)*(interesPres))/(100 + interesPres))) as decimal (36,2)) AS prestamo, " +
                "CAST(((montoPres) * (interesPres)) / (100 + interesPres) as decimal(36,2)) AS gananciaInteres, " +
                "restantePres, modalidadPago, CuotasPres, fechaPres, estadoPres, nombreCli + ' ' + apellido1Cli + ' ' + apellido2Cli AS Cliente from tbFolioPrestamos " +
                "INNER JOIN tbClientes ON tbClientes.id = tbFolioPrestamos.idCliente where fechaPres between '"+fechaDesde.ToString("MM-dd-yyyy") +"' AND '"+fechaHasta.ToString("MM-dd-yyyy") + "' AND estadoPres != '"+ estaPres + "'", true); ;
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //-----------------------TRAE LA LISTA DE CUOTAS VENCIDAS-----------------------------------
        public static DataSet InformeCuotasVencidas()
        {
            var query = Conexion.transacBD("select tbcontrolPrestamo.folioPrestamo, numCuota, fechaCuota, montoCuota, estado, nombreCli +' '+ apellido1Cli +' '+ apellido2Cli as cliente, nombreCob +' '+ apellido1Cob +' '+apellido2Cob as Cobrador " +
                "from tbcontrolPrestamo INNER JOIN tbFolioPrestamos ON tbcontrolPrestamo.folioPrestamo = tbFolioPrestamos.folioPrestamo " +
                "INNER JOIN tbClientes ON tbClientes.id = tbFolioPrestamos.idCliente INNER JOIN tbCobrador ON tbCobrador.id = tbClientes.idCobrador where fechaCuota < '" + DateTime.Now.ToString("MM-dd-yyyy") + "' AND estado = 'PENDIENTE' " +
                "order by folioPrestamo", true); ;
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        // -------------------------------------------- TRAE LAS GANANCIAS POR PERIODOS-------------------------------------------------------
        public static DataSet InformeGanancias(DateTime fechaDesde, DateTime fechaHasta)
        {
            var query = Conexion.transacBD("select COUNT(tbcontrolPrestamo.folioPrestamo) as cantAbonos, SUM(montoCuota) as TotalmontosPagados, " +
                "SUM(((montoCuota) * (interesPres)) / (100 + interesPres)) AS gananciaInteres, SUM(cantMoratoria) AS TotalMorasPagadas from tbcontrolPrestamo " +
                "INNER JOIN tbFolioPrestamos ON tbcontrolPrestamo.folioPrestamo = tbFolioPrestamos.folioPrestamo " +
                "INNER JOIN tbMoras ON tbMoras.folioPrestamo = tbFolioPrestamos.folioPrestamo " +
                "where  tbcontrolPrestamo.estado = 'PAGADO' AND estadoMora = 'LIQUIDADO' AND fechaAbono BETWEEN '"+fechaDesde.ToString("MM-dd-yyyy")+"' AND '"+fechaHasta.ToString("MM-dd-yyyy")+ "' AND fechaPagoMoratoria BETWEEN '" + fechaDesde.ToString("MM-dd-yyyy") + "' AND '" + fechaHasta.ToString("MM-dd-yyyy") + "'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }


        // -------------------------------------------- TRAE LAS GANANCIAS DE LAS MORAS CONGELADAS-------------------------------------------------------
        public static DataSet GananciasMoras(DateTime fechaPago)
        {
            var query = Conexion.transacBD("select tbCobrador.id, nombreCob +' '+apellido1Cob +' '+ apellido2Cob AS COBRADOR,tbClientes.telCli,fechaPagoMoratoria,  " +
                "SUM(cantMoratoria) AS TotalCuotas, nombreCli + ' ' + apellido1Cli + ' ' + apellido2Cli as cliente  from tbMoras " +
                "INNER JOIN tbFolioPrestamos ON tbMoras.folioPrestamo = tbFolioPrestamos.folioPrestamo " +
                "INNER JOIN tbClientes ON tbClientes.id = tbFolioPrestamos.idCliente " +
                "INNER JOIN tbCobrador ON tbClientes.idCobrador = tbCobrador.id where fechaPagoMoratoria = '"+ fechaPago .ToString("MM-dd-yyyy")+ "' and estadoMora = 'LIQUIDADO' " +
                "GROUP BY  tbCobrador.id, nombreCob, apellido1Cob, apellido2Cob, telCli, fechaPagoMoratoria, nombreCli, apellido1Cli, apellido2Cli ORDER BY TotalCuotas desc", true); ;
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }


        public static DataSet Respaldo(string respaldo)
        {
            var query = Conexion.transacBD("'"+respaldo+"'", true); ;
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
