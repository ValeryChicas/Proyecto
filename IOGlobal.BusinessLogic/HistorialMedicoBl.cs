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
    public class HistorialMedicoBl
    {
        private static HistorialMedicoBl _instance;

        public static HistorialMedicoBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HistorialMedicoBl();

                return _instance;
            }
        }

        public bool Insert(HistorialMedico entity)
        {
            bool result = false;

            try
            {
                result = HistorialMedicoDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(HistorialMedico entity)
        {
            bool result = false;

            try
            {
                result = HistorialMedicoDal.Instance.Update(entity);
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
                result = HistorialMedicoDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<HistorialMedico> SelectAll()
        {
            List<HistorialMedico> result = null;

            try
            {
                result = HistorialMedicoDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<HistorialMedico> SelectAllByHistorialMedicoId()
        {
            List<HistorialMedico> result = null;

            try
            {
                result = HistorialMedicoDal.Instance.SelectAllByHistorialMedicoId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
