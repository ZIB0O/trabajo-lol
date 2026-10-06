namespace trabajo_de_profe_jamil_xd
{
    partial class TIENDADB
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            nuevaVentaToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            historialDePreciosToolStripMenuItem = new ToolStripMenuItem();
            alertasToolStripMenuItem = new ToolStripMenuItem();
            pnlVenta = new Panel();
            lblCliente = new Label();
            cboCliente = new ComboBox();
            lblProductoT = new Label();
            cboProducto = new ComboBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            lblPrecio = new Label();
            lblStock = new Label();
            dgvCarrito = new DataGridView();
            btnQuitar = new Button();
            lblTotal = new Label();
            btnGuardarVenta = new Button();
            pnlProductos = new Panel();
            dgvProductos = new DataGridView();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lblPrecioP = new Label();
            txtPrecio = new TextBox();
            lblStockP = new Label();
            txtStock = new TextBox();
            lblStockMin = new Label();
            txtStockMin = new TextBox();
            btnNuevo = new Button();
            btnGuardarProducto = new Button();
            btnEliminar = new Button();
            pnlHistorial = new Panel();
            dgvHistorial = new DataGridView();
            pnlAlertas = new Panel();
            dgvAlertas = new DataGridView();
            btnRefrescar = new Button();
            menuStrip1.SuspendLayout();
            pnlVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            pnlHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            pnlAlertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevaVentaToolStripMenuItem, productosToolStripMenuItem, historialDePreciosToolStripMenuItem, alertasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(704, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            nuevaVentaToolStripMenuItem.Size = new Size(85, 20);
            nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            nuevaVentaToolStripMenuItem.Click += nuevaVentaToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(76, 20);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // historialDePreciosToolStripMenuItem
            // 
            historialDePreciosToolStripMenuItem.Name = "historialDePreciosToolStripMenuItem";
            historialDePreciosToolStripMenuItem.Size = new Size(120, 20);
            historialDePreciosToolStripMenuItem.Text = "Historial de precios";
            historialDePreciosToolStripMenuItem.Click += historialDePreciosToolStripMenuItem_Click;
            // 
            // alertasToolStripMenuItem
            // 
            alertasToolStripMenuItem.Name = "alertasToolStripMenuItem";
            alertasToolStripMenuItem.Size = new Size(55, 20);
            alertasToolStripMenuItem.Text = "Alertas";
            alertasToolStripMenuItem.Click += alertasToolStripMenuItem_Click;
            // 
            // pnlVenta
            // 
            pnlVenta.Controls.Add(lblCliente);
            pnlVenta.Controls.Add(cboCliente);
            pnlVenta.Controls.Add(lblProductoT);
            pnlVenta.Controls.Add(cboProducto);
            pnlVenta.Controls.Add(lblCantidad);
            pnlVenta.Controls.Add(nudCantidad);
            pnlVenta.Controls.Add(btnAgregar);
            pnlVenta.Controls.Add(lblPrecio);
            pnlVenta.Controls.Add(lblStock);
            pnlVenta.Controls.Add(dgvCarrito);
            pnlVenta.Controls.Add(btnQuitar);
            pnlVenta.Controls.Add(lblTotal);
            pnlVenta.Controls.Add(btnGuardarVenta);
            pnlVenta.Dock = DockStyle.Fill;
            pnlVenta.Location = new Point(0, 24);
            pnlVenta.Name = "pnlVenta";
            pnlVenta.Size = new Size(704, 537);
            pnlVenta.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(30, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(100, 25);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(220, 23);
            cboCliente.TabIndex = 1;
            // 
            // lblProductoT
            // 
            lblProductoT.AutoSize = true;
            lblProductoT.Location = new Point(30, 63);
            lblProductoT.Name = "lblProductoT";
            lblProductoT.Size = new Size(59, 15);
            lblProductoT.TabIndex = 2;
            lblProductoT.Text = "Producto:";
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(100, 60);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(220, 23);
            cboProducto.TabIndex = 3;
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(30, 98);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(100, 95);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(80, 23);
            nudCantidad.TabIndex = 5;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(100, 128);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 27);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(350, 63);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio: $";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(350, 98);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(97, 15);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stock disponible:";
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(20, 170);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(664, 290);
            dgvCarrito.TabIndex = 9;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuitar.Location = new Point(20, 482);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(100, 30);
            btnQuitar.TabIndex = 10;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(350, 486);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 21);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total: $ 0.00";
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarVenta.Location = new Point(544, 480);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(140, 34);
            btnGuardarVenta.TabIndex = 12;
            btnGuardarVenta.Text = "Guardar venta";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // pnlProductos
            // 
            pnlProductos.Controls.Add(dgvProductos);
            pnlProductos.Controls.Add(lblNombre);
            pnlProductos.Controls.Add(txtNombre);
            pnlProductos.Controls.Add(lblCategoria);
            pnlProductos.Controls.Add(cboCategoria);
            pnlProductos.Controls.Add(lblPrecioP);
            pnlProductos.Controls.Add(txtPrecio);
            pnlProductos.Controls.Add(lblStockP);
            pnlProductos.Controls.Add(txtStock);
            pnlProductos.Controls.Add(lblStockMin);
            pnlProductos.Controls.Add(txtStockMin);
            pnlProductos.Controls.Add(btnNuevo);
            pnlProductos.Controls.Add(btnGuardarProducto);
            pnlProductos.Controls.Add(btnEliminar);
            pnlProductos.Dock = DockStyle.Fill;
            pnlProductos.Location = new Point(0, 24);
            pnlProductos.Name = "pnlProductos";
            pnlProductos.Size = new Size(704, 537);
            pnlProductos.TabIndex = 2;
            pnlProductos.Visible = false;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(20, 15);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(664, 270);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 310);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 307);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(20, 345);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(100, 342);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(200, 23);
            cboCategoria.TabIndex = 4;
            // 
            // lblPrecioP
            // 
            lblPrecioP.AutoSize = true;
            lblPrecioP.Location = new Point(340, 310);
            lblPrecioP.Name = "lblPrecioP";
            lblPrecioP.Size = new Size(41, 15);
            lblPrecioP.TabIndex = 5;
            lblPrecioP.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(430, 307);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // lblStockP
            // 
            lblStockP.AutoSize = true;
            lblStockP.Location = new Point(340, 345);
            lblStockP.Name = "lblStockP";
            lblStockP.Size = new Size(39, 15);
            lblStockP.TabIndex = 7;
            lblStockP.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(430, 342);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 8;
            // 
            // lblStockMin
            // 
            lblStockMin.AutoSize = true;
            lblStockMin.Location = new Point(340, 380);
            lblStockMin.Name = "lblStockMin";
            lblStockMin.Size = new Size(72, 15);
            lblStockMin.TabIndex = 9;
            lblStockMin.Text = "Stock mínimo:";
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new Point(430, 377);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.Size = new Size(100, 23);
            txtStockMin.TabIndex = 10;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(20, 430);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 32);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(130, 430);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(100, 32);
            btnGuardarProducto.TabIndex = 12;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(240, 430);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pnlHistorial
            // 
            pnlHistorial.Controls.Add(dgvHistorial);
            pnlHistorial.Dock = DockStyle.Fill;
            pnlHistorial.Location = new Point(0, 24);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(704, 537);
            pnlHistorial.TabIndex = 3;
            pnlHistorial.Visible = false;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(0, 0);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.Size = new Size(704, 537);
            dgvHistorial.TabIndex = 0;
            // 
            // pnlAlertas
            // 
            pnlAlertas.Controls.Add(btnRefrescar);
            pnlAlertas.Controls.Add(dgvAlertas);
            pnlAlertas.Dock = DockStyle.Fill;
            pnlAlertas.Location = new Point(0, 24);
            pnlAlertas.Name = "pnlAlertas";
            pnlAlertas.Size = new Size(704, 537);
            pnlAlertas.TabIndex = 4;
            pnlAlertas.Visible = false;
            // 
            // dgvAlertas
            // 
            dgvAlertas.AllowUserToAddRows = false;
            dgvAlertas.AllowUserToDeleteRows = false;
            dgvAlertas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlertas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlertas.Location = new Point(20, 20);
            dgvAlertas.Name = "dgvAlertas";
            dgvAlertas.ReadOnly = true;
            dgvAlertas.Size = new Size(664, 440);
            dgvAlertas.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefrescar.Location = new Point(584, 480);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(100, 32);
            btnRefrescar.TabIndex = 1;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // TIENDADB
            // 
            ClientSize = new Size(704, 561);
            Controls.Add(pnlVenta);
            Controls.Add(pnlProductos);
            Controls.Add(pnlHistorial);
            Controls.Add(pnlAlertas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TIENDADB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TIENDADB";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlVenta.ResumeLayout(false);
            pnlVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            pnlProductos.ResumeLayout(false);
            pnlProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            pnlHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            pnlAlertas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem historialDePreciosToolStripMenuItem;
        private ToolStripMenuItem alertasToolStripMenuItem;
        private Panel pnlVenta;
        private Label lblCliente;
        private ComboBox cboCliente;
        private Label lblProductoT;
        private ComboBox cboProducto;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Label lblPrecio;
        private Label lblStock;
        private DataGridView dgvCarrito;
        private Button btnQuitar;
        private Label lblTotal;
        private Button btnGuardarVenta;
        private Panel pnlProductos;
        private DataGridView dgvProductos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private Label lblPrecioP;
        private TextBox txtPrecio;
        private Label lblStockP;
        private TextBox txtStock;
        private Label lblStockMin;
        private TextBox txtStockMin;
        private Button btnNuevo;
        private Button btnGuardarProducto;
        private Button btnEliminar;
        private Panel pnlHistorial;
        private DataGridView dgvHistorial;
        private Panel pnlAlertas;
        private DataGridView dgvAlertas;
        private Button btnRefrescar;
    }
}