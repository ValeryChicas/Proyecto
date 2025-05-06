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
    public class ProductoDal : Connection
    {
        private static ProductoDal _instance;

        public static ProductoDal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProductoDal();

                return _instance;
            }
        }
        public bool Insert(Producto entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPProductoInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", entity.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    cmd.Parameters.AddWithValue("@StockMinimo", entity.StockMinimo);
                    cmd.Parameters.AddWithValue("@CategoriaId", entity.CategoriaId.CategoriaId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId.EstadoId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId.UsuarioId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Producto entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPProductoUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoId", entity.ProductoId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", entity.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    cmd.Parameters.AddWithValue("@StockMinimo", entity.StockMinimo);
                    cmd.Parameters.AddWithValue("@CategoriaId", entity.CategoriaId.CategoriaId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId.EstadoId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId.UsuarioId);

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
                using (SqlCommand cmd = new SqlCommand("SPProductoDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Producto> SelectAll()
        {
            List<Producto> result = new List<Producto>(); // Initialize the list to avoid CS0165

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPProductoSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Producto entity = new Producto();
                            entity.ProductoId = dr.GetInt32(0);
                            entity.Nombre = dr.GetString(1);
                            entity.Descripcion = dr.GetString(2);
                            entity.Precio = dr.GetDecimal(3);
                            entity.StockMinimo = dr.GetInt32(4);
                            entity.CategoriaId = new Categoria
                            {
                                Nombre = dr.GetString(5)
                            };
                            entity.EstadoId = new Estado
                            {
                                Nombre = dr.GetString(6)
                            };

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public List<Producto> SelectAllByProductoId()
        {
            List<Producto> result = new List<Producto>(); // Initialize the list to avoid CS0165

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPProductoSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Producto entity = new Producto();
                                entity.ProductoId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.Descripcion = dr.GetString(2);
                                entity.Precio = dr.GetDecimal(3);
                                entity.StockMinimo = dr.GetInt32(4);
                                entity.CategoriaId = new Categoria
                                {
                                    CategoriaId = dr.GetInt32(5)
                                };
                                entity.EstadoId = new Estado
                                {
                                    EstadoId = dr.GetInt32(6)
                                };
                                entity.UsuarioId = new Usuario
                                {
                                    UsuarioId = dr.GetInt32(7)
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
