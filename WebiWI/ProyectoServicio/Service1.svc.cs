using ProyectoServicio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProyectoServicio
{
    public class Service1 : IService1
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBWeb 1";

        public IList<string> GetCiudades()
        {

            var ciudades = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT Ciudad FROM DataCiudad", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ciudades.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return ciudades;
        }

        public void GuardarDatosEnArchivo(string nombre, string apellidos, string correo, string genero, int codeCiudad, string requerimientos)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("spINSERT INTO DataAlumnos (Nombre, Apellidos, Email, Sexo, CodeCiudad, Requerimiento) VALUES (@Nombre, @Apellidos, @Email, @Sexo, @CodeCiudad, @Requerimiento)", connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellidos", apellidos);
                        command.Parameters.AddWithValue("@Email", correo);
                        command.Parameters.AddWithValue("@Sexo", genero);
                        command.Parameters.AddWithValue("@CodeCiudad", codeCiudad);
                        command.Parameters.AddWithValue("@Requerimiento", requerimientos);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar los datos: " + ex.Message);
            }
        }
    }
}
