using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Mascota
    {
        //propiedades
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Peso { get; set; }
        public string Sexo { get; set; }

        //Permite constuir objetos de la clase
        //Categoria de manera predeterminada
        public Mascota() { }


        //Crear un registro (Por eso no lleva el id ya que en la bd se genera solo) Son como los procedimientos almacenados 
        public Mascota(string nombre, DateTime fechanacimiento, decimal peso, string sexo) {

            Nombre = nombre;
            FechaNacimiento = fechanacimiento;
            Peso = peso;
            Sexo = sexo;
        }


        //MODIFICAR 
        public Mascota(int  mascotaId,string nombre, DateTime fechanacimiento, decimal peso, string sexo)
        {
            MascotaId = mascotaId;
            Nombre = nombre;
            FechaNacimiento = fechanacimiento;
            Peso = peso;
            Sexo = sexo;
        }


    }
}
