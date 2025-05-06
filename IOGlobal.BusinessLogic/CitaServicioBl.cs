using IOGlobal.DataAccess;
using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.BusinessLogic
{
    public class CitaServicioBl
    {
        private static CitaServicioBl _instance;

        public static CitaServicioBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CitaServicioBl();

                return _instance;
            }
        }
        public bool Insert(CitaServicio entity)
        {
            bool result = false;

            try
            {
                result = CitaServicioDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(CitaServicio entity)
        {
            bool result = false;

            try
            {
                result = CitaServicioDal.Instance.Update(entity);
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
                result = CitaServicioDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<CitaServicio> SelectAll()
        {
            List<CitaServicio> result = null;

            try
            {
                result = CitaServicioDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<CitaServicio> SelectAllByCitaServicioId()
        {
            List<CitaServicio> result = null;

            try
            {
                result = CitaServicioDal.Instance.SelectAllByCitaServicioId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
