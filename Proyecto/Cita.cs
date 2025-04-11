using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Cita
    {
        public int CitaId { get; set;}
        public DateTime FechaCita { get; set; }
        public DateTime FechaReprogramada { get; set; }
        public bool Recordatorio { get; set; }
        public decimal Peso { get; set; }
        public decimal Precio { get; set; }
        public Mascota MascotaId { get; set; }
        public Empleado EmpleadoId { get; set; }

        public Estado EstadoId { get; set; }

        public Usuario UsuarioId { get; set; }

        public Cita() { }
        //AGREGAR
        public Cita(DateTime fechaCita, DateTime fechaReprogramada, bool recordadotio, decimal peso, decimal precio, Mascota mascotaId, Empleado empleadoId, Estado estadoId, Usuario usuarioId) 
        {
            FechaCita = fechaCita;
            FechaReprogramada = fechaReprogramada;
            Recordatorio = recordadotio;
            Peso = peso;
            Precio = precio;
            MascotaId = mascotaId;
            EmpleadoId = empleadoId;
            EstadoId = estadoId;
            UsuarioId = usuarioId;
        }

        //MODIFICAR
        public Cita(int citaId, DateTime fechaCita, DateTime fechaReprogramada, bool recordadotio, decimal peso, decimal precio, Mascota mascotaId, Empleado empleadoId, Estado estadoId, Usuario usuarioId)
        {
            CitaId = citaId;
            FechaCita = fechaCita;
            FechaReprogramada = fechaReprogramada;
            Recordatorio = recordadotio;
            Peso = peso;
            Precio = precio;
            MascotaId = mascotaId;
            EmpleadoId = empleadoId;
            EstadoId = estadoId;
            UsuarioId = usuarioId;
        }


    }
}
