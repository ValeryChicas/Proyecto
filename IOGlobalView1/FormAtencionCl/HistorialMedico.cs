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
    public partial class HistorialMedico : Form
    {
        public HistorialMedico()
        {
            InitializeComponent();
        }


        private void HistorialMedico_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var historialmascota = HistorialMedicoBl.Instance.SelectAll();

            var data = historialmascota.Select(c => new
            {
                c.HistorialMedicoId,
                Mascota = c.MascotaId.Nombre,
                Fecha = c.Fecha,
                Diagnostico = c.Diagnostico,
                Tratamiento = c.Tratamiento,
                Observaciones = c.Observaciones,

            }).ToList();

            Dtv_HistorialMedico.DataSource = data;
        }

        private void Dtv_HistorialMedico_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_HistorialMedico.Rows[e.RowIndex];

                Txt_Mascota.Text = fila.Cells[1].Value?.ToString();
                Dtp_Fecha.Text = fila.Cells[2].Value?.ToString();
                Txt_Diagnostico.Text = fila.Cells[3].Value?.ToString();
                Txt_Tratamiento.Text = fila.Cells[4].Value?.ToString();
                Txt_Observaciones.Text = fila.Cells[5].Value?.ToString();
            }
        }

        private void Btn_BuscarMascotas_Click(object sender, EventArgs e)
        {
            BuscadorMascotas buscarcl = new BuscadorMascotas();
            buscarcl.ShowDialog();
        }
    }
}
