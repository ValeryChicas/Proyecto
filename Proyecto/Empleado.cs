using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dui { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
        public string GradoAcademico { get; set; }
        public Cargo CargoId { get; set; }
        public Estado EstadoId { get; set; }

        public Empleado() { }

        //AGREGAR
        public Empleado(string nombre, string apellido, string telefono, DateTime fechaNacimiento, string dui, string direccion, string genero, string gradoAcademico, Cargo cargoId, Estado estadoId)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Dui = dui;
            Direccion = direccion;
            Genero = genero;
            GradoAcademico = gradoAcademico;
            CargoId = cargoId;
            EstadoId = estadoId;
        }

        //MODIFICAR
        public Empleado(int empleadoId, string nombre, string apellido, string telefono, DateTime fechaNacimiento, string dui, string direccion, string genero, string gradoAcademico, Cargo cargoId, Estado estadoId)
        {
            EmpleadoId = empleadoId;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Dui = dui;
            Direccion = direccion;
            Genero = genero;
            GradoAcademico = gradoAcademico;
            CargoId = cargoId;
            EstadoId = estadoId;
        }
    }
}
