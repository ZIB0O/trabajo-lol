#nullable disable
using Microsoft.Data.SqlClient;
using System.Data;

namespace trabajo_de_profe_jamil_xd
{
    public partial class TIENDADB : Form
    {
        private readonly DataTable carrito = new DataTable();
        private bool cargandoProductos = false;
        private int? idProductoSel = null;

        public TIENDADB()
        {
            InitializeComponent(); // Corregido: sintaxis y punto y coma
        }

        // ---------------------------------------------------------
        // CARGA INICIAL
        // ---------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            carrito.Columns.Add("IdProducto", typeof(int));
            carrito.Columns.Add("Producto", typeof(string));
            carrito.Columns.Add("Cantidad", typeof(int));
            carrito.Columns.Add("Precio", typeof(decimal));
            carrito.Columns.Add("Subtotal", typeof(decimal));
            dgvCarrito.DataSource = carrito;
            if (dgvCarrito.Columns.Contains("IdProducto"))
                dgvCarrito.Columns["IdProducto"].Visible = false;

            try
            {
                CargarClientes();
                CargarProductosCombo();
                CargarCategorias();
                CargarProductosGrid();
                CargarHistorial();
                CargarAlertas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.\n\n" + ex.Message +
                                "\n\nRevisa el Server en Db.cs");
            }

            Mostrar(pnlVenta);
        }

        // ---------------------------------------------------------
        // MENÚ
        // ---------------------------------------------------------
        private void Mostrar(Panel p)
        {
            pnlVenta.Visible = p == pnlVenta;
            pnlProductos.Visible = p == pnlProductos;
            pnlHistorial.Visible = p == pnlHistorial;
            pnlAlertas.Visible = p == pnlAlertas;
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarProductosCombo();
            Mostrar(pnlVenta);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarProductosGrid();
            Mostrar(pnlProductos);
        }

        private void historialDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarHistorial();
            Mostrar(pnlHistorial);
        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarAlertas();
            Mostrar(pnlAlertas);
        }

        // ---------------------------------------------------------
        // NUEVA VENTA
        // ---------------------------------------------------------
        private void CargarClientes()
        {
            cboCliente.DataSource = Db.Query("SELECT IdCliente, Nombre FROM Clientes ORDER BY Nombre");
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "IdCliente";
        }

        private void CargarProductosCombo()
        {
            cargandoProductos = true;
            cboProducto.DataSource = Db.Query("SELECT IdProducto, Nombre, Precio, Stock FROM Productos ORDER BY Nombre");
            cboProducto.DisplayMember = "Nombre";
            cboProducto.ValueMember = "IdProducto";
            cargandoProductos = false;
            cboProducto_SelectedIndexChanged(null, null);
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoProductos) return;

            if (cboProducto.SelectedItem is DataRowView r)
            {
                lblPrecio.Text = $"Precio: $ {Convert.ToDecimal(r["Precio"]):N2}";
                lblStock.Text = $"Stock disponible: {r["Stock"]}";
                nudCantidad.Maximum = Math.Max(1, Convert.ToInt32(r["Stock"]));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem is not DataRowView r)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            int id = (int)r["IdProducto"];
            int cant = (int)nudCantidad.Value;
            decimal precio = (decimal)r["Precio"];
            int stock = (int)r["Stock"];

            var existente = carrito.AsEnumerable().FirstOrDefault(x => x.Field<int>("IdProducto") == id);
            int yaEnCarrito = existente?.Field<int>("Cantidad") ?? 0;

            if (yaEnCarrito + cant > stock)
            {
                MessageBox.Show("No hay stock suficiente.");
                return;
            }

            if (existente != null)
            {
                existente["Cantidad"] = yaEnCarrito + cant;
                existente["Subtotal"] = (yaEnCarrito + cant) * precio;
            }
            else
            {
                carrito.Rows.Add(id, r["Nombre"], cant, precio, cant * precio);
            }

            ActualizarTotal();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                dgvCarrito.Rows.Remove(dgvCarrito.CurrentRow);
                ActualizarTotal();
            }
        }

        private void ActualizarTotal()
        {
            decimal total = carrito.AsEnumerable().Sum(x => x.Field<decimal>("Subtotal"));
            lblTotal.Text = $"Total: $ {total:N2}";
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }
            if (cboCliente.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un cliente (si no hay, agrégalo en la BD).");
                return;
            }

            using var cn = new SqlConnection(Db.ConnStr);
            cn.Open();
            using var tx = cn.BeginTransaction();
            try
            {
                var cmd = new SqlCommand(
                    "INSERT INTO Ventas (IdCliente) VALUES (@c); SELECT SCOPE_IDENTITY();", cn, tx);
                cmd.Parameters.AddWithValue("@c", cboCliente.SelectedValue);
                int idVenta = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (DataRow row in carrito.Rows)
                {
                    var d = new SqlCommand(
                        @"INSERT INTO DetalleVentas (IdVenta, IdProducto, Cantidad, PrecioUnitario)
                          VALUES (@v, @p, @c, @pr)", cn, tx);
                    d.Parameters.AddWithValue("@v", idVenta);
                    d.Parameters.AddWithValue("@p", row["IdProducto"]);
                    d.Parameters.AddWithValue("@c", row["Cantidad"]);
                    d.Parameters.AddWithValue("@pr", row["Precio"]);
                    d.ExecuteNonQuery();
                }

                tx.Commit();
                MessageBox.Show("Venta registrada.");
                carrito.Clear();
                ActualizarTotal();
                CargarProductosCombo();
                CargarProductosGrid();
                CargarAlertas();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ---------------------------------------------------------
        // PRODUCTOS (CRUD)
        // ---------------------------------------------------------
        private void CargarCategorias()
        {
            cboCategoria.DataSource = Db.Query("SELECT IdCategoria, Nombre FROM Categorias ORDER BY Nombre");
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "IdCategoria";
        }

        private void CargarProductosGrid()
        {
            dgvProductos.DataSource = Db.Query(
                @"SELECT p.IdProducto, p.Nombre, c.Nombre AS Categoria, p.IdCategoria,
                         p.Precio, p.Stock, p.StockMinimo
                  FROM Productos p
                  JOIN Categorias c ON p.IdCategoria = c.IdCategoria
                  ORDER BY p.Nombre");

            if (dgvProductos.Columns.Contains("IdCategoria"))
                dgvProductos.Columns["IdCategoria"].Visible = false;
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null || dgvProductos.CurrentRow.Cells.Count == 0) return;
            if (!dgvProductos.Columns.Contains("IdProducto")) return;

            var c = dgvProductos.CurrentRow.Cells;
            idProductoSel = Convert.ToInt32(c["IdProducto"].Value);
            txtNombre.Text = c["Nombre"].Value?.ToString();
            cboCategoria.SelectedValue = c["IdCategoria"].Value;
            txtPrecio.Text = Convert.ToDecimal(c["Precio"].Value).ToString("0.##");
            txtStock.Text = c["Stock"].Value?.ToString();
            txtStockMin.Text = c["StockMinimo"].Value?.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idProductoSel = null;
            dgvProductos.ClearSelection();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtStockMin.Text = "5";
            txtNombre.Focus();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escribe el nombre.");
                return;
            }
            if (cboCategoria.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una categoría.");
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0 ||
                !int.TryParse(txtStock.Text, out int stock) || stock < 0 ||
                !int.TryParse(txtStockMin.Text, out int stockMin) || stockMin < 0)
            {
                MessageBox.Show("Precio, stock y stock mínimo deben ser números válidos (no negativos).");
                return;
            }

            try
            {
                if (idProductoSel == null)
                {
                    Db.Exec(@"INSERT INTO Productos (Nombre, IdCategoria, Precio, Stock, StockMinimo)
                              VALUES (@n, @c, @pr, @s, @m)",
                        new SqlParameter("@n", txtNombre.Text.Trim()),
                        new SqlParameter("@c", cboCategoria.SelectedValue),
                        new SqlParameter("@pr", precio),
                        new SqlParameter("@s", stock),
                        new SqlParameter("@m", stockMin));
                }
                else
                {
                    Db.Exec(@"UPDATE Productos
                              SET Nombre=@n, IdCategoria=@c, Precio=@pr, Stock=@s, StockMinimo=@m
                              WHERE IdProducto=@id",
                        new SqlParameter("@n", txtNombre.Text.Trim()),
                        new SqlParameter("@c", cboCategoria.SelectedValue),
                        new SqlParameter("@pr", precio),
                        new SqlParameter("@s", stock),
                        new SqlParameter("@m", stockMin),
                        new SqlParameter("@id", idProductoSel.Value));
                }

                CargarProductosGrid();
                CargarProductosCombo();
                CargarHistorial();
                CargarAlertas();
                MessageBox.Show("Producto guardado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSel == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            if (MessageBox.Show("¿Eliminar este producto?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Db.Exec("DELETE FROM Productos WHERE IdProducto=@id",
                    new SqlParameter("@id", idProductoSel.Value));
                idProductoSel = null;
                CargarProductosGrid();
                CargarProductosCombo();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se puede eliminar: el producto ya tiene ventas registradas.");
            }
        }

        // ---------------------------------------------------------
        // HISTORIAL Y ALERTAS
        // ---------------------------------------------------------
        private void CargarHistorial()
        {
            dgvHistorial.DataSource = Db.Query(
                @"SELECT h.IdHistorial, p.Nombre AS Producto, h.PrecioAnterior, h.PrecioNuevo, h.Fecha
                  FROM HistorialPrecios h
                  LEFT JOIN Productos p ON p.IdProducto = h.IdProducto
                  ORDER BY h.Fecha DESC");
        }

        private void CargarAlertas()
        {
            dgvAlertas.DataSource = Db.Query(
                @"SELECT a.IdAlerta, p.Nombre AS Producto, a.StockActual, a.Fecha
                  FROM AlertasStock a
                  LEFT JOIN Productos p ON p.IdProducto = a.IdProducto
                  ORDER BY a.Fecha DESC");
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarAlertas();
        }
    }
}
