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

namespace IOGlobalView1.FormAdministracion
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            CargarEstados();
        }

        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var usuario = UsuarioBl.Instance.SelectAll();

            var data = usuario.Select(c => new
            {
                c.UsuarioId,
                Nombre = c.Nombre,
                Contrasena = c.Contrasena,
                Empleado = c.EmpleadoId.Nombre,
                Rol = c.RolusuarioId.Nombre,
                Estado = c.EstadoId.Nombre,

            }).ToList();

            Dtv_Usuario.DataSource = data;


        }
        private void CargarEstados()
        {
            var estado = EstadoBl.Instance.SelectAll();

            Cbx_Estado.DataSource = estado;
            Cbx_Estado.DisplayMember = "Nombre";
            Cbx_Estado.ValueMember = "EstadoId";
            Cbx_Estado.SelectedIndex = -1;
        }
        private string OcultarContrasena(string contrasenaReal)
        {
            // Oculta la contraseña mostrando 5 asteriscos
            return new string('•', 5);
        }
        private void Dtv_Usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_Usuario.Rows[e.RowIndex];

                Txt_Usuario.Text = fila.Cells[1].Value?.ToString();
                Txt_Contrasena.Text = fila.Cells[2].Value?.ToString();
                Txt_Empleado.Text = fila.Cells[4].Value?.ToString();
                Cbx_RolUsuario.Text = fila.Cells[3].Value?.ToString();
                Cbx_Estado.Text = fila.Cells[5].Value?.ToString();
            }
        }

        private void Dtv_Usuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la columna actual es la columna de contraseña
            if (Dtv_Usuario.Columns[e.ColumnIndex].Name == "contraseña")
            {
                if (e.Value != null)
                {
                    string password = e.Value.ToString();
                    // Reemplaza la contraseña con asteriscos (*) de la misma longitud
                    e.Value = new string('•', 5);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
