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
    public class UsuarioBl
    {
        private static UsuarioBl _instance;

        public static UsuarioBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsuarioBl();

                return _instance;
            }
        }

        public bool Insert(Usuario entity)
        {
            bool result = false;

            try
            {
                result = UsuarioDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Usuario entity)
        {
            bool result = false;

            try
            {
                result = UsuarioDal.Instance.Update(entity);
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
                result = UsuarioDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Usuario> SelectAll()
        {
            List<Usuario> result = null;

            try
            {
                result = UsuarioDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Usuario> SelectAllByUsuarioId(int id)
        {
            List<Usuario> result = null;
            try
            {
                result = UsuarioDal.Instance.SelectAllByUsuarioId(id);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
