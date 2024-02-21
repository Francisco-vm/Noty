namespace Noty
{
    public partial class Main : Form
    {

        private string folderPath;
        //List<string> carpetas = new List<string>();
        //List<string> notas = new List<string>();
        public Main()
        {
            InitializeComponent();
        }

        private void btn_OpenRoot_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    folderPath = dialog.SelectedPath;
                    WindowState = FormWindowState.Maximized;
                    Panel_Main.Visible = true;
                    UpdateNotebooks();
                    tbx_NameNotebook.Text = "Root";
                    UpdateNotes();
                }
            }
        }

        //Actualiza la lista de Notebooks
        private void UpdateNotebooks()
        {
            ls_NoteBooks.Items.Clear();

            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                string[] NoteBooks = Directory.GetDirectories(folderPath);

                foreach (var Notebook in NoteBooks)
                {
                    ls_NoteBooks.Items.Add(Path.GetFileNameWithoutExtension(Notebook));
                }
            }
        }

        //Actualiza la lista de notas que se encuentran dentro de Root//
        private void UpdateNotes()
        {
            ls_Notes.Items.Clear();

            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                string[] archivosTxt = Directory.GetFiles(folderPath, "*.txt");

                foreach (var archivo in archivosTxt)
                {
                    // Agregar solo el nombre del archivo, no la ruta completa
                    //ls_Notes.Items.Add(Path.GetFileName(archivo));
                    ls_Notes.Items.Add(Path.GetFileNameWithoutExtension(archivo));

                }
            }
        }

        //Actualiza la lista de notas que se encuentran dentro de algun Notebook//
        private void UpdateNotes(string carpetaSeleccionada)
        {
            ls_Notes.Items.Clear();

            if (!string.IsNullOrEmpty(carpetaSeleccionada) && Directory.Exists(Path.Combine(folderPath, carpetaSeleccionada)))
            {
                string[] archivosTxt = Directory.GetFiles(Path.Combine(folderPath, carpetaSeleccionada), "*.txt");

                foreach (var archivo in archivosTxt)
                {
                    // Agregar solo el nombre del archivo, no la ruta completa
                    ls_Notes.Items.Add(Path.GetFileNameWithoutExtension(archivo));
                }
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            btn_Note.Visible = true;
            btn_NoteBook.Visible = true;
        }

        private void ls_NoteBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Obtener la carpeta seleccionada en la ListBox
            string NoteBookSelected = ls_NoteBooks.SelectedItem?.ToString();

            // Mostrar el nombre de la carpeta en el TextBox
            tbx_NameNotebook.Text = NoteBookSelected;

            // Actualizar la lista de archivos .txt seg�n la nueva carpeta seleccionada
            UpdateNotes(NoteBookSelected);
        }

        private void ls_Notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string archivoSeleccionado = ls_Notes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(archivoSeleccionado))
            {
                // Obtener la carpeta seleccionada en la ListBox de cuadernos
                string cuadernoSeleccionado = ls_NoteBooks.SelectedItem?.ToString();

                // Construir la ruta completa del archivo utilizando la carpeta ra�z y el cuaderno
                string rutaCompleta = Path.Combine(folderPath, cuadernoSeleccionado, $"{archivoSeleccionado}.txt");

                try
                {
                    // Leer el contenido del archivo y mostrarlo en el RichTextBox
                    TextArea.Text = File.ReadAllText(rutaCompleta);

                    // Establecer el t�tulo de la nota en el TextBox
                    tbx_Title.Text = Path.GetFileNameWithoutExtension(archivoSeleccionado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
