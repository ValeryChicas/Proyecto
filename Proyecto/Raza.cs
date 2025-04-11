using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Raza
    {
        public int RazaId { get; set; }

        public string Nombre { get; set; }
        public Estado EstadoId { get; set; }

        //Permite constuir objetos de la clase
        //Categoria de manera predeterminada
        public Raza() { }


        //Crear un registro (Por eso no lleva el id ya que en la bd se genera solo) Son como los procedimientos almacenados 
        public Raza(string nombre, Estado estadoId)
        {
            Nombre = nombre;
            EstadoId = estadoId;
        }


        //Modificar
        public Raza(int razaId, string nombre, Estado estadoId)
        {
            RazaId = razaId;
            Nombre = nombre;
            EstadoId = estadoId;
        }
    }
}
