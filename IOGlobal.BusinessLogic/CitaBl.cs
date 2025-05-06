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
    public class CitaBl
    {
        private static CitaBl _instance;

        public static CitaBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CitaBl();

                return _instance;
            }
        }

        public bool Insert(Cita entity)
        {
            bool result = false;

            try
            {
                result = CitaDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Cita entity)
        {
            bool result = false;

            try
            {
                result = CitaDal.Instance.Update(entity);
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
                result = CitaDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Cita> SelectAll()
        {
            List<Cita> result = null;

            try
            {
                result = CitaDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Cita> SelectAllByCitaId()
        {
            List<Cita> result = null;

            try
            {
                result = CitaDal.Instance.SelectAllByCitaId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
