using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.DataAccess
{
    public class ProveedorDal : Connection
    {
        private static ProveedorDal _instance;
        public static ProveedorDal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProveedorDal();
                return _instance;
            }
        }
        public bool Insert(Proveedor entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPProveedorInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Proveedor entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPProveedorUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProveedorId", entity.ProveedorId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPProveedorDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProveedorId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Proveedor> SelectAll()
        {
            List<Proveedor> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPProveedorSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Proveedor entity = new Proveedor();
                            entity.ProveedorId = dr.GetInt32(0);
                            entity.Nombre = dr.GetString(1);
                            entity.Telefono = dr.GetString(2);
                            entity.Direccion = dr.IsDBNull(3) ? null : dr.GetString(3);

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public List<Proveedor> SelectAllByProveedorId()
        {
            List<Proveedor> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPProveedorIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<Proveedor>();
                            while (dr.Read())
                            {
                                Proveedor entity = new Proveedor();
                                entity.ProveedorId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.Telefono = dr.GetString(2);
                                entity.Direccion = dr.IsDBNull(3) ? null : dr.GetString(3);
                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

    }
}
