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
    public class ProveedorBl
    {
        private static ProveedorBl _instance;

        public static ProveedorBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProveedorBl();

                return _instance;
            }
        }

        public bool Insert(Proveedor entity)
        {
            bool result = false;

            try
            {
                result = ProveedorDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Proveedor entity)
        {
            bool result = false;

            try
            {
                result = ProveedorDal.Instance.Update(entity);
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
                result = ProveedorDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Proveedor> SelectAll()
        {
            List<Proveedor> result = null;

            try
            {
                result = ProveedorDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Proveedor> SelectAllByProveedorId()
        {
            List<Proveedor> result = null;

            try
            {
                result = ProveedorDal.Instance.SelectAllByProveedorId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
