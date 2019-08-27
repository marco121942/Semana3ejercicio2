using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Clase2Aire
{
    class Conexion
    {
        public SqlConnection cadena()
        {
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings["Marco"].ConnectionString);
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }
    }
}
