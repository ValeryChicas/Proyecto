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
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }
         private void Cargo_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var cargo = CargoBl.Instance.SelectAll();

            var data = cargo.Select(c => new
            {
                c.CargoId,
                Nombre = c.Nombre,

            }).ToList();

            Dtv_CargoEmpleado.DataSource = data;
        }

        private void Dtv_CargoEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_CargoEmpleado.Rows[e.RowIndex];

                Txt_Cargo.Text = fila.Cells[1].Value?.ToString();
            }
        }
    }
}
