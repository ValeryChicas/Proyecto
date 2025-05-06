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
    public class VentaBl
    {
        private static VentaBl _instance;

        public static VentaBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VentaBl();

                return _instance;
            }
        }

        public bool Insert(Venta entity)
        {
            bool result = false;

            try
            {
                result = VentaDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Venta entity)
        {
            bool result = false;

            try
            {
                result = VentaDal.Instance.Update(entity);
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
                result = VentaDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Venta> SelectAll()
        {
            List<Venta> result = null;

            try
            {
                result = VentaDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Venta> SelectAllByVentaId()
        {
            List<Venta> result = null;

            try
            {
                result = VentaDal.Instance.SelectAllByVentaId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
