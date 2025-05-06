using IOGlobal.DataAccess;
using IOGlobal.DataAccess.IOGlobal.DataAccess;
using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.BusinessLogic
{
    public class RolUsuarioBl
    {
        private static RolUsuarioBl _instance;

        public static RolUsuarioBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RolUsuarioBl();

                return _instance;
            }
        }

        public bool Insert(RolUsuario entity)
        {
            bool result = false;

            try
            {
                result = RolUsuarioDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(RolUsuario entity)
        {
            bool result = false;

            try
            {
                result = RolUsuarioDal.Instance.Update(entity);
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
                result = RolUsuarioDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<RolUsuario> SelectAll()
        {
            List<RolUsuario> result = null;

            try
            {
                result = RolUsuarioDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<RolUsuario> SelectAllByRolUsuarioId()
        {
            List<RolUsuario> result = null;

            try
            {
                result = RolUsuarioDal.Instance.SelectAllByRolUsuarioId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
