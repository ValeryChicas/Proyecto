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
    public class CitaDal : Connection
    {
        public bool Insert(Cita entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCitaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaCita", entity.FechaCita);
                    cmd.Parameters.AddWithValue("@FechaReprogramada", (object)entity.FechaReprogramada ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Recordatorio", entity.Recordatorio);
                    cmd.Parameters.AddWithValue("@Peso", (object)entity.Peso ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    cmd.Parameters.AddWithValue("@MascotaId", entity.MascotaId);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Cita entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCitaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CitaId", entity.CitaId);
                    cmd.Parameters.AddWithValue("@FechaCita", entity.FechaCita);
                    cmd.Parameters.AddWithValue("@FechaReprogramada", (object)entity.FechaReprogramada ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Recordatorio", entity.Recordatorio);
                    cmd.Parameters.AddWithValue("@Peso", (object)entity.Peso ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    cmd.Parameters.AddWithValue("@MascotaId", entity.MascotaId);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId);

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
                using (SqlCommand cmd = new SqlCommand("SPCitaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CitaId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Cita> SelectAll()
        {
            List<Cita> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCitaSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Cita entity = new Cita();
                                entity.CitaId = dr.GetInt32(0);
                                entity.FechaCita = dr.GetDateTime(1);
                                entity.FechaReprogramada = dr.IsDBNull(2) ? DateTime.MinValue : dr.GetDateTime(2);
                                entity.Recordatorio = dr.GetBoolean(3);
                                entity.Peso = dr.IsDBNull(4) ? 0 : dr.GetDecimal(4);
                                entity.Precio = dr.GetDecimal(5);
                                entity.MascotaId = new Mascota
                                {
                                    MascotaId = dr.GetInt32(6)
                                };

                                entity.EmpleadoId = new Empleado
                                {
                                    EmpleadoId = dr.GetInt32(7)
                                };

                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(8)
                                };

                                entity.UsuarioId = new Usuario
                                {
                                    UsuarioId = dr.GetInt32(9)
                                };


                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Cita> SelectAllByCitaId()
        {
            List<Cita> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCitaIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Cita entity = new Cita();
                                entity.CitaId = dr.GetInt32(0);
                                entity.FechaCita = dr.GetDateTime(1);
                                entity.FechaReprogramada = dr.IsDBNull(2) ? DateTime.MinValue : dr.GetDateTime(2);
                                entity.Recordatorio = dr.GetBoolean(3);
                                entity.Peso = dr.IsDBNull(4) ? 0 : dr.GetDecimal(4);
                                entity.Precio = dr.GetDecimal(5);
                                entity.MascotaId = new Mascota
                                {
                                    MascotaId = dr.GetInt32(6)
                                };

                                entity.EmpleadoId = new Empleado
                                {
                                    EmpleadoId = dr.GetInt32(7)
                                };

                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(8)
                                };

                                entity.UsuarioId = new Usuario
                                {
                                    UsuarioId = dr.GetInt32(9)
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
