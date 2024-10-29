using CapaEntidades;
using Npgsql;

namespace CapaDatos
{
    public class PeliculasBD
    {
        private string connectionString = "Host=localhost;Port=5432;" +
            "Username=postgres;Password=matias123;Database=Cine";

        public int InsertarPelicula(Pelicula pelicula)
        {
            if (string.IsNullOrEmpty(pelicula.Titulo))
                throw new ArgumentException("El título no puede ser vacío.");
            if (pelicula.Duracion <= 0)
                throw new ArgumentException("La duración debe ser mayor " +
                    "a 0 minutos.");

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Peliculas (titulo, duracion, " +
                            "edad_recomendada, descripcion) VALUES (@titulo, " +
                            "@duracion, @edadRecomendada, @descripcion) RETURNING id";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("titulo", 
                        pelicula.Titulo);
                    cmd.Parameters.AddWithValue("duracion", 
                        pelicula.Duracion);
                    cmd.Parameters.AddWithValue("edadRecomendada", 
                        pelicula.EdadRecomendada);
                    cmd.Parameters.AddWithValue("descripcion", 
                        pelicula.Descripcion);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    String query = "SELECT id, titulo, duracion, " +
                        "edad_recomendada, descripcion FROM Peliculas";
                    AgregarPeliculaALista(peliculas, connection, query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener películas: {ex.Message}");
            }
            return peliculas;
        }

        private static void AgregarPeliculaALista(List<Pelicula> peliculas, 
            NpgsqlConnection connection, string query)
        {
            string descripcion = "Sin descripción";
            using (var cmd = new NpgsqlCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        peliculas.Add(new Pelicula(
                            reader.GetInt32(0), // id
                            reader.GetString(1), // titulo
                            reader.GetInt32(2), // duracion
                            //Si la edad recomendada es null la inicializo a 0
                            reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                            //si la descripción es null lo inicializo un texto default
                            reader.IsDBNull(4) ? descripcion : reader.GetString(4) 
                        ));
                    }
                }
            }
        }

        public void EliminarPelicula(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Peliculas WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
