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
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
        }

        private void Rol_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var rol = RolUsuarioBl.Instance.SelectAll();

            var data = rol.Select(c => new
            {
                c.RolUsuarioId,
                Nombre = c.Nombre,

            }).ToList();

            Dtv_RolUsuario.DataSource = data;
        }

        private void Dtv_RolUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_RolUsuario.Rows[e.RowIndex];

                Txt_Rol.Text = fila.Cells[1].Value?.ToString();
            }
        }
    }
}
