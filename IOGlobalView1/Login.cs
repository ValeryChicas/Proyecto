using IOGlobal.BusinessLogic;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            Txt_Usuario.Text = "";
            Txt_Contrasena.Text = "";
            this.Show();
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
            form.FormClosing += FrmClosing;

            //if (string.IsNullOrEmpty(Txt_Usuario.Text) || string.IsNullOrEmpty(Txt_Contrasena.Text))
            //{
            //    MessageBox.Show("Por favor, complete todos los campos para iniciar sesion.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //try
            //{
            //    // Fix for CS0029 and CS1662: Ensure proper filtering based on EstadoId.Nombre or EstadoId.EstadoId
            //    List<Usuario> usuariosActivos = new UsuarioBl().SelectAll()
            //        .Where(u => u.EstadoId != null && u.EstadoId.Nombre == "Activo" &&
            //                u.RolusuarioId.Nombre == "Administrador") // Adjust condition as per your logic
            //        .ToList();

            //    List<Usuario> usuarios = new UsuarioBl().SelectAll();

            //    Usuario aceder = usuarios.FirstOrDefault(u => u.Nombre == Txt_Usuario.Text);

            //    if (aceder != null)
            //    {
            //        if (aceder.Contrasena == Txt_Contrasena.Text && aceder.Nombre == Txt_Usuario.Text)
            //        {
            //            if (aceder.EstadoId != null && aceder.EstadoId.Nombre == "Activo")
            //            {
            //                Menu form = new Menu(aceder);
            //                form.Show();
            //                this.Hide();
            //                form.FormClosing += FrmClosing;
            //            }
            //            else
            //            {
            //                MessageBox.Show("Lo sentimos su usuario esta inactivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //            }
            //        }
            //        else
            //        {
            //            errorProvider1.SetError(Txt_Contrasena, "Su contraseña es incorrecta");
            //            MessageBox.Show("Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            errorProvider1.Clear();
            //        }
            //    }
            //    else
            //    {
            //        errorProvider1.SetError(Txt_Usuario, "No existe el usuario con el que desea ingresar");
            //        MessageBox.Show("Este usuario no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        errorProvider1.Clear();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Error al iniciar sesion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Btn_MostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (Btn_MostrarContrasena.Checked)
            {
                Txt_Contrasena.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_Contrasena.UseSystemPasswordChar = true;
            }
        }
    }
}
