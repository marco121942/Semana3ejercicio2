namespace Clase2Aire
{
    partial class SistemaDeNegocios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAnosPedido = new System.Windows.Forms.ComboBox();
            this.cboMesesPedido = new System.Windows.Forms.ComboBox();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
            this.dgvDetallesPedido = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNPedidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCantPedidos = new System.Windows.Forms.TextBox();
            this.tbMontoTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de los Años de Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de los Meses de Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empleados";
            // 
            // cboAnosPedido
            // 
            this.cboAnosPedido.FormattingEnabled = true;
            this.cboAnosPedido.Location = new System.Drawing.Point(186, 13);
            this.cboAnosPedido.Name = "cboAnosPedido";
            this.cboAnosPedido.Size = new System.Drawing.Size(231, 21);
            this.cboAnosPedido.TabIndex = 3;
            this.cboAnosPedido.SelectionChangeCommitted += new System.EventHandler(this.cboAñosPedido_SelectionChangeCommitted);
            // 
            // cboMesesPedido
            // 
            this.cboMesesPedido.FormattingEnabled = true;
            this.cboMesesPedido.Location = new System.Drawing.Point(186, 47);
            this.cboMesesPedido.Name = "cboMesesPedido";
            this.cboMesesPedido.Size = new System.Drawing.Size(231, 21);
            this.cboMesesPedido.TabIndex = 4;
            this.cboMesesPedido.SelectionChangeCommitted += new System.EventHandler(this.cboMesesPedido_SelectionChangeCommitted);
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(186, 78);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(231, 21);
            this.cboEmpleados.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(473, 76);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(162, 23);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar Lista";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 131);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(286, 150);
            this.dgvClientes.TabIndex = 7;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.AllowUserToAddRows = false;
            this.dgvListaPedidos.AllowUserToDeleteRows = false;
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidos.Location = new System.Drawing.Point(371, 131);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.ReadOnly = true;
            this.dgvListaPedidos.Size = new System.Drawing.Size(408, 150);
            this.dgvListaPedidos.TabIndex = 8;
            // 
            // dgvDetallesPedido
            // 
            this.dgvDetallesPedido.AllowUserToAddRows = false;
            this.dgvDetallesPedido.AllowUserToDeleteRows = false;
            this.dgvDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesPedido.Location = new System.Drawing.Point(371, 319);
            this.dgvDetallesPedido.Name = "dgvDetallesPedido";
            this.dgvDetallesPedido.ReadOnly = true;
            this.dgvDetallesPedido.Size = new System.Drawing.Size(408, 125);
            this.dgvDetallesPedido.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nro. de Pedidos";
            // 
            // tbNPedidos
            // 
            this.tbNPedidos.Location = new System.Drawing.Point(661, 285);
            this.tbNPedidos.Name = "tbNPedidos";
            this.tbNPedidos.Size = new System.Drawing.Size(100, 20);
            this.tbNPedidos.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad Total de Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monto Total";
            // 
            // tbCantPedidos
            // 
            this.tbCantPedidos.Location = new System.Drawing.Point(661, 457);
            this.tbCantPedidos.Name = "tbCantPedidos";
            this.tbCantPedidos.Size = new System.Drawing.Size(100, 20);
            this.tbCantPedidos.TabIndex = 14;
            // 
            // tbMontoTotal
            // 
            this.tbMontoTotal.Location = new System.Drawing.Point(661, 486);
            this.tbMontoTotal.Name = "tbMontoTotal";
            this.tbMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.tbMontoTotal.TabIndex = 15;
            // 
            // SistemaDeNegocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.tbMontoTotal);
            this.Controls.Add(this.tbCantPedidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNPedidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDetallesPedido);
            this.Controls.Add(this.dgvListaPedidos);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cboEmpleados);
            this.Controls.Add(this.cboMesesPedido);
            this.Controls.Add(this.cboAnosPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SistemaDeNegocios";
            this.Text = "SistemaDeNegocios";
            this.Load += new System.EventHandler(this.SistemaDeNegocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAnosPedido;
        private System.Windows.Forms.ComboBox cboMesesPedido;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvListaPedidos;
        private System.Windows.Forms.DataGridView dgvDetallesPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNPedidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCantPedidos;
        private System.Windows.Forms.TextBox tbMontoTotal;
    }
}