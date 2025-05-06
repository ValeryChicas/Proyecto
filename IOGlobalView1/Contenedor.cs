using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOGlobalView1
{
    public partial class Contenedor : Form
    {
        private Form formularioActual;
        private static Usuario usuarioActual;
        public Contenedor(Usuario objusuario)
        {
            InitializeComponent();
            usuarioActual = objusuario;
        }
        //Abrir formularios al dar click
        private void AbrirForms(Form formularioSegundario)
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
            }

            formularioActual = formularioSegundario;
            formularioSegundario.TopLevel = false;
            formularioSegundario.FormBorderStyle = FormBorderStyle.None;
            formularioSegundario.Dock = DockStyle.Fill;
            Pnl_escritorio.Controls.Add(formularioSegundario);
            Pnl_escritorio.Tag = formularioSegundario;
            Pnl_escritorio.BringToFront();
            formularioSegundario.Show();
        }

        private void Btn_Cliente_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAtencionCl.Cliente());
        }

        private void Btn_Mascotas_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAtencionCl.Mascota());
        }

        private void Btn_HistorialMedico_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAtencionCl.HistorialMedico());
        }

        private void Btn_CitaServicios_Click(object sender, EventArgs e)
        {
            AbrirForms(new ServiciosYCitas.CitaServicio());
        }

        private void Btn_Citas_Click(object sender, EventArgs e)
        {
            AbrirForms(new ServiciosYCitas.Cita());
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            AbrirForms(new Inventario.Inventario());
        }

        private void VentaProductos_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormVenta.Venta());
        }

        private void Btn_DevolucionVenta_Click(object sender, EventArgs e)
        {
            AbrirForms(new Devoluciones.Devolucionventa());
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {

        }
    }
}
