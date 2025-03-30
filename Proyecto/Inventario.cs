using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Inventario
    {
        public int InventarioId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Stock { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Producto ProductoId { get; set; }

        public Inventario() { }

        //AGREGAR
        public Inventario(DateTime fechaIngreso, int stock, DateTime fechaVencimiento, Producto productoId)
        {
            FechaIngreso = fechaIngreso;
            Stock = stock;
            FechaVencimiento = fechaVencimiento;
            ProductoId = productoId;
        }

        //MODIFICAR
        public Inventario(int inventarioId,DateTime fechaIngreso, int stock, DateTime fechaVencimiento, Producto productoId)
        {
            InventarioId = inventarioId;
            FechaIngreso = fechaIngreso;
            Stock = stock;
            FechaVencimiento = fechaVencimiento;
            ProductoId = productoId;
        }
    }
}
