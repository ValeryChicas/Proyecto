using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public Empleado EmpleadoId { get; set; }
        public RolUsuario RolusuarioId { get; set; }
        public Estado EstadoId { get; set; }

        public Usuario() { }

        //AGREGAR
        public Usuario(string nombre, string contrasena, Empleado empleadoId, RolUsuario rolusuarioId, Estado estadoId)
        {
            Nombre = nombre;
            Contrasena = contrasena;
            EmpleadoId = empleadoId;
            RolusuarioId = rolusuarioId;
            EstadoId = estadoId;
        }

        //MODIFICAR
        public Usuario(int usuarioId, string nombre, string contrasena, Empleado empleadoId, RolUsuario rolusuarioId, Estado estadoId)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Contrasena = contrasena;
            EmpleadoId = empleadoId;
            RolusuarioId = rolusuarioId;
            EstadoId = estadoId;
        }
    }
}
