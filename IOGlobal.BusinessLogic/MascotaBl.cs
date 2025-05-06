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
    public class MascotaBl
    {
        private static MascotaBl _instance;

        public static MascotaBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MascotaBl();

                return _instance;
            }
        }

        public bool Insert(Mascota entity)
        {
            bool result = false;

            try
            {
                result = MascotaDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Mascota entity)
        {
            bool result = false;

            try
            {
                result = MascotaDal.Instance.Update(entity);
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
                result = MascotaDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Mascota> SelectAll()
        {
            List<Mascota> result = null;

            try
            {
                result = MascotaDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Mascota> SelectAllByMascotaId()
        {
            List<Mascota> result = null;

            try
            {
                result = MascotaDal.Instance.SelectAllByMascotaId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
