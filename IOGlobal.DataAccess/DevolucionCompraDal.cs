using IOGlobal.Entities;
using Proyecto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.DataAccess
{
    public class DevolucionCompraDal : Connection
    {
        public bool Insert(DevolucionCompra entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDevolucionCompraInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@DetCompraId", entity.DetCompraId.DetCompraId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId.UsuarioId);
                    cmd.Parameters.AddWithValue("@CategoriaDevId", entity.CategoriaDevId.CategoriaDevId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(DevolucionCompra entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDevolucionCompraUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DevolucionId", entity.DevolucionId);
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@DetCompraId", entity.DetCompraId.DetCompraId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId.UsuarioId);
                    cmd.Parameters.AddWithValue("@CategoriaDevId", entity.CategoriaDevId.CategoriaDevId);

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
                using (SqlCommand cmd = new SqlCommand("SPDevolucionCompraDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DevolucionId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<DevolucionCompra> SelectAll()
        {
            List<DevolucionCompra> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDevolucionCompraSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<DevolucionCompra>();
                            while (dr.Read())
                            {
                                DevolucionCompra entity = new DevolucionCompra();
                                entity.DevolucionId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.DetCompraId = new DetCompra
                                {
                                    DetCompraId = dr.GetInt32(2)
                                };
                                entity.Cantidad = dr.GetInt32(3);
                                entity.UsuarioId = new Usuario
                                {
                                    UsuarioId = dr.GetInt32(4)
                                };
                                entity.CategoriaDevId = new CategoriaDev
                                {
                                    CategoriaDevId = dr.GetInt32(5)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<DevolucionCompra> SelectAllByDevolucionId()
        {
            List<DevolucionCompra> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDevolucionCompraIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<DevolucionCompra>();
                            while (dr.Read())
                            {
                                DevolucionCompra entity = new DevolucionCompra();
                                entity.DevolucionId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.DetCompraId = new DetCompra
                                {
                                    DetCompraId = dr.GetInt32(2)
                                };
                                entity.Cantidad = dr.GetInt32(3);
                                entity.UsuarioId = new Usuario
                                {
                                    UsuarioId = dr.GetInt32(4)
                                };
                                entity.CategoriaDevId = new CategoriaDev
                                {
                                    CategoriaDevId = dr.GetInt32(5)
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
