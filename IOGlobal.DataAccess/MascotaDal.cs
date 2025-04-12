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
    public class MascotaDal : Connection
    {
        public bool Insert(Mascota entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPMascotaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Peso", (object)entity.Peso ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Sexo", entity.Sexo);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)entity.Descripcion ?? DBNull.Value);  
                    cmd.Parameters.AddWithValue("@Alergias", (object)entity.Alergias ?? DBNull.Value); 
                    cmd.Parameters.AddWithValue("@EspecieId", entity.EspecieId.EspecieId); 
                    cmd.Parameters.AddWithValue("@RazaId", entity.RazaId.RazaId); 
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId.ClienteId);  

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Mascota entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPMascotaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MascotaId", entity.MascotaId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Peso", (object)entity.Peso ?? DBNull.Value); 
                    cmd.Parameters.AddWithValue("@Sexo", entity.Sexo);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)entity.Descripcion ?? DBNull.Value);  
                    cmd.Parameters.AddWithValue("@Alergias", (object)entity.Alergias ?? DBNull.Value);  
                    cmd.Parameters.AddWithValue("@EspecieId", entity.EspecieId.EspecieId); 
                    cmd.Parameters.AddWithValue("@RazaId", entity.RazaId.RazaId); 
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
                using (SqlCommand cmd = new SqlCommand("SPMascotaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MascotaId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

            
        public List<Mascota> SelectAll()
        {
            List<Mascota> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPMascotaSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Mascota entity = new Mascota();
                                entity.MascotaId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.FechaNacimiento = dr.GetDateTime(2);
                                entity.Peso = dr.IsDBNull(3) ? 0 : dr.GetDecimal(3);
                                entity.Sexo = dr.GetString(4);
                                entity.Peso = dr.IsDBNull(3) ? 0 : dr.GetDecimal(3);
                                entity.Alergias = dr.IsDBNull(6) ? null : dr.GetString(6);  
                                entity.EspecieId = new Especie
                                {
                                    EspecieId = dr.GetInt32(7)  
                                };

                                entity.RazaId = new Raza
                                {
                                    RazaId = dr.GetInt32(8)  
                                };

                                entity.ClienteId = new Cliente
                                {
                                    ClienteId = dr.GetInt32(9)  
                                };

                                result.Add(entity);  
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Mascota> SelectAllByMascotaId()
        {
            List<Mascota> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPMascotaIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Mascota>();
                            while (dr.Read())
                            {
                                Mascota entity = new Mascota();
                                entity.MascotaId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.FechaNacimiento = dr.GetDateTime(2);
                                entity.Peso = dr.IsDBNull(3) ? 0 : dr.GetDecimal(3);
                                entity.Sexo = dr.GetString(4);
                                entity.Descripcion = dr.IsDBNull(5) ? null : dr.GetString(5);
                                entity.Alergias = dr.IsDBNull(6) ? null : dr.GetString(6);

                                entity.EspecieId = new Especie
                                {
                                    EspecieId = dr.GetInt32(7)
                                };

                                entity.RazaId = new Raza
                                {
                                    RazaId = dr.GetInt32(8)
                                };

                                entity.ClienteId = new Cliente
                                {
                                    ClienteId = dr.GetInt32(9)
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
