using Gestion_Donaciones.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Gestion_Donaciones.data
{
    public class DonanteSqlData
    {
        public static List<DonanteModel> todos()
        {
            List<DonanteModel> lista = new List<DonanteModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();

                    string query = "SELECT * FROM Donantes";

                    using (SqlCommand cmd = new SqlCommand (query, conn))
                    {
                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                DonanteModel donante = new DonanteModel
                                {
                                    IdDonante = Convert.ToInt32(lector["IdDonante"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    Telefono = lector["Telefono"].ToString(),
                                    Correo = lector["Correo"].ToString()
                                };

                                lista.Add(donante);
                            }
                        }
                    }

                }
            }

            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        //Buscamos uno

        public static DonanteModel uno(int id)
        {
            DonanteModel donante = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();
                    string query = "SELECT * FROM Donantes WHERE IdDonante = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                donante = new DonanteModel
                                {
                                    IdDonante = Convert.ToInt32(lector["IdDonante"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    Telefono = lector["Telefono"].ToString(),
                                    Correo = lector["Correo"].ToString()
                                };
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return donante;
        }

        //Insertar

        public static string Nuevo(DonanteModel donante)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();
                    string query = "INSERT INTO Donantes (Nombre, Telefono, Correo) VALUES (@Nombre, @Telefono, @Correo)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", donante.Nombre);
                        cmd.Parameters.AddWithValue("@Telefono", donante.Telefono);
                        cmd.Parameters.AddWithValue("@Correo", donante.Correo);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Donante registrado exitosamente.";

            }
            catch (Exception ex)
            {
                return $"Error al registrar el donante: {ex.Message}";
            }
        }
        //Editar
        public static string Editar(DonanteModel donante)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();

                    string query = "UPDATE Donantes SET Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo WHERE IdDonante = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", donante.Nombre);
                        cmd.Parameters.AddWithValue("@Telefono", donante.Telefono);
                        cmd.Parameters.AddWithValue("@Correo", donante.Correo);
                        cmd.Parameters.AddWithValue("@Id", donante.IdDonante);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas == 0)
                            return "Error al editar";
                    }
                }

                return "ok";
            }
            catch (Exception ex)
            {
                return $"Error al editar el donante: {ex.Message}";
            }
        }
        public static string Eliminar(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();
                    string query = "DELETE FROM Donantes WHERE IdDonante = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        int filas = cmd.ExecuteNonQuery();
                        if (filas == 0)
                            return "Error al eliminar";
                    }
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el donante: {ex.Message}";
            }
        }
    }
}