namespace CapaEntidades
{
    public class Pelicula
    {
        private int id;
        private string titulo;
        private int duracion;
        private int edadRecomendada;
        private string descripcion;

        public Pelicula(int id, string titulo, int duracion, int edadRecomendada, string descripcion)
        {
            Id = id;
            Titulo = titulo;
            Duracion = duracion;
            EdadRecomendada = edadRecomendada;
            Descripcion = descripcion;
        }

        public Pelicula() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public int EdadRecomendada
        {
            get { return edadRecomendada; }
            set { edadRecomendada = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
