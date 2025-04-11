using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Servicio() { }

        //AGREGAR
        public Servicio(string nombre, string descripcion, decimal precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        //MODIFICAR
        public Servicio(int servicioId,string nombre, string descripcion, decimal precio)
        {
            ServicioId = servicioId;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
