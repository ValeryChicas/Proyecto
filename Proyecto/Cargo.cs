using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string Nombre { get; set; }

        //Permite constuir objetos de la clase
        //Categoria de manera predeterminada
        public Cargo() { }


        //Crear un registro (Por eso no lleva el id ya que en la bd se genera solo) Son como los procedimientos almacenados 
        public Cargo(string nombre)
        {
            Nombre = nombre;
        }
        //Modificar 
        public Cargo(int cargoId, string nombre)
        {
            CargoId = cargoId;
            Nombre = nombre;
        }
    }
}
