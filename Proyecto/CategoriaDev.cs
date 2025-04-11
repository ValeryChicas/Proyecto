using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CategoriaDev
    {
        public int CategoriaDevId { get; set; }
        //Le cambie de CategoriaDev a nombre para no generar errores
        public string Nombre { get; set; }

        public CategoriaDev() { }
        //AGREGAR
        public CategoriaDev(string nombre)
        {
            Nombre = nombre;
        }
        //MODIFICAR
        public CategoriaDev(int categoriaDevId, string nombre)
        {
            CategoriaDevId = categoriaDevId;
            Nombre = nombre;
        }
    }
}
