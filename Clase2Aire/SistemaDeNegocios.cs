using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2Aire
{
    public partial class SistemaDeNegocios : Form
    {
        public SistemaDeNegocios()
        {
            InitializeComponent();
        }
        Clase3 d = new Clase3();
        private void SistemaDeNegocios_Load(object sender, EventArgs e)
        {
            d.ListaAnos(cboAnosPedido);
        }

        private void cboAñosPedido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            d.ListaMeses(cboMesesPedido, Convert.ToInt32(cboAnosPedido.SelectedValue));
        }

        private void cboMesesPedido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            d.ListaEmpleados(cboEmpleados, Convert.ToInt32(cboAnosPedido.SelectedValue), Convert.ToInt32(cboMesesPedido.SelectedValue));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(cboAnosPedido.SelectedValue);
            int mes = Convert.ToInt32(cboMesesPedido.SelectedValue);
            int emp = Convert.ToInt32(cboEmpleados.SelectedValue);
            dgvClientes.DataSource = d.TablaClientes(ano, mes, emp);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells["IdCliente"].Value);
            int ano = Convert.ToInt32(cboAnosPedido.SelectedValue);
            int mes = Convert.ToInt32(cboMesesPedido.SelectedValue);
            int emp = Convert.ToInt32(cboEmpleados.SelectedValue);
            dgvListaPedidos.DataSource = d.TablaPedido(ID, ano, mes, emp);
            dgvDetallesPedido.DataSource = d.TablaDetalles(ID, ano, mes, emp);
        }
    }
}