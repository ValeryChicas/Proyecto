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

namespace IOGlobalView1.FormAtencionCl
{
    public partial class Mascota : Form
    {
        public Mascota()
        {
            InitializeComponent();
        }
        private void CargarEspecies()
        {
            var especies = EspecieBl.Instance.SelectAll();

            Cbx_Especie.DataSource = especies;
            Cbx_Especie.DisplayMember = "Nombre";
            Cbx_Especie.ValueMember = "EstadoId";
            Cbx_Especie.SelectedIndex = -1;
        }
        private void CargarRazas()
        {
            var raza = RazaBl.Instance.SelectAll();

            Cbx_Raza.DataSource = raza;
            Cbx_Raza.DisplayMember = "Nombre";
            Cbx_Raza.ValueMember = "EstadoId";
            Cbx_Raza.SelectedIndex = -1;
        }
        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var mascotas = MascotaBl.Instance.SelectAll();

            var data = mascotas.Select(c => new
            {
                c.MascotaId,
                Mascota = c.Nombre,
                NombreCompleto = c.ClienteId.NombreCompleto,
                FechaNacimiento = c.FechaNacimiento,
                Sexo = c.Sexo,
                Peso = c.Peso,
                Alergias = c.Alergias,
                Descripcion = c.Descripcion,
                Especie = c.EspecieId.Nombre,
                Raza = c.RazaId.Nombre,


            }).ToList();

            Dtv_Mascotas.DataSource = data;
        }
        private void Mascota_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            CargarEspecies();
            CargarRazas();
        }

        private void Dtv_Mascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_Mascotas.Rows[e.RowIndex];

                Txt_Mascota.Text = fila.Cells[1].Value?.ToString();
                Txt_Cliente.Text = fila.Cells[2].Value?.ToString();
                Dtp_FechaNacimiento.Text = fila.Cells[3].Value?.ToString();
                Cbx_Sexo.Text = fila.Cells[4].Value?.ToString();
                Txt_Peso.Text = fila.Cells[5].Value?.ToString();
                Txt_Alergias.Text = fila.Cells[6].Value?.ToString();
                Txt_Descripcion.Text = fila.Cells[7].Value?.ToString();
                Cbx_Especie.Text = fila.Cells[8].Value?.ToString();
                Cbx_Raza.Text = fila.Cells[9].Value?.ToString();
            }
        }

        private void Btn_BuscarClientes_Click(object sender, EventArgs e)
        {
            BuscadorClientes buscarcl = new BuscadorClientes();
            buscarcl.ShowDialog();

            
        }

        private void Txt_Cliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
