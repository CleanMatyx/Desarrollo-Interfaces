using CapaEntidades;
using CapaDatos;
using CapaNegocio;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        private PeliculasBD peliculasDB;

        public Form1()
        {
            InitializeComponent();
            peliculasDB = new PeliculasBD();
            ComprobarConexion();
            CargarPeliculas();
        }

        private void ComprobarConexion()
        {
            if (!peliculasDB.TestConnection())
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
            }
        }

        private void CargarPeliculas()
        {
            dgvPeliculas.DataSource = peliculasDB.ObtenerPeliculas();
            foreach (DataGridViewColumn column in dgvPeliculas.Columns)
            {
                column.Visible = false;
            }

            dgvPeliculas.Columns["Id"].Visible = true;
            dgvPeliculas.Columns["Titulo"].Visible = true;
            dgvPeliculas.Columns["Duracion"].Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvPeliculas.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvPeliculas.Rows[index];

            if (dgvPeliculas.Columns.Contains("Id"))
            {
                int id = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                peliculasDB.EliminarPelicula(id);
                MessageBox.Show("Película eliminada correctamente.");
                CargarPeliculas();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("La columna 'Id' no existe.");
            }
        }

        private void LimpiarFormulario()
        {
            txtTitulo.Text = "";
            txtDuracion.Text = "";
            txtEdadRecomendada.Text = "";
            txtDescripcion.Text = "";
        }

        private void onClickCell(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0) // Ensure the index is valid
            {
                DataGridViewRow selectedRow = dgvPeliculas.Rows[index];
                txtTitulo.Text = selectedRow.Cells["Titulo"].Value.ToString();
                txtDuracion.Text = selectedRow.Cells["Duracion"].Value.ToString();
                txtEdadRecomendada.Text = selectedRow.Cells["EdadRecomendada"].Value.ToString();
                txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
            }
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pelicula = new Pelicula
                {
                    Titulo = txtTitulo.Text,
                    Duracion = int.Parse(txtDuracion.Text),
                    EdadRecomendada = int.Parse(txtEdadRecomendada.Text),
                    Descripcion = txtDescripcion.Text
                };

                var peliculasNegocio = new PeliculasNegocio();
                int idGenerado = peliculasNegocio.InsertarPelicula(pelicula);

                MessageBox.Show($"Película insertada correctamente con ID: {idGenerado}");
                CargarPeliculas(); // Recargar la lista de películas
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
        }
    }
}
