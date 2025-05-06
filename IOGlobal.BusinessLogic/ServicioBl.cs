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
    public class ServicioBl
    {
        private static ServicioBl _instance;

        public static ServicioBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ServicioBl();

                return _instance;
            }
        }

        public bool Insert(Servicio entity)
        {
            bool result = false;

            try
            {
                result = ServicioDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Servicio entity)
        {
            bool result = false;

            try
            {
                result = ServicioDal.Instance.Update(entity);
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
                result = ServicioDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Servicio> SelectAll()
        {
            List<Servicio> result = null;

            try
            {
                result = ServicioDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Servicio> SelectAllByServicioId()
        {
            List<Servicio> result = null;

            try
            {
                result = ServicioDal.Instance.SelectAllByServicioId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
