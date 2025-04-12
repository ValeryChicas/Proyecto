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
    public class VentaDal : Connection
    {
        public bool Insert(Venta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPVentaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TotalVenta", entity.TotalVenta);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId.EstadoId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId.UsuarioId);
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId.ClienteId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Venta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPVentaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VentaId", entity.VentaId);
                    cmd.Parameters.AddWithValue("@TotalVenta", entity.TotalVenta);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId.EstadoId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId.UsuarioId);
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId.ClienteId);

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
                using (SqlCommand cmd = new SqlCommand("SPVentaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VentaId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Venta> SelectAll()
        {
            List<Venta> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPVentaSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Venta entity = new Venta();
                                entity.VentaId = dr.GetInt32(0);
                                entity.FechaVenta = dr.GetDateTime(1);
                                entity.TotalVenta = dr.GetDecimal(2);

                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(3)
                                };

                                entity.UsuarioId = new Usuario
                                {
                                    UsuarioId = dr.GetInt32(4)
                                };

                                entity.ClienteId = new Cliente
                                {
                                    ClienteId = dr.GetInt32(5)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Venta> SelectAllByVentaId()
        {
            List<Venta> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPVentaIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Venta entity = new Venta();
                                entity.VentaId = dr.GetInt32(0);
                                entity.FechaVenta = dr.GetDateTime(1);
                                entity.TotalVenta = dr.GetDecimal(2);

                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(3)
                                };

                                entity.UsuarioId = new Usuario
                                {
                                    UsuarioId = dr.GetInt32(4)
                                };

                                entity.ClienteId = new Cliente
                                {
                                    ClienteId = dr.GetInt32(5)
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
