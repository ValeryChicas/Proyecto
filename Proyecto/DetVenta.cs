using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class DetVenta
    {
        public int DetVentaId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public Venta VentaId { get; set; }
        public Producto ProductoId { get; set; }
        public CitaServicio CitaServicioId { get; set; } 
        public Cita CitaId { get; set; }


        public DetVenta() { }

        //AGREGAR
        public DetVenta(Venta ventaId, Producto productoId, int cantidad, decimal precioVenta)
        {
            VentaId = ventaId;
            ProductoId = productoId;
            Cantidad = cantidad;
            PrecioVenta = precioVenta;
        }

        //MODIFICAR
        public DetVenta(int detVentaId, Venta ventaId, Producto productoId, int cantidad, decimal precioVenta)
        {
            DetVentaId = detVentaId;
            VentaId = ventaId;
            ProductoId = productoId;
            Cantidad = cantidad;
            PrecioVenta = precioVenta;
        }
    }
}
