using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Cierre
    {
        public int CierreId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal SaldoVenta { get; set; }
        public decimal Sobrante { get; set; }
        public decimal Faltante { get; set; }
        public Usuario UsuarioId { get; set; }
        public Empleado EmpleadoId { get; set; }

        public Cierre() { }
        //AGREGAR
        public Cierre(DateTime fecha, decimal saldoInicial, decimal saldoFinal, decimal saldoVenta, decimal sobrante, decimal faltante, Usuario usuarioId, Empleado empleadoId)
        {
            Fecha = fecha;
            SaldoInicial = saldoInicial;
            SaldoFinal = saldoFinal;
            SaldoVenta = saldoVenta;
            Sobrante = sobrante;
            Faltante = faltante;
            UsuarioId = usuarioId;
            EmpleadoId = empleadoId;
        }
        //MODIFICAR
        public Cierre(int cierreId,DateTime fecha, decimal saldoInicial, decimal saldoFinal, decimal saldoVenta, decimal sobrante, decimal faltante, Usuario usuarioId, Empleado empleadoId)
        {
            CierreId = cierreId;
            Fecha = fecha;
            SaldoInicial = saldoInicial;
            SaldoFinal = saldoFinal;
            SaldoVenta = saldoVenta;
            Sobrante = sobrante;
            Faltante = faltante;
            UsuarioId = usuarioId;
            EmpleadoId = empleadoId;
        }

    }
}
