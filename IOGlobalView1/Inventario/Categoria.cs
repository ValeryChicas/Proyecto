using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOGlobal.Entities;
using IOGlobal.BusinessLogic;

namespace IOGlobalView1.Inventario
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        private void Categoria_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            CargarEstados();
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
            var categorias = CategoriaBl.Instance.SelectAll();

            var data = categorias.Select(c => new
            {
                c.CategoriaId,
                Nombre = c.Nombre,
                Estado = c.EstadoId.Nombre
            }).ToList();

            Dtv_Categoria.DataSource = data;
        }
        private void Agregar() {
            //var categoria = new Categoria();
            //{
            //    Nombre = Txt_Nombre.Text;
            //    EstadoId = new Estado()
            //    {
            //        EstadoId = Convert.ToInt32(Cbx_Estado.SelectedValue)
            //    };
            //};
            //CategoriaBl.Instance.Insert(categoria);
            //UpdateGrid();
            //Limpiar();
        }
        private void Limpiar()
        {
            Txt_Nombre.Text = "";
            Cbx_Estado.Text = "";
        }
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        //La info del dtv se pasa a los textbox
        private void Dtv_Categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_Categoria.Rows[e.RowIndex];

                Txt_Nombre.Text = fila.Cells[1].Value?.ToString();
                Cbx_Estado.Text = fila.Cells[2].Value?.ToString();
            }
        }

        private void Txt_Buscador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
