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
    public class RazaDal : Connection
    {
        private static RazaDal _instance;
        public static RazaDal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RazaDal();
                return _instance;
            }
        }
        public bool Insert(Raza entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPRazaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId.EstadoId); 

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Raza entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPRazaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RazaId", entity.RazaId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
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
                using (SqlCommand cmd = new SqlCommand("SPRazaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RazaId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Raza> SelectAll()
        {
            List<Raza> result = new List<Raza> ();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPRazaSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Raza entity = new Raza();
                                entity.RazaId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.EstadoId = new Estado
                                {
                                    Nombre = dr.GetString(2)  
                                };

                                result.Add(entity);  
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Raza> SelectAllByRazaId()
        {
            List<Raza> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPRazaIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<Raza>();
                            while (dr.Read())
                            {
                                Raza entity = new Raza();
                                entity.RazaId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(2)
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
