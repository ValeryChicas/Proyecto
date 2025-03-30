using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Estado
    {
        public int EstadoId { get; set; }

        public string Nombre { get; set; }
    

        //Permite constuir objetos de la clase
        //Categoria de manera predeterminada
        public Estado() { }


        //Crear un registro (Por eso no lleva el id ya que en la bd se genera solo) Son como los procedimientos almacenados 
        public Estado(string nombre)
        {

            Nombre = nombre;
        }


        //MODIFICAR
        public Estado(int estadoId, string nombre)
        {
            EstadoId = estadoId;
            Nombre = nombre;
        }
    }
}
