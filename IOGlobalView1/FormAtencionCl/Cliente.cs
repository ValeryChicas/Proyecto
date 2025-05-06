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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
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
            var cliente = ClienteBl.Instance.SelectAll();

            var data = cliente.Select(c => new
            {
                c.ClienteId,
                Nombre = c.Nombre,
                Apellidos = c.Apellido,
                Telefono = c.Telefono,
                Direccion = c.Direccion,
                Correo = c.CorreoElectronico,
                Estado = c.EstadoId.Nombre,

            }).ToList();

            Dtv_Clientes.DataSource = data;
        }

        private void Dtv_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dtv_Clientes.Rows[e.RowIndex];

                Txt_Nombres.Text = fila.Cells[1].Value?.ToString();
                Txt_Apellidos.Text = fila.Cells[2].Value?.ToString();
                Txt_Telefono.Text = fila.Cells[3].Value?.ToString();
                Txt_Direccion.Text = fila.Cells[4].Value?.ToString();
                Txt_CorreoElectronico.Text = fila.Cells[5].Value?.ToString();
                Cbx_Estado.Text = fila.Cells[6].Value?.ToString();
            }
        }
    }
}
