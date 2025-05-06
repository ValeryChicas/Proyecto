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
    public class CategoriaDevBl
    {
        private static CategoriaDevBl _instance;

        public static CategoriaDevBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CategoriaDevBl();

                return _instance;
            }
        }

        public bool Insert(CategoriaDev entity)
        {
            bool result = false;

            try
            {
                result = CategoriaDevDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(CategoriaDev entity)
        {
            bool result = false;

            try
            {
                result = CategoriaDevDal.Instance.Update(entity);
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
                result = CategoriaDevDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<CategoriaDev> SelectAll()
        {
            List<CategoriaDev> result = null;

            try
            {
                result = CategoriaDevDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<CategoriaDev> SelectAllByCategoriaDevId()
        {
            List<CategoriaDev> result = null;

            try
            {
                result = CategoriaDevDal.Instance.SelectAllByCategoriaDevId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
