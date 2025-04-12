using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOGlobal.Entities;

namespace IOGlobal.DataAccess
{
    public class DetalleVentaDal : Connection
    {
        public bool Insert(DetVenta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDetVentaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.Parameters.AddWithValue("@Precio", entity.PrecioVenta);
                    cmd.Parameters.AddWithValue("@VentaId", entity.VentaId);
                    cmd.Parameters.AddWithValue("@ProductoId", (object)entity.ProductoId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CitaServicioId", (object)entity.CitaServicioId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CitaId", (object)entity.CitaId ?? DBNull.Value);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(DetVenta entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDetVentaUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetVentaId", entity.DetVentaId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.Parameters.AddWithValue("@Precio", entity.PrecioVenta);
                    cmd.Parameters.AddWithValue("@VentaId", entity.VentaId);
                    cmd.Parameters.AddWithValue("@ProductoId", (object)entity.ProductoId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CitaServicioId", (object)entity.CitaServicioId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CitaId", (object)entity.CitaId ?? DBNull.Value);

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
                using (SqlCommand cmd = new SqlCommand("SPDetVentaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetVentaId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<DetVenta> SelectAll()
        {
            List<DetVenta> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDetventaSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<DetVenta>();
                            while (dr.Read())
                            {
                                DetVenta entity = new DetVenta();
                                entity.DetVentaId = dr.GetInt32(0);
                                entity.Cantidad = dr.GetInt32(1);
                                entity.PrecioVenta = dr.GetDecimal(2);
                                entity.VentaId = new Venta
                                {
                                    VentaId = dr.GetInt32(3)
                                };

                                entity.ProductoId = new Producto
                                {
                                    ProductoId = dr.GetInt32(4)
                                };

                                entity.CitaServicioId = new CitaServicio
                                {
                                    CitaServicioId = dr.GetInt32(5)
                                };

                                entity.CitaId = new Cita
                                {
                                    CitaId = dr.GetInt32(6)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<DetVenta> SelectAllByDetVentaId()
        {
            List<DetVenta> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPDetventaIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<DetVenta>();
                            while (dr.Read())
                            {
                                DetVenta entity = new DetVenta();
                                entity.DetVentaId = dr.GetInt32(0);
                                entity.Cantidad = dr.GetInt32(1);
                                entity.PrecioVenta = dr.GetDecimal(2);
                                entity.VentaId = new Venta
                                {
                                    VentaId = dr.GetInt32(3)
                                };

                                entity.ProductoId = new Producto
                                {
                                    ProductoId = dr.GetInt32(4)
                                };

                                entity.CitaServicioId = new CitaServicio
                                {
                                    CitaServicioId = dr.GetInt32(5)
                                };

                                entity.CitaId = new Cita
                                {
                                    CitaId = dr.GetInt32(6)
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
