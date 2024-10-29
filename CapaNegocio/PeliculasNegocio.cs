using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class PeliculasNegocio
    {
        private PeliculasBD peliculasBD = new PeliculasBD();

        public int InsertarPelicula(Pelicula pelicula)
        {
            List<Pelicula> peliculasExistentes = peliculasBD.ObtenerPeliculas();
            if (peliculasExistentes.Any(
                p => p.Titulo.Equals(
                    pelicula.Titulo, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Ya existe una película con el " +
                    "mismo título.");
            }
            return peliculasBD.InsertarPelicula(pelicula);
        }
    }
}