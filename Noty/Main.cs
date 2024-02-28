namespace Noty
{
    public partial class Main : Form
    {

        private string folderPath;
        private string rootPath;
        private bool creatingInNotebook;
        private string selectedNotebook;
        private int numberNote = 0;
        private int numberNotebook = 0;
        private bool ordenAlfabetico = true;

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
                    rootPath = folderPath;
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
            /*
            ls_Notes.Items.Clear();

            if (!string.IsNullOrEmpty(carpetaSeleccionada) && Directory.Exists(Path.Combine(folderPath, carpetaSeleccionada)))
            {
                string[] archivosTxt = Directory.GetFiles(Path.Combine(folderPath, carpetaSeleccionada), "*.txt");

                foreach (var archivo in archivosTxt)
                {
                    // Agregar solo el nombre del archivo, no la ruta completa
                    ls_Notes.Items.Add(Path.GetFileNameWithoutExtension(archivo));
                }
            }*/

            // Guarda la selecci�n actual
            string seleccionActual = ls_Notes.SelectedItem?.ToString();

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

            // Restaura la selecci�n despu�s de actualizar la lista
            ls_Notes.SelectedItem = seleccionActual;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            // Si btn_Note est� invisible, hazlo visible; de lo contrario, hazlo invisible
            btn_Note.Visible = !btn_Note.Visible;

            // Si btn_NoteBook est� invisible, hazlo visible; de lo contrario, hazlo invisible
            btn_NoteBook.Visible = !btn_NoteBook.Visible;
        }

        private void ls_NoteBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Obtener la carpeta seleccionada en la ListBox
            string NoteBookSelected = ls_NoteBooks.SelectedItem?.ToString();

            // Mostrar el nombre de la carpeta en el TextBox
            tbx_NameNotebook.Text = NoteBookSelected;

            // Actualizar la lista de archivos .txt seg�n la nueva carpeta seleccionada
            UpdateNotes(NoteBookSelected);

            // Manejar el evento de selecci�n cambiada en la ListBox de cuadernos
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
            // Manejar el evento de selecci�n cambiada en el ListBox

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
                    // Carpeta ra�z
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

                    // Establecer el t�tulo de la nota en el TextBox
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

            // L�gica para crear nota...
            numberNote++;
            string nombreNota = $"NuevaNota{numberNote}";

            // Obt�n la carpeta del cuaderno seleccionado (o la carpeta ra�z)
            string carpetaCuaderno = creatingInNotebook ? selectedNotebook : folderPath;

            // Aseg�rate de que la carpeta del cuaderno exista
            string carpetaCuadernoPath = Path.Combine(folderPath, carpetaCuaderno);
            if (!Directory.Exists(carpetaCuadernoPath))
            {
                MessageBox.Show($"Error: La carpeta del cuaderno '{carpetaCuaderno}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crea la nota en la carpeta del cuaderno
            Note newNote = new Note(nombreNota);
            newNote.CreateNote(carpetaCuadernoPath);

            // Despu�s de crear la nota, actualizar la lista seg�n el contexto
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
            //Panel_Right.Visible = true;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            // Limpiar la selecci�n de cuaderno
            ls_NoteBooks.ClearSelected();

            // Actualizar la vista para mostrar las notas en la carpeta ra�z
            UpdateNotes();

            // Limpiar los campos de t�tulo y �rea de texto
            tbx_Title.Clear();
            TextArea.Clear();

            tbx_NameNotebook.Text = "Root";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Por favor, seleccione la carpeta origen antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tbx_Title.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para la nota antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoNombreArchivo = tbx_Title.Text;
            string notaSeleccionada = ls_Notes.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(notaSeleccionada))
            {
                MessageBox.Show("Por favor, selecciona una nota antes de intentar guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si hay un cuaderno seleccionado, la carpeta de destino es la del cuaderno; de lo contrario, es la carpeta ra�z
            string carpetaDestino = creatingInNotebook ? selectedNotebook : folderPath;

            string nombreNotaActual = Path.GetFileNameWithoutExtension(notaSeleccionada);

            try
            {
                // Si hay un cuaderno seleccionado, ajusta la carpeta de destino para reflejar la estructura de carpetas
                if (creatingInNotebook)
                {
                    carpetaDestino = Path.Combine(folderPath, selectedNotebook);
                }

                string rutaCompletaOriginal = Path.Combine(carpetaDestino, $"{nombreNotaActual}.txt");

                if (File.Exists(rutaCompletaOriginal))
                {
                    string rutaCompletaNuevo = Path.Combine(carpetaDestino, $"{nuevoNombreArchivo}.txt");

                    if (nombreNotaActual != nuevoNombreArchivo && File.Exists(rutaCompletaNuevo))
                    {
                        MessageBox.Show($"Ya existe una nota con el nombre '{nuevoNombreArchivo}'. Por favor, elige un nombre diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (rutaCompletaOriginal != rutaCompletaNuevo)
                    {
                        File.Move(rutaCompletaOriginal, rutaCompletaNuevo);
                    }

                    File.WriteAllText(rutaCompletaNuevo, TextArea.Text);
                    MessageBox.Show("Cambios guardados correctamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar la lista de notas y seleccionar la nota reci�n guardada
                    UpdateNotes(carpetaDestino);
                    ls_Notes.SelectedItem = nuevoNombreArchivo;

                    // Si es necesario, actualizar la lista de cuadernos
                    if (!creatingInNotebook)
                    {
                        UpdateNotebooks();
                    }
                }
                else
                {
                    MessageBox.Show($"La nota '{nombreNotaActual}' no existe. Utiliza el bot�n 'Crear' para crear una nueva nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Obtener el archivo seleccionado
            string archivoSeleccionado = ls_Notes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(archivoSeleccionado))
            {
                // Obtener la carpeta seleccionada en la ListBox de cuadernos
                string cuadernoSeleccionado = ls_NoteBooks.SelectedItem?.ToString();

                // Si hay un cuaderno seleccionado, la carpeta de destino es la del cuaderno; de lo contrario, es la carpeta ra�z
                string carpetaDestino = cuadernoSeleccionado != null ? Path.Combine(folderPath, cuadernoSeleccionado) : folderPath;

                // Obtener la ruta completa del archivo
                string rutaCompleta = Path.Combine(carpetaDestino, $"{archivoSeleccionado}.txt");

                try
                {
                    // Verificar si el archivo existe antes de intentar eliminarlo
                    if (File.Exists(rutaCompleta))
                    {
                        // Eliminar el archivo
                        File.Delete(rutaCompleta);
                        tbx_Title.Clear();
                        TextArea.Clear();

                        MessageBox.Show($"La nota '{archivoSeleccionado}' ha sido eliminada correctamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar la lista de notas despu�s de eliminar
                        if (cuadernoSeleccionado != null)
                        {
                            // Si hay un cuaderno seleccionado, actualizar la lista de notas dentro del cuaderno
                            UpdateNotes(carpetaDestino);
                        }
                        else
                        {
                            // Si no hay cuaderno seleccionado, actualizar la lista de notas en la carpeta ra�z
                            UpdateNotes();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"La nota '{archivoSeleccionado}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una nota antes de intentar eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_RenameNoteBook_Click(object sender, EventArgs e)
        {
            // Obt�n el nuevo nombre del cuaderno desde el TextBox
            string nuevoNombreCuaderno = tbx_NameNotebook.Text;

            // Verifica si hay un cuaderno seleccionado
            if (!string.IsNullOrEmpty(selectedNotebook))
            {
                try
                {
                    // Obtiene la ruta del cuaderno actual
                    string rutaCuadernoActual = Path.Combine(folderPath, selectedNotebook);

                    // Obtiene la nueva ruta con el nuevo nombre
                    string nuevaRutaCuaderno = Path.Combine(folderPath, nuevoNombreCuaderno);

                    // Renombra el cuaderno
                    Directory.Move(rutaCuadernoActual, nuevaRutaCuaderno);

                    // Actualiza la lista de cuadernos
                    UpdateNotebooks();

                    // Informa al usuario sobre el �xito
                    MessageBox.Show($"El cuaderno se ha renombrado a '{nuevoNombreCuaderno}'.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Informa al usuario sobre cualquier error
                    MessageBox.Show($"Error al renombrar el cuaderno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Informa al usuario que no hay cuaderno seleccionado
                MessageBox.Show("No hay cuaderno seleccionado para renombrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SortNoteBooks_Click(object sender, EventArgs e)
        {
            // Obt�n la lista de cuadernos
            List<string> cuadernos = Directory.GetDirectories(folderPath).ToList();

            // Decide el tipo de orden y aplica la ordenaci�n correspondiente
            if (ordenAlfabetico)
            {
                // Orden alfab�tico
                cuadernos.Sort();
            }
            else
            {
                // Orden por fecha de modificaci�n
                cuadernos.Sort((c1, c2) =>
                {
                    DateTime fechaC1 = Directory.GetLastWriteTime(c1);
                    DateTime fechaC2 = Directory.GetLastWriteTime(c2);
                    return fechaC2.CompareTo(fechaC1);
                });
            }

            // Cambia el tipo de orden para la pr�xima vez
            ordenAlfabetico = !ordenAlfabetico;

            // Limpia y actualiza la ListBox con la nueva ordenaci�n
            ls_NoteBooks.Items.Clear();
            ls_NoteBooks.Items.AddRange(cuadernos.Select(cuaderno => Path.GetFileNameWithoutExtension(cuaderno)).ToArray());
        }

        private void Panel_NoteAndNotebooks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_DeleteNotebook_Click(object sender, EventArgs e)
        {
            // Obt�n el cuaderno seleccionado
            string cuadernoSeleccionado = ls_NoteBooks.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(cuadernoSeleccionado))
            {
                MessageBox.Show("Por favor, selecciona un cuaderno antes de intentar eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construye la ruta completa del cuaderno
            string rutaCuaderno = Path.Combine(folderPath, cuadernoSeleccionado);

            try
            {
                // Elimina la carpeta del cuaderno
                Directory.Delete(rutaCuaderno, true);

                // Actualiza la lista de cuadernos
                UpdateNotebooks();

                // Limpia la selecci�n en la ListBox de cuadernos
                ls_NoteBooks.ClearSelected();

                MessageBox.Show($"Cuaderno '{cuadernoSeleccionado}' eliminado correctamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el cuaderno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
