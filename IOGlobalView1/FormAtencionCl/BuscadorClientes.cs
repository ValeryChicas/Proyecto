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
    public partial class BuscadorClientes : Form
    {
        public BuscadorClientes()
        {
            InitializeComponent();
        }

        private void BuscadorClientes_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            //Para que no se muestre la info asi como esta en las capa entities
            //Para que estadoId no salga asi y salga el nombre
            var cliente = ClienteBl.Instance.SelectAllByBuscadorCl();

            var data = cliente.Select(c => new
            {
                c.ClienteId,
                NombreCompleto = c.NombreCompleto,
                Telefono = c.Telefono,
                Direccion = c.Direccion,
                Correo = c.CorreoElectronico,

            }).ToList();

            Dtv_Clientes.DataSource = data;
        }
        private void Txt_Buscador_TextChanged(object sender, EventArgs e)
        {
           
        }   
    }
}
