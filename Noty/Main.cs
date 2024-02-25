namespace Noty
{
    public partial class Main : Form
    {

        private string folderPath;
        private bool creatingInNotebook;
        private string selectedNotebook;
        private int numberNote = 0;
        private int numberNotebook = 0;
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

            // Actualizar la lista de archivos .txt según la nueva carpeta seleccionada
            UpdateNotes(NoteBookSelected);

            // Manejar el evento de selección cambiada en la ListBox de cuadernos
            selectedNotebook = ls_NoteBooks.SelectedItem as string;
            creatingInNotebook = !string.IsNullOrEmpty(selectedNotebook);

            if (creatingInNotebook)
            {
                UpdateNotes(selectedNotebook);
            }
            else
            {
                UpdateNotes();
            }
        }

        private void ls_Notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manejar el evento de selección cambiada en el ListBox

            // Obtener el archivo seleccionado
            string archivoSeleccionado = ls_Notes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(archivoSeleccionado))
            {
                // Obtener la carpeta seleccionada en la ListBox de cuadernos
                string cuadernoSeleccionado = ls_NoteBooks.SelectedItem?.ToString();

                // Obtener la ruta completa del archivo
                string rutaCompleta;

                if (string.IsNullOrEmpty(cuadernoSeleccionado))
                {
                    // Carpeta raíz
                    rutaCompleta = Path.Combine(folderPath, $"{archivoSeleccionado}.txt");
                }
                else
                {
                    // Cuaderno seleccionado
                    rutaCompleta = Path.Combine(folderPath, cuadernoSeleccionado, $"{archivoSeleccionado}.txt");
                }

                try
                {
                    // Leer el contenido del archivo y mostrarlo en el RichTextBox
                    TextArea.Text = File.ReadAllText(rutaCompleta);

                    // Establecer el título de la nota en el TextBox
                    tbx_Title.Text = Path.GetFileNameWithoutExtension(archivoSeleccionado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Note_Click(object sender, EventArgs e)
        {
            btn_Note.Visible = false;
            btn_NoteBook.Visible = false;

            // Lógica para crear nota...
            numberNote++;
            string nombreNota = $"NuevaNota{numberNote}";

            // Obtén la carpeta del cuaderno seleccionado (o la carpeta raíz)
            string carpetaCuaderno = creatingInNotebook ? selectedNotebook : folderPath;

            // Asegúrate de que la carpeta del cuaderno exista
            string carpetaCuadernoPath = Path.Combine(folderPath, carpetaCuaderno);
            if (!Directory.Exists(carpetaCuadernoPath))
            {
                MessageBox.Show($"Error: La carpeta del cuaderno '{carpetaCuaderno}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crea la nota en la carpeta del cuaderno
            Note newNote = new Note(nombreNota);
            newNote.CreateNote(carpetaCuadernoPath);

            // Después de crear la nota, actualizar la lista según el contexto
            if (creatingInNotebook)
            {
                UpdateNotes(selectedNotebook);
            }
            else
            {
                UpdateNotes();
            }
        }

        private void btn_NoteBook_Click(object sender, EventArgs e)
        {
            Notebook newNotebook = new Notebook();
            newNotebook.CreateNotebook(folderPath);
            UpdateNotebooks();
        }

        private void TextArea_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_Right.Visible = true;
        }
    }
}
