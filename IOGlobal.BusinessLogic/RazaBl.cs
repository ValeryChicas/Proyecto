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
    public class RazaBl
    {
        private static RazaBl _instance;

        public static RazaBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RazaBl();

                return _instance;
            }
        }
        public bool Insert(Raza entity)
        {
            bool result = false;

            try
            {
                result = RazaDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Raza entity)
        {
            bool result = false;

            try
            {
                result = RazaDal.Instance.Update(entity);
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
                result = RazaDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Raza> SelectAll()
        {
            List<Raza> result = null;

            try
            {
                result = RazaDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Raza> SelectAllByRazaId()
        {
            List<Raza> result = null;

            try
            {
                result = RazaDal.Instance.SelectAllByRazaId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }

}
