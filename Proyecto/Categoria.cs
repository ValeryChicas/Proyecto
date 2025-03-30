using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }

        public Categoria() { }

        //AGREGAR
        public Categoria(string nombre) {

            Nombre = nombre;
        }
        //MODIFICAR
        public Categoria(int categoriaId, string nombre) {

            CategoriaId = categoriaId;
            Nombre = nombre;
        }


    }
}
