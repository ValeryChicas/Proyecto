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
    public class CompraBl
    {
        private static CompraBl _instance;

        public static CompraBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CompraBl();

                return _instance;
            }
        }

        public bool Insert(Compra entity)
        {
            bool result = false;

            try
            {
                result = CompraDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Compra entity)
        {
            bool result = false;

            try
            {
                result = CompraDal.Instance.Update(entity);
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
                result = CompraDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Compra> SelectAll()
        {
            List<Compra> result = null;

            try
            {
                result = CompraDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Compra> SelectAllByCompraId()
        {
            List<Compra> result = null;

            try
            {
                result = CompraDal.Instance.SelectAllByCompraId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
