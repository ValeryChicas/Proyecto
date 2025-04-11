using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }

        public  DateTime FechaVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public Estado EstadoId { get; set; }
        public Usuario UsuarioId { get; set; }
        public Cliente ClienteId { get; set; }

        public Venta() { }

        //Agregar
        public Venta(DateTime fechaVenta, decimal totalVenta, Estado estadoId, Usuario usuarioId, Cliente clienteId)
        {
            FechaVenta = fechaVenta;
            TotalVenta = totalVenta;
            EstadoId = estadoId;
            UsuarioId = usuarioId;
            ClienteId = clienteId;
        }

        //MODIFICAR
        public Venta(int ventaId, DateTime fechaVenta, decimal totalVenta, Estado estadoId, Usuario usuarioId, Cliente clienteId)
        {
            VentaId = ventaId;
            FechaVenta = fechaVenta;
            TotalVenta = totalVenta;
            EstadoId = estadoId;
            UsuarioId = usuarioId;
            ClienteId = clienteId;
        }
    }
}
