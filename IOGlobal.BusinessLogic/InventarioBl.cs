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
    public class InventarioBl
    {
        private static InventarioBl _instance;

        public static InventarioBl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InventarioBl();

                return _instance;
            }
        }

        public bool Insert(Inventario entity)
        {
            bool result = false;

            try
            {
                result = InventarioDal.Instance.Insert(entity);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Inventario entity)
        {
            bool result = false;

            try
            {
                result = InventarioDal.Instance.Update(entity);
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
                result = InventarioDal.Instance.Delete(id);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Inventario> SelectAll()
        {
            List<Inventario> result = null;

            try
            {
                result = InventarioDal.Instance.SelectAll();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Inventario> SelectAllByInventarioId()
        {
            List<Inventario> result = null;

            try
            {
                result = InventarioDal.Instance.SelectAllByInventarioId();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
