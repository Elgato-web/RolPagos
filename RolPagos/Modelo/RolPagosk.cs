using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.Data;

namespace RolPagos.Modelo

{
    class RolPagosk
    {
        private static string cadenaConexion = "server = DESKTOP-U1CHEML; database = TI2020; user id = sa; password = ayapamba259";
        public static int pagos(RolPagos rolpagos) 
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "insert into RolPagos(codRol,nombreEmpleado,departamento,totalIngresos,totalEgresos) values(@codrol,@nombreempleado,@departamento,@totalingresos,@totalegresos)";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codrol",rolpagos.codRol);
            comando.Parameters.AddWithValue("@departamento", rolpagos.departamento);
            comando.Parameters.AddWithValue("@totalingresos", rolpagos.totalIngresos);
            comando.Parameters.AddWithValue("@totalegresos", rolpagos.totalEgresos);
            comando.Parameters.AddWithValue("@nombreempleado", rolpagos.nombreEmpleado);
            conn.Open();
            int x = comando.ExecuteNonQuery();
            conn.Close();
            return x;
        }
        public static DataTable getAll() 
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select codRol,nombreEmpleado,departamento,totalIngresos,totalEgresos,FechaCreacion " + "from RolPagos " +
               "order by codRol,nombreEmpleado";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static RolPagos getpagos(String codRol) 
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select codRol,nombreEmpleado,departamento,totalIngresos,totalEgresos,FechadeCreacion " + "from RolPagos " +
              "order by codRol,nombreEmpleado";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@codRol", codRol);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            RolPagos carrera = new RolPagos();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    carrera.codRol = fila["codRol"].ToString();
                    carrera.nombreEmpleado = fila["nombreEmpleado"].ToString();
                    carrera.totalIngresos = int.Parse(fila["totalIngresos"].ToString());
                    carrera.departamento = fila["departamento"].ToString();
                    carrera.totalEgresos = int.Parse(fila["totalEgresos"].ToString());
                    break;

                }
            }
            return carrera;
        }
        public static int update(RolPagos rolpagos) 
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            String sql = "UPDATE RolPagos SET codRol=@codrol, nombreEmpleado=@nombreempleado, departamento=@departamento,totalIngresos=@totalingresos,totalEgresos=@totalEgresos";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codrol", rolpagos.codRol);
            comando.Parameters.AddWithValue("@departamento", rolpagos.departamento);
            comando.Parameters.AddWithValue("@totalingresos", rolpagos.totalIngresos);
            comando.Parameters.AddWithValue("@totalegresos", rolpagos.totalEgresos);
            comando.Parameters.AddWithValue("@nombreempleado", rolpagos.nombreEmpleado);
            conn.Open();
            int x = comando.ExecuteNonQuery();
            conn.Close();
            return x;

        }

    }
}
