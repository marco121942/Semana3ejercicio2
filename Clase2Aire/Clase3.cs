using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clase2Aire
{
    class Clase3 : Conexion
    {
        SqlConnection cn = new SqlConnection();
        //////////////////////////////////////////////////////////////////
        public void ListaAnos(ComboBox cbo)
        {
            cn = cadena();
            SqlDataAdapter df = new SqlDataAdapter("usp_ListaAnos", cn);
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            df.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "ano";
            cbo.ValueMember = "ano";
        }
        ////////////////////////////////////////////////////////////
        
        //////////////////////////////////////////////////////////////////
        public void ListaMeses(ComboBox cbo, int x)
        {
            cn = cadena();
            SqlDataAdapter df = new SqlDataAdapter("usp_ListaMeses", cn);
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            df.SelectCommand.Parameters.AddWithValue("@ano", x);
            DataTable dt = new DataTable();
            df.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "mes";
            cbo.ValueMember = "mes";
        }
        /////////////////////////////////////////////////////////
        ///
        //////////////////////////////////////////////////////////////////
        public void ListaEmpleados(ComboBox cbo, int x, int y)
        {
            cn = cadena();
            SqlDataAdapter df = new SqlDataAdapter("usp_ListaEmpleado", cn);
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            df.SelectCommand.Parameters.AddWithValue("@ano", x);
            df.SelectCommand.Parameters.AddWithValue("@mes", y);
            DataTable dt = new DataTable();
            df.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "empleado";
            cbo.ValueMember = "IdEmpleado";
        }
        /////////////////////////////////////////////////////////
        ///
        //////////////////////////////////////////////////////////////////
        public DataTable TablaClientes(int ano, int mes, int emp)
        {
            using (SqlDataAdapter df= new SqlDataAdapter("usp_Clientes", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idAno", ano);
                df.SelectCommand.Parameters.AddWithValue("@idMes", mes);
                df.SelectCommand.Parameters.AddWithValue("@idEmp", emp);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        /////////////////////////////////////////////////////////
        ///
        //////////////////////////////////////////////////////////////////
        public DataTable TablaPedido(string idclie,int ano, int mes, int emp)
        {
            using (SqlDataAdapter df = new SqlDataAdapter("usp_PedidoporCliente", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idclie", idclie);
                df.SelectCommand.Parameters.AddWithValue("@Ano", ano);
                df.SelectCommand.Parameters.AddWithValue("@Mes", mes);
                df.SelectCommand.Parameters.AddWithValue("@Emp", emp);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        /////////////////////////////////////////////////////////
        ///
        //////////////////////////////////////////////////////////////////
        public DataTable TablaDetalles(string idclie, int ano, int mes, int emp)
        {
            using (SqlDataAdapter df = new SqlDataAdapter("usp_PedidoporDetalle", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idclie", idclie);
                df.SelectCommand.Parameters.AddWithValue("@Ano", ano);
                df.SelectCommand.Parameters.AddWithValue("@Mes", mes);
                df.SelectCommand.Parameters.AddWithValue("@Emp", emp);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        /////////////////////////////////////////////////////////
    }
}
