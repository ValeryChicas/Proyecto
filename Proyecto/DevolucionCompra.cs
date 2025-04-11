using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class DevolucionCompra
    {
        public int DevolucionId { get; set; }
        public DateTime Fecha { get; set; }
        public DetCompra DetCompraId { get; set; }
        public int Cantidad { get; set; }
        public Usuario UsuarioId { get; set; }
        public CategoriaDev CategoriaDevId { get; set; }
        public DevolucionCompra() { }
        //AGREGAR
        public DevolucionCompra(DateTime fecha, DetCompra detCompraId, int cantidad, Usuario usuarioId, CategoriaDev categoriaDevId)
        {
            Fecha = fecha;
            DetCompraId = detCompraId;
            Cantidad = cantidad;
            UsuarioId = usuarioId;
            CategoriaDevId = categoriaDevId;
        }
        //MODIFICAR
        public DevolucionCompra( int devolucionId, DateTime fecha, DetCompra detCompraId, int cantidad, Usuario usuarioId, CategoriaDev categoriaDevId)
        {
            DevolucionId = devolucionId;
            Fecha = fecha;
            DetCompraId = detCompraId;
            Cantidad = cantidad;
            UsuarioId = usuarioId;
            CategoriaDevId = categoriaDevId;
        }
    }
}
