using IOGlobal.BusinessLogic;
using IOGlobal.Entities;
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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        private void CargarCategorias()
        {
            var categoria = CategoriaBl.Instance.SelectAll();

            Cbx_Categoria.DataSource = categoria;
            Cbx_Categoria.DisplayMember = "Nombre";      // Lo que se ve
            Cbx_Categoria.ValueMember = "CategoriaId";   // Lo que se usa internamente
            Cbx_Categoria.SelectedIndex = -1;            // Para que no aparezca nada seleccionado al cargar
        }
        private void CargarEstados()
        {
            var estado = EstadoBl.Instance.SelectAll();

            Cbx_Estado.DataSource = estado;
            Cbx_Estado.DisplayMember = "Nombre"; 
            Cbx_Estado.ValueMember = "EstadoId";
            Cbx_Estado.SelectedIndex = -1; 
        }
        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var producto = ProductoBl.Instance.SelectAll();

            var data = producto.Select(c => new
            {
                c.ProductoId,
                Nombre = c.Nombre,
                Descripcion = c.Descripcion,
                Precio = c.Precio,
                StockMinimo = c.StockMinimo,
                Categoria = c.CategoriaId.Nombre,
                Estado = c.EstadoId.Nombre,

            }).ToList();

            Dtv_Producto.DataSource = data;
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            CargarCategorias();
            CargarEstados();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            
        }

        private void Dtv_Producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_Producto.Rows[e.RowIndex];

                Txt_Producto.Text = fila.Cells[1].Value?.ToString();
                Txt_Descripcion.Text = fila.Cells[2].Value?.ToString();
                Txt_Precio.Text = fila.Cells[3].Value?.ToString();
                Nud_CantidadMinima.Text = fila.Cells[4].Value?.ToString();
                Cbx_Categoria.Text = fila.Cells[5].Value?.ToString();
                Cbx_Estado.Text = fila.Cells[6].Value?.ToString();
            }

        }
    }
}
