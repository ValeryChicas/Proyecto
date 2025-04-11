using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class RolUsuario
    {
        public int RolUsuarioId { get; set; }
        public string Nombre { get; set; }

        public RolUsuario() { }

        //AGREGAR
        public RolUsuario(string nombre)
        {
            Nombre = nombre;
        }
        //MODIFICAR
        public RolUsuario(int rolUsuarioId, string nombre)
        {
            RolUsuarioId = rolUsuarioId;
            Nombre = nombre;
        }
    }
}
