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
    public class ProductoBl
    {
        private static ProductoBl _instance;

        public static ProductoBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProductoBl();

                return _instance;
            }
        }

        public bool Insert(Producto entity)
        {
            bool result = false;

            try
            {
                result = ProductoDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Producto entity)
        {
            bool result = false;

            try
            {
                result = ProductoDal.Instance.Update(entity);
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
                result = ProductoDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Producto> SelectAll()
        {
            List<Producto> result = null;

            try
            {
                result = ProductoDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Producto> SelectAllByProductId()
        {
            List<Producto> result = null;

            try
            {
                result = ProductoDal.Instance.SelectAllByProductoId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
