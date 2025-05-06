using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace IOGlobal.DataAccess
{
    public class Connection
    {
        //protected string _connectionString;

        //public Connection()
        //{
        //    _connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        //}
        //cadena de coneccion para la base de datos
        //Server name              //Nombre de la bd a la que se quiere conectar
        protected string _connectionString = "Data Source=LAPTOP-DM50CU2S\\SQLEXPRESS;Initial Catalog=Animalandia01;Integrated Security=True";

    }
}
