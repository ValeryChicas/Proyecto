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
    public partial class CitaServicio : Form
    {
        public CitaServicio()
        {
            InitializeComponent();
        }

        private void CitaServicio_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var citaServicio = CitaServicioBl.Instance.SelectAll();

            var data = citaServicio.Select(c => new
            {
                c.CitaServicioId,
                Fecha = c.FechaConsulta,
                Precio = c.Precio,
                Descripcion = c.Descripcion,
                Servicio = c.ServicioId.Nombre,
                Mascota = c.MascotaId.Nombre,
                Empleado = c.EmpleadoId.Nombre

            }).ToList();

            Dtv_CitaServicios.DataSource = data;
        }

        private void Dtv_CitaServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_CitaServicios.Rows[e.RowIndex];

                Dtp_FechaConsulta.Text = fila.Cells[1].Value?.ToString();
                Txt_Precio.Text = fila.Cells[2].Value?.ToString();
                Txt_Descripcion.Text = fila.Cells[3].Value?.ToString();
                Cbx_Servicio.Text = fila.Cells[5].Value?.ToString();
                Txt_Mascota.Text = fila.Cells[4].Value?.ToString();
                Cbx_Empleado.Text = fila.Cells[6].Value?.ToString();
            }
        }

        private void Txt_Buscador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
