using IOGlobal.Entities;
using Proyecto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGlobal.DataAccess
{
    public class CierreDal : Connection
    {
        private static CierreDal _instance;

        public static CierreDal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CierreDal();

                return _instance;
            }
        }
        public bool Insert(Cierre entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCierreInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@SaldoInicial", entity.SaldoInicial);
                    cmd.Parameters.AddWithValue("@SaldoFinal", entity.SaldoFinal);
                    cmd.Parameters.AddWithValue("@SaldoVenta", entity.SaldoVenta);
                    cmd.Parameters.AddWithValue("@Sobrante", entity.Sobrante);
                    cmd.Parameters.AddWithValue("@Faltante", entity.Faltante);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId.UsuarioId);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId.EmpleadoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Cierre entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCierreUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CierreDeCajaId", entity.CierreId);
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@SaldoInicial", entity.SaldoInicial);
                    cmd.Parameters.AddWithValue("@SaldoFinal", entity.SaldoFinal);
                    cmd.Parameters.AddWithValue("@SaldoVenta", entity.SaldoVenta);
                    cmd.Parameters.AddWithValue("@Sobrante", entity.Sobrante);
                    cmd.Parameters.AddWithValue("@Faltante", entity.Faltante);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId.UsuarioId);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId.EmpleadoId);

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
                using (SqlCommand cmd = new SqlCommand("SPCierreDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CierreDeCajaId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public List<Cierre> SelectAll()
        {
            List<Cierre> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCierreSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            result = new List<Cierre>();
                            while (dr.Read())
                            {
                                Cierre entity = new Cierre();
                                entity.CierreId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.SaldoInicial = dr.GetDecimal(2);
                                entity.SaldoFinal = dr.GetDecimal(3);
                                entity.SaldoVenta = dr.GetDecimal(4);
                                entity.Sobrante = dr.GetDecimal(5);
                                entity.Faltante = dr.GetDecimal(6);
                                entity.UsuarioId = new Usuario
                                {
                                    UsuarioId = dr.GetInt32(7)
                                };
                                entity.EmpleadoId = new Empleado
                                {
                                    EmpleadoId = dr.GetInt32(8)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Cierre> SelectAllByCierreId()
        {
            List<Cierre> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SPCierreIdSearch", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Cierre>();
                            while (dr.Read())
                            {
                                Cierre entity = new Cierre();
                                entity.CierreId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.SaldoInicial = dr.GetDecimal(2);
                                entity.SaldoFinal = dr.GetDecimal(3);
                                entity.SaldoVenta = dr.GetDecimal(4);
                                entity.Sobrante = dr.GetDecimal(5);
                                entity.Faltante = dr.GetDecimal(6);
                                entity.UsuarioId = new Usuario
                                {
                                    UsuarioId = dr.GetInt32(7)
                                };
                                entity.EmpleadoId = new Empleado
                                {
                                    EmpleadoId = dr.GetInt32(8)
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
