using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int StockMinimo { get; set; }
        public Categoria CategoriaId { get; set; }
        public Estado EstadoId { get; set; }
        public Usuario UsuarioId { get; set; }

        public Producto() { }

        //AGREGAR
        public Producto(string nombre,string descipcion, decimal precio, int stockMinimo, Categoria categoriaId, Estado estadoId, Usuario usuarioId)
        {
            Nombre = nombre;
            Descripcion = descipcion;
            Precio = precio;
            StockMinimo = stockMinimo;
            CategoriaId = categoriaId;
            EstadoId = estadoId;
            UsuarioId = usuarioId;
        }

        //MODIFICAR
        public Producto(int productoId, string nombre, string descipcion, decimal precio, int stockMinimo, Categoria categoriaId, Estado estadoId, Usuario usuarioId)
        {
            ProductoId = productoId;
            Nombre = nombre;
            Descripcion = descipcion;
            Precio = precio;
            StockMinimo = stockMinimo;
            CategoriaId = categoriaId;
            EstadoId = estadoId;
            UsuarioId = usuarioId;
        }
    }
}
