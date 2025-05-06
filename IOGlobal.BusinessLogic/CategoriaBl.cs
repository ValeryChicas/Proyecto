using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOGlobal.Entities;
using IOGlobal.DataAccess;
using System.Data.SqlClient;

namespace IOGlobal.BusinessLogic
{
    public class CategoriaBl
    {
        private static CategoriaBl _instance;

        public static CategoriaBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CategoriaBl();

                return _instance;
            }
        }

        public bool Insert(Categoria entity)
        {
            bool result = false;

            try
            {
                result = CategoriaDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Categoria entity)
        {
            bool result = false;

            try
            {
                result = CategoriaDal.Instance.Update(entity);
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
                result = CategoriaDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Categoria> SelectAll()
        {
            List<Categoria> result = null;

            try
            {
                result = CategoriaDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Categoria> SelectAllByCategoriaId()
        {
            List<Categoria> result = null;

            try
            {
                result = CategoriaDal.Instance.SelectAllByCategoriaId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
