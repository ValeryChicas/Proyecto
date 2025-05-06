using IOGlobal.DataAccess;
using Proyecto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.BusinessLogic
{
    public class CierreBl
    {
        private static CierreBl _instance;

        public static CierreBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CierreBl();

                return _instance;
            }
        }

        public bool Insert(Cierre entity)
        {
            bool result = false;

            try
            {
                result = CierreDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Cierre entity)
        {
            bool result = false;

            try
            {
                result = CierreDal.Instance.Update(entity);
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
                result = CierreDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Cierre> SelectAll()
        {
            List<Cierre> result = null;

            try
            {
                result = CierreDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Cierre> SelectAllByCierreId()
        {
            List<Cierre> result = null;

            try
            {
                result = CierreDal.Instance.SelectAllByCierreId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
