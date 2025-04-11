using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Mascota
    {
        //propiedades
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Peso { get; set; }
        public string Sexo { get; set; }
        public string Descripcion { get; set; }
        public string Alergias { get; set; }

        public Especie EspecieId { get; set; }
        public Raza RazaId { get; set; }
        public Cliente ClienteId { get; set; }

        //Permite constuir objetos de la clase
        //Categoria de manera predeterminada
        public Mascota() { }


        //Crear un registro (Por eso no lleva el id ya que en la bd se genera solo) Son como los procedimientos almacenados 
        public Mascota(string nombre, DateTime fechanacimiento, decimal peso, string sexo, Especie especieId, Raza razaId, Cliente clienteId, string descripcion = null, string alergias = null)
        {
            Nombre = nombre;
            FechaNacimiento = fechanacimiento;
            Peso = peso;
            Sexo = sexo;
            EspecieId = especieId;
            RazaId = razaId;
            ClienteId = clienteId;
            Descripcion = descripcion;
            Alergias = alergias;
        }


        //MODIFICAR 
        public Mascota(int mascotaId, string nombre, DateTime fechanacimiento, decimal peso, string sexo, Especie especieId, Raza razaId, Cliente clienteId, string descripcion = null, string alergias = null)
        {
            MascotaId = mascotaId;
            Nombre = nombre;
            FechaNacimiento = fechanacimiento;
            Peso = peso;
            Sexo = sexo;
            EspecieId = especieId;
            RazaId = razaId;
            ClienteId = clienteId;
            Descripcion = descripcion;
            Alergias = alergias;
        }
    }
}
