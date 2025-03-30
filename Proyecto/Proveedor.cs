using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Proveedor() { }

        //AGREGAR
        public Proveedor(string nombre, string telefono, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }

        //MODIFICAR
        public Proveedor(int proveedorId, string nombre, string telefono, string direccion)
        {
            ProveedorId = proveedorId;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
