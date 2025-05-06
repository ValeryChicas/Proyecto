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
    public partial class BuscadorMascotas : Form
    {
        public BuscadorMascotas()
        {
            InitializeComponent();
        }

        private void BuscadorMascotas_Load(object sender, EventArgs e)
        {

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
    }
}
