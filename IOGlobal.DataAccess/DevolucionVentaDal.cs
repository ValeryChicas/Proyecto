using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using IOGlobal.Entities;
using Proyecto;

namespace IOGlobal.DataAccess
{
    public class DevolucionVentaDal : Connection
    {
        public bool Insert(DevolucionVenta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDevolucionVentaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@DetVentaId", entity.DetVentaId.DetVentaId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId.UsuarioId);
                    cmd.Parameters.AddWithValue("@CategoriaDevId", entity.CategoriaDevId.CategoriaDevId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(DevolucionVenta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDevolucionVentaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DevolucionId", entity.DevolucionId);
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@DetVentaId", entity.DetVentaId.DetVentaId);
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
                using (SqlCommand cmd = new SqlCommand("SPDevolucionVentaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DevolucionId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<DevolucionVenta> SelectAll()
        {
            List<DevolucionVenta> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDevolucionVentaSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<DevolucionVenta>();
                            while (dr.Read())
                            {
                                DevolucionVenta entity = new DevolucionVenta();
                                entity.DevolucionId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.DetVentaId = new DetVenta
                                {
                                    DetVentaId = dr.GetInt32(2)
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

        public List<DevolucionVenta> SelectAllByDevolucionId()
        {
            List<DevolucionVenta> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDevolucionVentaIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Falta agregar parámetro @DevolucionId si querés búsqueda por ID específico

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<DevolucionVenta>();
                            while (dr.Read())
                            {
                                DevolucionVenta entity = new DevolucionVenta();
                                entity.DevolucionId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.DetVentaId = new DetVenta
                                {
                                    DetVentaId = dr.GetInt32(2)
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
