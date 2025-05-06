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
    public class CompraDal : Connection
    {
        private static CompraDal _instance;
        public static CompraDal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CompraDal();

                return _instance;
            }
        }
        public bool Insert(Compra entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCompraInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@ProveedorId", entity.ProveedorId.ProveedorId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId.EstadoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Compra entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCompraUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CompraId", entity.CompraId);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@ProveedorId", entity.ProveedorId.ProveedorId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId.EstadoId);

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
                using (SqlCommand cmd = new SqlCommand("SPCompraDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CompraId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Compra> SelectAll()
        {
            List<Compra> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCompraSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<Compra>();
                            while (dr.Read())
                            {
                                Compra entity = new Compra();
                                entity.CompraId = dr.GetInt32(0);
                                entity.FechaCompra = dr.GetDateTime(1);
                                entity.Total = dr.GetDecimal(2);
                                entity.ProveedorId = new Proveedor
                                {
                                    ProveedorId = dr.GetInt32(3)
                                };
                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(4)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Compra> SelectAllByCompraId()
        {
            List<Compra> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCompraIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Compra>();
                            while (dr.Read())
                            {
                                Compra entity = new Compra();
                                entity.CompraId = dr.GetInt32(0);
                                entity.FechaCompra = dr.GetDateTime(1);
                                entity.Total = dr.GetDecimal(2);

                                entity.ProveedorId = new Proveedor
                                {
                                    ProveedorId = dr.GetInt32(3)
                                };

                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(4)
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
