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
    public class EspecieBl
    {
        private static EspecieBl _instance;

        public static EspecieBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EspecieBl();

                return _instance;
            }
        }

        public bool Insert(Especie entity)
        {
            bool result = false;

            try
            {
                result = EspecieDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Especie entity)
        {
            bool result = false;

            try
            {
                result = EspecieDal.Instance.Update(entity);
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
                result = EspecieDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Especie> SelectAll()
        {
            List<Especie> result = null;

            try
            {
                result = EspecieDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Especie> SelectAllByEspecieId()
        {
            List<Especie> result = null;

            try
            {
                result = EspecieDal.Instance.SelectAllByEspecieId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
