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
    public class ClienteDal : Connection
    {
        public bool Insert(Cliente entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPClienteInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", (object)entity.Direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", (object)entity.CorreoElectronico ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Cliente entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPClienteUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", (object)entity.Direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", (object)entity.CorreoElectronico ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

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
                using (SqlCommand cmd = new SqlCommand("SPClienteDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Cliente> SelectAll()
        {
            List<Cliente> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPClienteSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Cliente>();
                            while (dr.Read())
                            {
                                Cliente entity = new Cliente();
                                entity.ClienteId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.Apellido = dr.GetString(2);
                                entity.Telefono = dr.GetString(3);
                                entity.Direccion = dr.IsDBNull(4) ? null : dr.GetString(4);
                                entity.CorreoElectronico = dr.IsDBNull(5) ? null : dr.GetString(5);

                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(6)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Cliente> SelectAllByClienteId()
        {
            List<Cliente> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPClienteSearch", conn))  
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Cliente entity = new Cliente();
                                entity.ClienteId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.Apellido = dr.GetString(2);
                                entity.Telefono = dr.GetString(3);
                                entity.Direccion = dr.IsDBNull(4) ? null : dr.GetString(4);
                                entity.CorreoElectronico = dr.IsDBNull(5) ? null : dr.GetString(5);
                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(6)
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
