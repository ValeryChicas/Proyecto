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
    public class DetCompraDal : Connection
    {
        public bool Insert(DetCompra entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDetCompraInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CantidadCompra", entity.CantidadCompra);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", entity.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@CompraId", entity.CompraId.CompraId);
                    cmd.Parameters.AddWithValue("@ProductoId", entity.ProductoId.ProductoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(DetCompra entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDetCompraUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetCompraId", entity.DetCompraId);
                    cmd.Parameters.AddWithValue("@CantidadCompra", entity.CantidadCompra);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", entity.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@CompraId", entity.CompraId.CompraId);
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
                using (SqlCommand cmd = new SqlCommand("SPDetCompraDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetCompraId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<DetCompra> SelectAll()
        {
            List<DetCompra> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDetCompraSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<DetCompra>();
                            while (dr.Read())
                            {
                                DetCompra entity = new DetCompra();
                                entity.DetCompraId = dr.GetInt32(0);
                                entity.CantidadCompra = dr.GetInt32(1);
                                entity.PrecioUnitario = dr.GetDecimal(2);
                                entity.CompraId = new Compra
                                {
                                    CompraId = dr.GetInt32(3)
                                };
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

        public List<DetCompra> SelectAllByDetCompraId()
        {
            List<DetCompra> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDetCompraIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<DetCompra>();
                            while (dr.Read())
                            {
                                DetCompra entity = new DetCompra();
                                entity.DetCompraId = dr.GetInt32(0);
                                entity.CantidadCompra = dr.GetInt32(1);
                                entity.PrecioUnitario = dr.GetDecimal(2);
                                entity.CompraId = new Compra
                                {
                                    CompraId = dr.GetInt32(3)
                                };
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
