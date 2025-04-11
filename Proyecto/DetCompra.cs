using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class DetCompra
    {
        public int DetCompraId { get; set; }
        public int CantidadCompra { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Compra CompraId { get; set; }
        public Producto ProductoId { get; set; }

        public DetCompra() { }

        //AGREGAR
        public DetCompra(int cantidadCompra, decimal precioUnitario, Compra compraId, Producto productoId)
        {
            CantidadCompra = cantidadCompra;
            PrecioUnitario = precioUnitario;
            CompraId = compraId;
            ProductoId = productoId;
        }

        //MODIFICAR
        public DetCompra(int detCompraId,int cantidadCompra, decimal precioUnitario, Compra compraId, Producto productoId)
        {
            DetCompraId = detCompraId;
            CantidadCompra = cantidadCompra;
            PrecioUnitario = precioUnitario;
            CompraId = compraId;
            ProductoId = productoId;
        }
    }
}
