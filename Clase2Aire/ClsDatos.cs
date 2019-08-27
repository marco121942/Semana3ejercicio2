using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clase2Aire
{
    class ClsDatos : Conexion
    {
        SqlConnection cn = new SqlConnection();
        public DataTable ListaPedidoFecha(DateTime x, DateTime y)
        {
            try
            {
                cn = cadena();
                SqlDataAdapter Df = new SqlDataAdapter("usp_FechaFecha", cn);
                Df.SelectCommand.CommandType = CommandType.StoredProcedure;
                Df.SelectCommand.Parameters.AddWithValue("@fec1", x);
                Df.SelectCommand.Parameters.AddWithValue("@fec2", y);
                DataTable da = new DataTable();
                Df.Fill(da);
                return da;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public DataTable ListaDetalle(int x)
        {
            cn = cadena();
            SqlDataAdapter Df = new SqlDataAdapter("usp_Detalle", cn);
            Df.SelectCommand.CommandType = CommandType.StoredProcedure;
            Df.SelectCommand.Parameters.AddWithValue("@Idpedido", x);
            DataTable da = new DataTable();
            Df.Fill(da);
            return da;
        }
        public double PedidoTotal(Int32 idpedido)
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_Total", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@pedido", idpedido);
            da.SelectCommand.Parameters.Add(
                "@Total", SqlDbType.Money).Direction = 
                ParameterDirection.Output;
            da.SelectCommand.ExecuteScalar();
            Int32 Idpe = Convert.ToInt32
                (da.SelectCommand.Parameters["@Total"].Value);
            cn.Close();
            return Idpe;
        }
    }
}
