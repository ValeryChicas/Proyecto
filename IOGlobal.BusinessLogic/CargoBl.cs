
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
    public class CargoBl
    {
        private static CargoBl _instance;

        public static CargoBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CargoBl();

                return _instance;
            }
        }

        public bool Insert(Cargo entity)
        {
            bool result = false;

            try
            {
                result = CargoDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Cargo entity)
        {
            bool result = false;

            try
            {
                result = CargoDal.Instance.Update(entity);
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
                result = CargoDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Cargo> SelectAll()
        {
            List<Cargo> result = null;

            try
            {
                result = CargoDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Cargo> SelectAllByCargoId()
        {
            List<Cargo> result = null;

            try
            {
                result = CargoDal.Instance.SelectAllByCargoId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
