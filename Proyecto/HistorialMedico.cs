using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class HistorialMedico
    {
        public int HistorialMedicoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
        public Mascota MascotaId { get; set; }

        public HistorialMedico() { }

        //AGREGAR 
        public HistorialMedico(DateTime fecha, string diagnostico, string tratamiento, string observaciones, Mascota mascotaId)
        {
            Fecha = fecha;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            Observaciones = observaciones;
            MascotaId = mascotaId;
        }

        //MODIFICAR
        public HistorialMedico(int historialMedicoId,DateTime fecha, string diagnostico, string tratamiento, string observaciones, Mascota mascotaId)
        {
            HistorialMedicoId = historialMedicoId;
            Fecha = fecha;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            Observaciones = observaciones;
            MascotaId = mascotaId;
        }
    }
}
