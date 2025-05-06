using IOGlobal.DataAccess;
using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.BusinessLogic
{
    public class ClienteBl
    {
        private static ClienteBl _instance;

        public static ClienteBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClienteBl();

                return _instance;
            }
        }

        public bool Insert(Cliente entity)
        {
            bool result = false;

            try
            {
                result = ClienteDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Cliente entity)
        {
            bool result = false;

            try
            {
                result = ClienteDal.Instance.Update(entity);
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
                result = ClienteDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Cliente> SelectAll()
        {
            List<Cliente> result = null;

            try
            {
                result = ClienteDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Cliente> SelectAllByClienteId()
        {
            List<Cliente> result = null;

            try
            {
                result = ClienteDal.Instance.SelectAllByClienteId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Cliente> SelectAllByBuscadorCl()
        {
            List<Cliente> result = null;

            try
            {
                result = ClienteDal.Instance.SelectAllByBuscadorCl();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
