using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDatos
{
    class Ciudad
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBWeb 1";
        public IList<string> GetCiudades()
        {
            var ciudades = new HashSet<string>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT Ciudad FROM DataCiudad", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var ciudad = reader.GetString(0);
                                ciudades.Add(ciudad);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al obtener las ciudades: " + ex.Message);
            }
            return ciudades.ToList();
        }

    }
    class Conexion1
    {
        public static void Main()
        {
            Conexion1 db = new Conexion1();
            db.query();
            Console.ReadKey();
        }
        private void query()
        {
            Ciudad c = new Ciudad();
            IList<String> ciudades = c.GetCiudades();
            if (ciudades == null)
            {
                Console.WriteLine("No hay nada");
                return;
            }
            for (int i = 0; i < ciudades.Count; i++)
            {
                Console.WriteLine(ciudades[i]);
            }
        }
    }

}
