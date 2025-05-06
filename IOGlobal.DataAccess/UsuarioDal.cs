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
    public class UsuarioDal : Connection
    {
        private static UsuarioDal _instance;

        public static UsuarioDal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsuarioDal();

                return _instance;
            }
        }

        public bool Insert(Usuario entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPUsuarioInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Usuario entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPUsuarioUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Contrasena", entity.Contrasena);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId.EmpleadoId);
                    cmd.Parameters.AddWithValue("@RolUsuarioId", entity.RolusuarioId.RolUsuarioId);
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
                using (SqlCommand cmd = new SqlCommand("SPUsuarioDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsuarioId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Usuario> SelectAll()
        {
            List<Usuario> result = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPUsuarioSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Usuario entity = new Usuario();
                            entity.UsuarioId = dr.GetInt32(0);
                            entity.Nombre = dr.GetString(1);
                            entity.Contrasena = dr.GetString(2);
                            entity.RolusuarioId = new RolUsuario
                            {
                                Nombre = dr.GetString(4)
                            };
                            entity.EmpleadoId = new Empleado
                            {
                                Nombre = dr.GetString(3)
                            };
                            
                            entity.EstadoId = new Estado
                            {
                                Nombre = dr.GetString(5)
                            };

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public List<Usuario> SelectAllByUsuarioId(int id)
        {
            List<Usuario> result = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPUsuarioIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsuarioId", id);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Usuario entity = new Usuario();
                                entity.UsuarioId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.Contrasena = dr.GetString(2);
                                entity.EmpleadoId = new Empleado
                                {
                                    EmpleadoId = dr.GetInt32(3)
                                };
                                entity.RolusuarioId = new RolUsuario
                                {
                                    RolUsuarioId = dr.GetInt32(4)
                                };
                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(5)
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
