using IOGlobal.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOGlobalView1.Inventario
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        private void CargarProductos()
        {
            var producto = ProductoBl.Instance.SelectAll();

            Cbx_Producto.DataSource = producto;
            Cbx_Producto.DisplayMember = "Nombre";      // Lo que se ve
            Cbx_Producto.ValueMember = "CategoriaId";   // Lo que se usa internamente
            Cbx_Producto.SelectedIndex = -1;            // Para que no aparezca nada seleccionado al cargar
        }
        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var inventario = InventarioBl.Instance.SelectAll();

            var data = inventario.Select(c => new
            {
                c.InventarioId,
                Producto = c.ProductoId.Nombre,
                FechaIngreso = c.FechaIngreso,
                Cantidad = c.Stock,
                FechaVencimiento = c.FechaVencimiento,

            }).ToList();

            Dtv_Inventario.DataSource = data;
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            CargarProductos();

        }

        private void Dtv_Inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_Inventario.Rows[e.RowIndex];

                Cbx_Producto.Text = fila.Cells[1].Value?.ToString();
                Dtp_FechaIngreso.Text = fila.Cells[2].Value?.ToString();
                Nud_Cantidad.Text = fila.Cells[3].Value?.ToString();
                Dtp_FechaVencimiento.Text = fila.Cells[4].Value?.ToString();
            }

        }
    }
}
