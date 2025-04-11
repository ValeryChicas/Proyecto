using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Especie
    {
        public int EspecieId { get; set; }
        public string Nombre { get; set; }
        public Estado EstadoId { get; set; }

        //Permite constuir objetos de la clase
        //Categoria de manera predeterminada
        public Especie() { }


        //Crear un registro (Por eso no lleva el id ya que en la bd se genera solo) Son como los procedimientos almacenados 
        public Especie(string nombre, Estado estadoId)
        {

            Nombre = nombre;
            EstadoId = estadoId;
        }


        //MODIFICAR
        public Especie(int especieId, string nombre, Estado estadoId)
        {
            EspecieId = especieId;
            Nombre = nombre;
            EstadoId = estadoId;
        }

    }

}
