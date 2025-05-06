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
    public partial class Especie : Form
    {
        public Especie()
        {
            InitializeComponent();
        }

        private void Especie_Load(object sender, EventArgs e)
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
            var especie = EspecieBl.Instance.SelectAll();

            var data = especie.Select(c => new
            {
                c.EspecieId,
                Nombre = c.Nombre,
                Estado = c.EstadoId.Nombre,

            }).ToList();

            Dtv_Especie.DataSource = data;
        }

        private void Dtv_Especie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_Especie.Rows[e.RowIndex];

                Txt_Nombre.Text = fila.Cells[1].Value?.ToString();
                Cbx_Estado.Text = fila.Cells[2].Value?.ToString();
            }
        }
    }
}
