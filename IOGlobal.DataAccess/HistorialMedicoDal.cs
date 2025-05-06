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
    public class HistorialMedicoDal : Connection
    {
        private static HistorialMedicoDal _instance;

        public static HistorialMedicoDal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HistorialMedicoDal();

                return _instance;
            }
        }
        public bool Insert(HistorialMedico entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPHistorialMedicoInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Diagnostico", entity.Diagnostico);
                    cmd.Parameters.AddWithValue("@Tratamiento", (object)entity.Tratamiento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Observaciones", (object)entity.Observaciones ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MascotaId", entity.MascotaId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(HistorialMedico entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPHistorialMedicoUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HistorialMedicoId", entity.HistorialMedicoId);
                    cmd.Parameters.AddWithValue("@Diagnostico", entity.Diagnostico);
                    cmd.Parameters.AddWithValue("@Tratamiento", (object)entity.Tratamiento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Observaciones", (object)entity.Observaciones ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MascotaId", entity.MascotaId);

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
                using (SqlCommand cmd = new SqlCommand("SPHistorialMedicoDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HistorialMedicoId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<HistorialMedico> SelectAll()
        {
            List<HistorialMedico> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPHistorialMedicoSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<HistorialMedico>();
                            while (dr.Read())
                            {
                                HistorialMedico entity = new HistorialMedico();
                                entity.HistorialMedicoId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.Diagnostico = dr.GetString(2);
                                entity.Tratamiento = dr.IsDBNull(3) ? null : dr.GetString(3);
                                entity.Observaciones = dr.IsDBNull(4) ? null : dr.GetString(4);
                                entity.MascotaId = new Mascota
                                {
                                    Nombre = dr.GetString(5)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<HistorialMedico> SelectAllByHistorialMedicoId()
        {
            List<HistorialMedico> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPHistorialMedicoIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<HistorialMedico>();
                            while (dr.Read())
                            {
                                HistorialMedico entity = new HistorialMedico();
                                entity.HistorialMedicoId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.Diagnostico = dr.GetString(2);
                                entity.Tratamiento = dr.IsDBNull(3) ? null : dr.GetString(3);
                                entity.Observaciones = dr.IsDBNull(4) ? null : dr.GetString(4);
                                entity.MascotaId = new Mascota
                                {
                                    Nombre = dr.GetString(5)
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
