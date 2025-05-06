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
    public class EstadoBl
    {
        private static EstadoBl _instance;

        public static EstadoBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoBl();

                return _instance;
            }
        }
        public bool Insert(Estado entity)
        {
            bool result = false;

            try
            {
                result = EstadoDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Estado entity)
        {
            bool result = false;

            try
            {
                result = EstadoDal.Instance.Update(entity);
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
                result = EstadoDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Estado> SelectAll()
        {
            List<Estado> result = null;

            try
            {
                result = EstadoDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Estado> SelectAllByEstadoId()
        {
            List<Estado> result = null;

            try
            {
                result = EstadoDal.Instance.SelectAllByEstadoId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
