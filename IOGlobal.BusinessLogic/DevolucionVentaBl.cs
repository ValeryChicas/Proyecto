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
    public class DevolucionVentaBl
    {
        private static DevolucionVentaBl _instance;

        public static DevolucionVentaBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DevolucionVentaBl();

                return _instance;
            }
        }

        public bool Insert(DevolucionVenta entity)
        {
            bool result = false;

            try
            {
                result = DevolucionVentaDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(DevolucionVenta entity)
        {
            bool result = false;

            try
            {
                result = DevolucionVentaDal.Instance.Update(entity);
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
                result = DevolucionVentaDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<DevolucionVenta> SelectAll()
        {
            List<DevolucionVenta> result = null;

            try
            {
                result = DevolucionVentaDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<DevolucionVenta> SelectAllByDevolucionVentaId()
        {
            List<DevolucionVenta> result = null;

            try
            {
                result = DevolucionVentaDal.Instance.SelectAllByDevolucionVentaId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
