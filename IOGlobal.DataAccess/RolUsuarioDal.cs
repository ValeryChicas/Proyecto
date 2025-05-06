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
    namespace IOGlobal.DataAccess
    {
        public class RolUsuarioDal : Connection
        {
            private static RolUsuarioDal _instance;

            public static RolUsuarioDal Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new RolUsuarioDal();

                    return _instance;
                }
            }
            public bool Insert(RolUsuario entity)
            {
                bool result = false;

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPRolUsuarioInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }

                return result;
            }

            public bool Update(RolUsuario entity)
            {
                bool result = false;

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPRolUsuarioUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RolUsuarioId", entity.RolUsuarioId);
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

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
                    using (SqlCommand cmd = new SqlCommand("SPRolUsuarioDelete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RolUsuarioId", id);

                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }

                return result;
            }

            public List<RolUsuario> SelectAll()
            {
                List<RolUsuario> result = new List<RolUsuario>();

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPRolusuarioSearch", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                RolUsuario entity = new RolUsuario();
                                entity.RolUsuarioId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                result.Add(entity);
                            }
                        }
                    }
                }

                return result;
            }

            public List<RolUsuario> SelectAllByRolUsuarioId()
            {
                List<RolUsuario> result = null;

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPRolusuarioSearch", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                result = new List<RolUsuario>();
                                while (dr.Read())
                                {
                                    RolUsuario entity = new RolUsuario();
                                    entity.RolUsuarioId = dr.GetInt32(0);
                                    entity.Nombre = dr.GetString(1);
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
}