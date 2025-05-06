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
    public partial class Menu : Form
    {
        //variable
        //private static Usuario usuarioActual;
        private Form formularioActual;
        public Menu (/*Usuario objusuario*/)
        {
            InitializeComponent();
            //usuarioActual = objusuario;
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
        private void Btn_Empleado_Click(object sender, EventArgs e)
        {
            //AbrirForms(new Empleado.Empleado_form_principal());
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAdministracion.Usuario());
        }

        private void Btn_Cliente_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAtencionCl.Cliente());
        }

        private void Btn_Mascotas_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAtencionCl.Mascota());
        }

        private void Btn_Citas_Click(object sender, EventArgs e)
        {
            AbrirForms(new ServiciosYCitas.Cita());
        }

        private void Btn_Servicios_Click(object sender, EventArgs e)
        {
            AbrirForms(new ServiciosYCitas.Servicio());
        }

        private void Btn_CitaServicios_Click(object sender, EventArgs e)
        {
            AbrirForms(new ServiciosYCitas.CitaServicio());
        }

        private void Btn_CategoriaProd_Click(object sender, EventArgs e)
        {
            AbrirForms(new Inventario.Categoria());
        }

        private void Btn_Productos_Click(object sender, EventArgs e)
        {
            AbrirForms(new Inventario.Producto());
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            AbrirForms(new Inventario.Inventario());
        }

        private void Btn_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormCompra.Proveedores());
        }

        private void Btn_Compras_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormCompra.Compra());
        }

        private void VentaProductos_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormVenta.Venta());
        }

        private void Btn_DevolucionCompra_Click(object sender, EventArgs e)
        {
            AbrirForms(new Devoluciones.DevolucionCompra());
        }

        private void Btn_DevolucionVenta_Click(object sender, EventArgs e)
        {
            AbrirForms(new Devoluciones.Devolucionventa());
        }

        private void Btn_CierreCaja_Click(object sender, EventArgs e)
        {
            AbrirForms(new Devoluciones.CierreCaja());
        }

        private void Img_Click(object sender, EventArgs e)
        {
            Pnl_escritorio.Controls.Clear();
        }

        private void Btn_Especie_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAtencionCl.Especie());
        }

        private void Btn_Raza_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAtencionCl.Raza());
        }

        private void Btn_HistorialMedico_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAtencionCl.HistorialMedico());
        }

        private void Btn_CargoEmpleado_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAdministracion.Cargo());
        }

        private void Btn_RolUsuario_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormAdministracion.Rol());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
