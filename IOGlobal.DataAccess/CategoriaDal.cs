using IOGlobal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto;

namespace IOGlobal.DataAccess
{
    public class CategoriaDal : Connection
    {
        private static CategoriaDal _instance;
                                 
        public static CategoriaDal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CategoriaDal();

                return _instance;
            }
        }
        public bool Insert(Categoria entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCategoriaInsert", conn))
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

        public bool Update(Categoria entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCategoriaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoriaId", entity.CategoriaId);
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
                using (SqlCommand cmd = new SqlCommand("SPCategoriaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoriaId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Categoria> SelectAll()
        {
            List<Categoria> result = new List<Categoria>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCategoriaSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Categoria entity = new Categoria();
                            entity.CategoriaId = dr.GetInt32(0);
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

            return result;
        }

        public List<Categoria> SelectAllByCategoriaId()
        {
            List<Categoria> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCategoriaSearch", conn)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Categoria>();
                            while (dr.Read())
                            {
                                Categoria entity = new Categoria();
                                entity.CategoriaId = dr.GetInt32(0);
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

