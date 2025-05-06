using IOGlobal.DataAccess;
using IOGlobal.DataAccess.IOGlobal.DataAccess;
using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.BusinessLogic
{
    public class EmpleadoBl
    {
        private static EmpleadoBl _instance;

        public static EmpleadoBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmpleadoBl();

                return _instance;
            }
        }

        public bool Insert(Empleado entity)
        {
            bool result = false;

            try
            {
                result = EmpleadoDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Empleado entity)
        {
            bool result = false;

            try
            {
                result = EmpleadoDal.Instance.Update(entity);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;

        }

        public bool Delete(int id)
        {
            bool result = false;

            try
            {
                result = EmpleadoDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Empleado> SelectAll()
        {
            List<Empleado> result = null;

            try
            {
                result = EmpleadoDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Empleado> SelectAllByEmpleadoId()
        {
            List<Empleado> result = null;

            try
            {
                result = EmpleadoDal.Instance.SelectAllByEmpleadoId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
