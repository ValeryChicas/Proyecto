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
    public class CitaServicioDal : Connection
    {
        public bool Insert(CitaServicio entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCitaServicioInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaConsulta", entity.FechaConsulta);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)entity.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ServicioId", entity.ServicioId);
                    cmd.Parameters.AddWithValue("@MascotaId", entity.MascotaId);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(CitaServicio entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCitaServicioUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CitaServicioId", entity.CitaServicioId);
                    cmd.Parameters.AddWithValue("@FechaConsulta", entity.FechaConsulta);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)entity.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ServicioId", entity.ServicioId);
                    cmd.Parameters.AddWithValue("@MascotaId", entity.MascotaId);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);

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
                using (SqlCommand cmd = new SqlCommand("SPCitaServicioDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CitaServicioId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<CitaServicio> SelectAll()
        {
            List<CitaServicio> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCitaservicioSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<CitaServicio>();
                            while (dr.Read())
                            {
                                CitaServicio entity = new CitaServicio();
                                entity.CitaServicioId = dr.GetInt32(0);
                                entity.FechaConsulta = dr.GetDateTime(1);
                                entity.Precio = dr.GetDecimal(2);
                                entity.ServicioId = new Servicio
                                {
                                    ServicioId = dr.GetInt32(4)
                                };

                                entity.MascotaId = new Mascota
                                {
                                    MascotaId = dr.GetInt32(5)
                                };

                                entity.EmpleadoId = new Empleado
                                {
                                    EmpleadoId = dr.GetInt32(6)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }
        public List<CitaServicio> SelectAllByCitaServicioId()
        {
            List<CitaServicio> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCitaservicioIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<CitaServicio>();
                            while (dr.Read())
                            {
                                CitaServicio entity = new CitaServicio();
                                entity.CitaServicioId = dr.GetInt32(0);
                                entity.FechaConsulta = dr.GetDateTime(1);
                                entity.Precio = dr.GetDecimal(2);
                                entity.Descripcion = dr.IsDBNull(3) ? null : dr.GetString(3);

                                // Crear instancias completas para las propiedades relacionadas
                                entity.ServicioId = new Servicio
                                {
                                    ServicioId = dr.GetInt32(4)
                                };

                                entity.MascotaId = new Mascota
                                {
                                    MascotaId = dr.GetInt32(5)
                                };

                                entity.EmpleadoId = new Empleado
                                {
                                    EmpleadoId = dr.GetInt32(6)
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
