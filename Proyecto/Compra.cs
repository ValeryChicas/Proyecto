using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Total { get; set; }
        public Proveedor ProveedorId { get; set; }
        public Estado EstadoId { get; set; }
        
        public Compra() { }
        
        //AGREGAR
        public Compra(DateTime fechaCompra, decimal total, Proveedor proveedorId, Estado estadoId)
        {
            FechaCompra = fechaCompra;
            Total = total;
            ProveedorId = proveedorId;
            EstadoId = estadoId;
        }
        //MODIFICAR
        public Compra(int compraId, DateTime fechaCompra, decimal total, Proveedor proveedorId, Estado estadoId)
        {
            CompraId = compraId;
            FechaCompra = fechaCompra;
            Total = total;
            ProveedorId = proveedorId;
            EstadoId = estadoId;
        }
    }
}
