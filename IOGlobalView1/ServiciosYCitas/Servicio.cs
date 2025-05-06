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

namespace IOGlobalView1.ServiciosYCitas
{
    public partial class Servicio : Form
    {
        public Servicio()
        {
            InitializeComponent();
        }

        private void Servicio_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var servicio = ServicioBl.Instance.SelectAll();

            var data = servicio.Select(c => new
            {
                c.ServicioId,
                Nombre = c.Nombre,
                Descripcion = c.Descripcion,
                Precio = c.Precio
            }).ToList();

            Dtv_Servicio.DataSource = data;
        }

        private void Dtv_Servicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_Servicio.Rows[e.RowIndex];

                Txt_Producto.Text = fila.Cells[1].Value?.ToString();
                Txt_Descripcion.Text = fila.Cells[2].Value?.ToString();
                Txt_Precio.Text = fila.Cells[3].Value?.ToString();
            }
        }
    }
}
