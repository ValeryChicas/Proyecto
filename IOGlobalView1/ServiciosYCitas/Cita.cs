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
    public partial class Cita : Form
    {
        public Cita()
        {
            InitializeComponent();
        }
        private void Cita_Load(object sender, EventArgs e)
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
            var cita = CitaBl.Instance.SelectAll();

            var data = cita.Select(c => new
            {
                c.CitaId,
                Fecha = c.FechaCita,
                FechaReprogramada = c.FechaReprogramada == DateTime.MinValue ? "" : c.FechaReprogramada.ToShortDateString(),
                Recordatorio = c.Recordatorio ? "" : "",
                Precio = c.Precio,
                Peso = c.Peso,
                Mascota = c.MascotaId.Nombre,
                Empleado = c.EmpleadoId.NombreCompleto,
                Estado = c.EstadoId.Nombre,
                Usuario = c.UsuarioId.Nombre

            }).ToList();

            Dtv_Cita.DataSource = data;
        }

        private void Dtv_Cita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_Cita.Rows[e.RowIndex];

                Dtp_FechaCita.Text = fila.Cells[1].Value?.ToString();
                if (DateTime.TryParse(fila.Cells[2].Value?.ToString(), out DateTime parsedDate) &&
                        parsedDate >= Dtp_FechaReprogramada.MinDate &&
                        parsedDate <= Dtp_FechaReprogramada.MaxDate)
                {
                    Dtp_FechaReprogramada.Value = parsedDate;
                }
                else
                {
                    Dtp_FechaReprogramada.Value = DateTime.Now; // Or any default valid date
                }
                Txt_Recordatorio.Text = fila.Cells[3].Value?.ToString();       
                Txt_Precio.Text = fila.Cells[4].Value?.ToString();             
                Txt_Peso.Text = fila.Cells[5].Value?.ToString();               
                Txt_Mascota.Text = fila.Cells[6].Value?.ToString();            
                Txt_Empleado.Text = fila.Cells[7].Value?.ToString();           
                Cbx_Estado.Text = fila.Cells[8].Value?.ToString();
            }
        }
    }
}
