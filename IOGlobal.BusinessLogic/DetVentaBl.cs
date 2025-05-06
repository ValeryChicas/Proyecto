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
    public class DetVentaBl
    {
        private static DetVentaBl _instance;

        public static DetVentaBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DetVentaBl();

                return _instance;
            }
        }

        public bool Insert(DetVenta entity)
        {
            bool result = false;

            try
            {
                result = DetalleVentaDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(DetVenta entity)
        {
            bool result = false;

            try
            {
                result = DetalleVentaDal.Instance.Update(entity);
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
                result = DetalleVentaDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<DetVenta> SelectAll()
        {
            List<DetVenta> result = null;

            try
            {
                result = DetalleVentaDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<DetVenta> SelectAllByDetVentaId()
        {
            List<DetVenta> result = null;

            try
            {
                result = DetalleVentaDal.Instance.SelectAllByDetVentaId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
