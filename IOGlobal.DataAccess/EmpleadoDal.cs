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
        public class EmpleadoDal : Connection
        {
            private static EmpleadoDal _instance;

            public static EmpleadoDal Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new EmpleadoDal();

                    return _instance;
                }
            }
            public bool Insert(Empleado entity)
            {
                bool result = false;

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPEmpleadoInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                        cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Dui", entity.Dui);
                        cmd.Parameters.AddWithValue("@Direccion", (object)entity.Direccion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Genero", entity.Genero);
                        cmd.Parameters.AddWithValue("@GradoAcademico", entity.GradoAcademico);
                        cmd.Parameters.AddWithValue("@CargoId", entity.CargoId.CargoId);
                        cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId.EstadoId);

                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }

                return result;
            }

            public bool Update(Empleado entity)
            {
                bool result = false;

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPEmpleadoUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                        cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Dui", entity.Dui);
                        cmd.Parameters.AddWithValue("@Direccion", (object)entity.Direccion ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Genero", entity.Genero);
                        cmd.Parameters.AddWithValue("@GradoAcademico", entity.GradoAcademico);
                        cmd.Parameters.AddWithValue("@CargoId", entity.CargoId.CargoId);
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
                    using (SqlCommand cmd = new SqlCommand("SPEmpleadoDelete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmpleadoId", id);

                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }

                return result;
            }

            public List<Empleado> SelectAll()
            {
                List<Empleado> result = null;

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPEmpleadoSearch", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Empleado entity = new Empleado();
                                entity.EmpleadoId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.Apellido = dr.GetString(2);
                                entity.Telefono = dr.GetString(3);
                                entity.FechaNacimiento = dr.GetDateTime(4);
                                entity.Dui = dr.GetString(5);
                                entity.Direccion = dr.IsDBNull(6) ? null : dr.GetString(6);
                                entity.Genero = dr.GetString(7);
                                entity.GradoAcademico = dr.GetString(8);

                                entity.CargoId = new Cargo
                                {
                                    Nombre = dr.GetString(9)
                                };

                                entity.EstadoId = new Estado
                                {
                                    Nombre = dr.GetString(10)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }

                return result;
            }

            public List<Empleado> SelectAllByEmpleadoId()
            {
                List<Empleado> result = null;

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPEmpleadoIdSearch", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                result = new List<Empleado>();
                                while (dr.Read())
                                {
                                    Empleado entity = new Empleado();
                                    entity.EmpleadoId = dr.GetInt32(0);
                                    entity.Nombre = dr.GetString(1);
                                    entity.Apellido = dr.GetString(2);
                                    entity.FechaNacimiento = dr.GetDateTime(3);
                                    entity.Genero = dr.GetString(4);
                                    entity.Telefono = dr.GetString(5);
                                    entity.Dui = dr.GetString(6);
                                    entity.Direccion = dr.IsDBNull(7) ? null : dr.GetString(7);
                                    entity.GradoAcademico = dr.GetString(8);

                                    entity.CargoId = new Cargo
                                    {
                                        CargoId = dr.GetInt32(9)
                                    };

                                    entity.EstadoId = new Estado
                                    {
                                        EstadoId = dr.GetInt32(10)
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
}