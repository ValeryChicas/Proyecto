using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CitaServicio
    {
        public int CitaServicioId { get; set; }
        public DateTime FechaConsulta { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public Servicio ServicioId { get; set; }
        public Mascota MascotaId { get; set; }
        public Empleado EmpleadoId { get; set; }

        public CitaServicio() { }
        //AGREGAR
        public CitaServicio(DateTime fechaConsulta, decimal precio, string descripcion, Servicio servicioId, Mascota mascotaId, Empleado empleadoId) {

            FechaConsulta = fechaConsulta;
            Precio = precio;
            Descripcion = descripcion;
            ServicioId = servicioId;
            MascotaId = mascotaId;
            EmpleadoId = empleadoId;
        }
        //MODIFICAR
        public CitaServicio(int citaServicioId, DateTime fechaConsulta, decimal precio, string descripcion, Servicio servicioId, Mascota mascotaId, Empleado empleadoId)
        {
            CitaServicioId = citaServicioId;
            FechaConsulta = fechaConsulta;
            Precio = precio;
            Descripcion = descripcion;
            ServicioId = servicioId;
            MascotaId = mascotaId;
            EmpleadoId = empleadoId;
        }

    }
}
