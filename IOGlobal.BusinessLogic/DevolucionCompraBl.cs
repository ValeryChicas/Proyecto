using IOGlobal.DataAccess;
using IOGlobal.Entities;
using Proyecto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.BusinessLogic
{
    public class DevolucionCompraBl
    {
        private static DevolucionCompraBl _instance;

        public static DevolucionCompraBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DevolucionCompraBl();

                return _instance;
            }
        }

        public bool Insert(DevolucionCompra entity)
        {
            bool result = false;

            try
            {
                result = DevolucionCompraDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(DevolucionCompra entity)
        {
            bool result = false;

            try
            {
                result = DevolucionCompraDal.Instance.Update(entity);
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
                result = DevolucionCompraDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<DevolucionCompra> SelectAll()
        {
            List<DevolucionCompra> result = null;

            try
            {
                result = DevolucionCompraDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<DevolucionCompra> SelectAllByDevolucionId()
        {
            List<DevolucionCompra> result = null;

            try
            {
                result = DevolucionCompraDal.Instance.SelectAllByDevolucionId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
