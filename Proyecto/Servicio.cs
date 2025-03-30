using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public int Nombre { get; set; }
        public int Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Servicio() { }

        //AGREGAR
        public Servicio(int nombre, int descripcion, decimal precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        //MODIFICAR
        public Servicio(int servicioId,int nombre, int descripcion, decimal precio)
        {
            ServicioId = servicioId;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
