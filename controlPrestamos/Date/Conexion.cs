using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using controlPrestamos.Properties;
using System.Configuration;
using System.Windows.Forms;

namespace controlPrestamos.Date
{
    class Conexion
    {
        public static int conf;
        public static DataSet ds = new DataSet();
        public static string cadenaCon = ObtenerString();
        public static SqlConnection conexion = new SqlConnection(cadenaCon);
        public static SqlCommand comando = new SqlCommand();
        public static SqlDataAdapter sqlDA = new SqlDataAdapter();
        public static SqlDataAdapter daPV;
        //
        //public static SqlDataReader dr = comando.ExecuteReader();

        public static string ObtenerString() {
            return Settings.Default.dbControlClientesConnectionString;
        }


        static Conexion()
        {
            comando.Connection = conexion;
        }

        public static void backUpBD(string query) {

            SqlCommand comand2 = new SqlCommand(query,conexion);

            try
            {
                conexion.Open();
                comand2.ExecuteNonQuery();
                MessageBox.Show("LA COPIA SE HA CREADO SATISFACTORIAMENTE");

            }
            catch (Exception ex)
            {
                MessageBox.Show("SI DESEA REALIZAR OTRA COPIA DE SEGURIDAD, POR FAVOR CIERRE EL FORMULARIO E INTENTELO DE NUEVO", ex.ToString());

            }
            finally {
                conexion.Close();
                conexion.Dispose();
            }
            
        }

        public static Tuple<int, DataSet> transacBD(string query, Boolean select)
        {

            DataSet ds = new DataSet();

            if (select == true)
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = query;
                sqlDA.SelectCommand = comando;
                conf = sqlDA.Fill(ds);
                conexion.Close();
                return Tuple.Create(conf, ds);

            }
            else
            {
                conexion.Open();
                comando.CommandText = query;
                conf = comando.ExecuteNonQuery();
                conexion.Close();
                return Tuple.Create(conf, ds);
            }
        }

        public static void Informes(string query) {

            daPV = new SqlDataAdapter(cadenaCon, query);

            conexion.Close();
        
        }


    }
}