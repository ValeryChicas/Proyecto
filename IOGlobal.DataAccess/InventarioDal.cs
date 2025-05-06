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
    public class InventarioDal : Connection
    {
        private static InventarioDal _instance;

        public static InventarioDal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InventarioDal();

                return _instance;
            }
        }

        public bool Insert(Inventario entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPInventarioInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaIngreso", entity.FechaIngreso);
                    cmd.Parameters.AddWithValue("@Stock", entity.Stock);
                    cmd.Parameters.AddWithValue("@Fechavencimiento", (object)entity.FechaVencimiento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProductoId", entity.ProductoId.ProductoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Inventario entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPInventarioUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InventarioId", entity.InventarioId);
                    cmd.Parameters.AddWithValue("@FechaIngreso", entity.FechaIngreso);
                    cmd.Parameters.AddWithValue("@Stock", entity.Stock);
                    cmd.Parameters.AddWithValue("@Fechavencimiento", (object)entity.FechaVencimiento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProductoId", entity.ProductoId.ProductoId);

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
                using (SqlCommand cmd = new SqlCommand("SPInventarioDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InventarioId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Inventario> SelectAll()
        {
            List<Inventario> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPInventarioSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<Inventario>();
                            while (dr.Read())
                            {
                                Inventario entity = new Inventario();
                                entity.InventarioId = dr.GetInt32(0);
                                entity.FechaIngreso = dr.GetDateTime(1);
                                entity.Stock = dr.GetInt32(2);
                                entity.FechaVencimiento = dr.IsDBNull(3) ? (DateTime?)null : dr.GetDateTime(3);
                                entity.ProductoId = new Producto
                                {
                                    Nombre = dr.GetString(4)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Inventario> SelectAllByInventarioId()
        {
            List<Inventario> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPInventarioIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Inventario>();
                            while (dr.Read())
                            {
                                Inventario entity = new Inventario();
                                entity.InventarioId = dr.GetInt32(0);
                                entity.FechaIngreso = dr.GetDateTime(1);
                                entity.Stock = dr.GetInt32(2);
                                entity.FechaVencimiento = dr.IsDBNull(3) ? (DateTime?)null : dr.GetDateTime(3);

                                entity.ProductoId = new Producto
                                {
                                    ProductoId = dr.GetInt32(4)
                                };

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

