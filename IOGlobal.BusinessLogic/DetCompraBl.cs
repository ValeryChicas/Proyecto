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
    public class DetCompraBl
    {
        private static DetCompraBl _instance;

        public static DetCompraBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DetCompraBl();

                return _instance;
            }
        }

        public bool Insert(DetCompra entity)
        {
            bool result = false;

            try
            {
                result = DetCompraDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(DetCompra entity)
        {
            bool result = false;

            try
            {
                result = DetCompraDal.Instance.Update(entity);
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
                result = DetCompraDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<DetCompra> SelectAll()
        {
            List<DetCompra> result = null;

            try
            {
                result = DetCompraDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<DetCompra> SelectAllByDetCompraId()
        {
            List<DetCompra> result = null;

            try
            {
                result = DetCompraDal.Instance.SelectAllByDetCompraId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
