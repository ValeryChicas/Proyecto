using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public Estado EstadoId { get; set; }

        //Permite constuir objetos de la clase
        //Categoria de manera predeterminada
        public Cliente() { }


        //Crear un registro (Por eso no lleva el id ya que en la bd se genera solo) Son como los procedimientos almacenados 
        public Cliente(string nombre, string apellido, string telefono, string direccion, string correoelectronico,Estado estadoId)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
            CorreoElectronico = correoelectronico;
            EstadoId = estadoId;
        }


        //Modificar 
        public Cliente(int clienteId, string nombre, string apellido, string telefono, string direccion, string correoelectronico, Estado estadoId)
        {
            ClienteId = clienteId;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
            CorreoElectronico = correoelectronico;
            EstadoId = estadoId;
        }
    }
}
