using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class DevolucionVenta
    {
        public int DevolucionId { get; set; }
        public DateTime Fecha { get; set; }
        public DetVenta DetVentaId { get; set; }
        public int Cantidad { get; set; }
        public Usuario UsuarioId { get; set; }
        public CategoriaDev CategoriaDevId { get; set; }

        public DevolucionVenta() { }
        //AGREGAR
        public DevolucionVenta(DateTime fecha, DetVenta detVentaId, int cantidad, Usuario usuarioId, CategoriaDev categoriaDevId)
        {
            Fecha = fecha;
            DetVentaId = detVentaId;
            Cantidad = cantidad;
            UsuarioId = usuarioId;
            CategoriaDevId = categoriaDevId;
        }
        //MODIFICAR
        public DevolucionVenta(int devolucionId, DateTime fecha, DetVenta detVentaId, int cantidad, Usuario usuarioId, CategoriaDev categoriaDevId)
        {
            DevolucionId = devolucionId;
            Fecha = fecha;
            DetVentaId = detVentaId;
            Cantidad = cantidad;
            UsuarioId = usuarioId;
            CategoriaDevId = categoriaDevId;
        }
    }
}
