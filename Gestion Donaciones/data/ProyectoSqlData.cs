using Microsoft.Data.SqlClient;
using Gestion_Donaciones.Models;
using System;
using System.Collections.Generic;

namespace Gestion_Donaciones.data
{
    public class ProyectoSqlData
    {
        public static List<ProyectoModel> todos()
        {
            List<ProyectoModel> proyectos = new List<ProyectoModel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();
                    string query = "SELECT * FROM Proyecto";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                ProyectoModel proyecto = new ProyectoModel
                                {
                                    IdProyecto = Convert.ToInt32(lector["IdProyecto"]),
                                    NombreProyecto = lector["NombreProyecto"].ToString(),
                                    Descripcion = lector["Descripcion"].ToString()
                                };

                                lista.Add(proyecto);
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

        public static ProyectoModel uno(int id)
        {
            ProyectoModel proyecto = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();
                    string query = "SELECT * FROM Proyecto WHERE IdProyecto = @IdProyecto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdProyecto", id);
                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                proyecto = new ProyectoModel
                                {
                                    IdProyecto = Convert.ToInt32(lector["IdProyecto"]),
                                    NombreProyecto = lector["NombreProyecto"].ToString(),
                                    Descripcion = lector["Descripcion"].ToString()
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

            return proyecto;
        }

        public static string Nuevo(ProyectoModel proyecto)
        {
            string respuesta = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();
                    string query = "INSERT INTO Proyecto (NombreProyecto, Descripcion) VALUES (@NombreProyecto, @Descripcion)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreProyecto", proyecto.NombreProyecto);
                        cmd.Parameters.AddWithValue("@Descripcion", proyecto.Descripcion);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "Ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string Editar(ProyectoModel proyecto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();

                    string query = "UPDATE Proyecto SET NombreProyecto = @NombreProyecto, Descripcion = @Descripcion WHERE IdProyecto = @IdProyecto";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreProyecto", proyecto.NombreProyecto);
                        cmd.Parameters.AddWithValue("@Descripcion", proyecto.Descripcion);
                        cmd.Parameters.AddWithValue("@IdProyecto", proyecto.IdProyecto);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            return "Ok";
                        }
                        else
                        {
                            return "No se encontró el proyecto para actualizar.";
                        }
                    }
                }
                return "Ok";
            }

            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public static string Eliminar(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionSql.Cadena))
                {
                    conn.Open();
                    string query = "DELETE FROM Proyecto WHERE IdProyecto = @IdProyecto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdProyecto", id);
                        int filas = cmd.ExecuteNonQuery();
                        if (filas == 0)
                        {
                            return "No se encontró el proyecto para eliminar.";
                        }
                    }
                }
                return "Ok";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }

}
