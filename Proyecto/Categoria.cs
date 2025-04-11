using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public Estado EstadoId { get; set; }

        public Categoria() { }

        //AGREGAR
        public Categoria(string nombre, Estado estadoId)
        {

            Nombre = nombre;
            EstadoId = estadoId;
        }
        //MODIFICAR
        public Categoria(int categoriaId, string nombre, Estado estadoId) {

            CategoriaId = categoriaId;
            Nombre = nombre;
            EstadoId = estadoId;
        }


    }
}
