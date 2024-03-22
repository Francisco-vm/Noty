using System;
using System.Windows.Forms;
using System.IO;

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
        private bool alphabeticalOrderNotebooks = false;
        private bool alphabeticalOrderNotes = false;
        private bool panelExpanded = false;

        public Main()
        {
            InitializeComponent();

            ls_NoteBooks.DrawMode = DrawMode.OwnerDrawFixed;
            ls_Notes.DrawMode = DrawMode.OwnerDrawFixed;
            this.DoubleBuffered = true;
        }


        //=============Functions==============//


        //Permite seleccionar la carpeta Raíz en la cual se almacenarán Notas y Cuadernos//
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
                    //tbx_NameNotebook.Text = "Root";
                    tbx_NameNotebook.ReadOnly = true;
                    tbx_NameNotebook.Text = Path.GetFileName(folderPath);
                    UpdateNotes();
                }
            }
        }


        //Actualiza la lista de notas que se encuentran dentro de Root//
        private void UpdateNotes()
        {
            string selectedNote = ls_Notes.SelectedItem?.ToString();

            ls_Notes.Items.Clear();

            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                string[] notes = Directory.GetFiles(folderPath, "*.txt");

                foreach (var note in notes)
                {
                    ls_Notes.Items.Add(Path.GetFileNameWithoutExtension(note));
                }
            }

            ls_Notes.SelectedItem = selectedNote;
        }

        //Actualiza la lista de notas que se encuentran dentro de algun Notebook//
        private void UpdateNotes(string selectedNotebook)
        {
            // Guarda la selección actual
            string selectedNote = ls_Notes.SelectedItem?.ToString();

            ls_Notes.Items.Clear();

            if (!string.IsNullOrEmpty(selectedNotebook) && Directory.Exists(Path.Combine(folderPath, selectedNotebook)))
            {
                string[] notes = Directory.GetFiles(Path.Combine(folderPath, selectedNotebook), "*.txt");

                foreach (var note in notes)
                {
                    // Agregar solo el nombre del archivo, no la ruta completa
                    ls_Notes.Items.Add(Path.GetFileNameWithoutExtension(note));
                }
            }

            // Restaura la selección después de actualizar la lista
            ls_Notes.SelectedItem = selectedNote;
        }

        //Actualiza la lista de Notebooks//
        private void UpdateNotebooks()
        {
            string selectedNotebook = ls_NoteBooks.SelectedItem?.ToString();

            ls_NoteBooks.Items.Clear();

            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                string[] Notebooks = Directory.GetDirectories(folderPath);

                foreach (var Notebook in Notebooks)
                {
                    ls_NoteBooks.Items.Add(Path.GetFileNameWithoutExtension(Notebook));
                }
            }

            ls_NoteBooks.SelectedItem = selectedNotebook;
        }

        //Hace visibles los botones btn_Note y btn_NoteBook//
        private void btn_New_Click(object sender, EventArgs e)
        {
            // Si btn_Note está invisible, hazlo visible; de lo contrario, hazlo invisible
            btn_Note.Visible = !btn_Note.Visible;
            lbl_Note.Visible = !lbl_Note.Visible;

            // Si btn_NoteBook está invisible, hazlo visible; de lo contrario, hazlo invisible
            btn_NoteBook.Visible = !btn_NoteBook.Visible;
            lbl_NoteBook.Visible = !lbl_NoteBook.Visible;
        }

        //Muestra las notas de la carpeta raíz, limpia al area de texto y el titulo de notas//
        private void btn_Home_Click(object sender, EventArgs e)
        {
            // Limpiar la selección de cuaderno
            ls_NoteBooks.ClearSelected();

            // Actualizar la vista para mostrar las notas en la carpeta raíz
            UpdateNotes();

            // Limpiar los campos de título y área de texto
            tbx_Title.Clear();
            TextArea.Clear();
            tbx_Title.ReadOnly = true;
            TextArea.ReadOnly = true;
            tbx_NameNotebook.ReadOnly = true;
            tbx_NameNotebook.Text = Path.GetFileName(folderPath);
            //tbx_NameNotebook.Text = "Root";
        }


        //=============Interface=============//


        //Controla la animacion del Panel_Left//
        private void slidebarTimer_Tick(object sender, EventArgs e)
        {
            if (panelExpanded)
            {
                Panel_Left.Width -= 10;

                if (Panel_Left.Width <= Panel_Left.MinimumSize.Width)
                {
                    Panel_Left.Width = Panel_Left.MinimumSize.Width;
                    Panel_LeftTimer.Stop();
                    panelExpanded = false;
                    lbl_New.Visible = false;
                    lbl_Note.Visible = false;
                    lbl_NoteBook.Visible = false;
                }
            }
            else
            {
                Panel_Left.Width += 10;

                if (Panel_Left.Width >= Panel_Left.MaximumSize.Width)
                {
                    Panel_Left.Width = Panel_Left.MaximumSize.Width;
                    Panel_LeftTimer.Stop();
                    panelExpanded = true;
                    lbl_New.Visible = true;

                    if (btn_Note.Visible == true)
                    {
                        lbl_Note.Visible = true;
                    }

                    if (btn_NoteBook.Visible == true)
                    {
                        lbl_NoteBook.Visible = true;
                    }
                }
            }
        }

        //Dibuja en Gris el cuaderno seleccionado//
        private void ls_NoteBooks_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Verifica si el índice es válido
            if (e.Index >= 0)
            {
                // Obtiene el ListBox
                ListBox listBox = sender as ListBox;

                // Establece el color de fondo del elemento seleccionado
                Color selectedColor = Color.FromArgb(115, 115, 115);

                // Establece el color de fondo del elemento no seleccionado
                Color defaultColor = listBox.BackColor;

                // Establece el color del texto
                Color textColor = listBox.ForeColor;

                // Crea un pincel para el fondo
                Brush backgroundBrush = new SolidBrush((e.State & DrawItemState.Selected) == DrawItemState.Selected ? selectedColor : defaultColor);

                // Crea un pincel para el texto
                Brush textBrush = new SolidBrush(textColor);

                // Dibuja el fondo
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);

                // Dibuja el texto del elemento
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Limpia los pinceles
                backgroundBrush.Dispose();
                textBrush.Dispose();

                // Si el elemento está seleccionado, dibuja un borde alrededor del elemento
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    /*
                    using (Pen borderPen = new Pen(Color.Black))
                    {
                        e.Graphics.DrawRectangle(borderPen, e.Bounds);
                    }
                    */
                }

                // Indica que el sistema operativo no debe dibujar el fondo del elemento
                e.DrawFocusRectangle();
            }
        }

        //Dibuja en Gris la nota seleccionada
        private void ls_Notes_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Verifica si el índice es válido
            if (e.Index >= 0)
            {
                // Obtiene el ListBox
                ListBox listBox = sender as ListBox;

                // Establece el color de fondo del elemento seleccionado
                Color selectedColor = Color.FromArgb(115, 115, 115);

                // Establece el color de fondo del elemento no seleccionado
                Color defaultColor = listBox.BackColor;

                // Establece el color del texto
                Color textColor = listBox.ForeColor;

                // Crea un pincel para el fondo
                Brush backgroundBrush = new SolidBrush((e.State & DrawItemState.Selected) == DrawItemState.Selected ? selectedColor : defaultColor);

                // Crea un pincel para el texto
                Brush textBrush = new SolidBrush(textColor);

                // Dibuja el fondo
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);

                // Dibuja el texto del elemento
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Limpia los pinceles
                backgroundBrush.Dispose();
                textBrush.Dispose();

                // Si el elemento está seleccionado, dibuja un borde alrededor del elemento
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    /*
                    using (Pen borderPen = new Pen(Color.Black))
                    {
                        e.Graphics.DrawRectangle(borderPen, e.Bounds);
                    }
                    */
                }

                // Indica que el sistema operativo no debe dibujar el fondo del elemento
                e.DrawFocusRectangle();
            }
        }

        //Inicia el timer (Animación del Panel_Left)//
        private void btn_Expand_Click(object sender, EventArgs e)
        {
            Panel_LeftTimer.Start();
        }


        //===============Notes===============// 


        //Logica para crear una nota//
        private void btn_Note_Click(object sender, EventArgs e)
        {
            btn_Note.Visible = false;
            btn_NoteBook.Visible = false;
            lbl_Note.Visible = false;
            lbl_NoteBook.Visible = false;

            //numberNote++;
            //string nombreNota = $"NuevaNota{numberNote}";

            // Obtén la ruta del cuaderno seleccionado (o la carpeta raíz)
            string routeNotebook = creatingInNotebook ? selectedNotebook : folderPath;

            //Crea la ruta completa
            string fullRouteNotebook = Path.Combine(folderPath, routeNotebook);

            // Condición (cuaderno->exista)
            if (!Directory.Exists(fullRouteNotebook))
            {
                MessageBox.Show($"Error: El cuaderno '{routeNotebook}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crea la nota dentro del cuaderno
            //Note newNote = new Note(nombreNota) --> before
            Note newNote = new Note(); //--> New 
            newNote.CreateNote(fullRouteNotebook);

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

        //Guarda las notas nuevas y sus modificaciones//
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Condicion carpeta root seleccionada
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Por favor, seleccione la carpeta origen antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Condicion campo titulo lleno
            if (string.IsNullOrEmpty(tbx_Title.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para la nota antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Se obtiene la nota seleccionada y su titulo
            string newNameNote = tbx_Title.Text;
            string selectedNote = ls_Notes.SelectedItem?.ToString();

            //Condicion nota seleccionada
            if (string.IsNullOrEmpty(selectedNote))
            {
                MessageBox.Show("Por favor, selecciona una nota antes de intentar guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si hay un cuaderno seleccionado, la carpeta de destino es la del cuaderno; de lo contrario, es la carpeta raíz
            string destinationNotebook = creatingInNotebook ? selectedNotebook : folderPath;

            string nameNote = Path.GetFileNameWithoutExtension(selectedNote);

            try
            {
                // Si hay un cuaderno seleccionado, ajusta la carpeta de destino para reflejar la estructura de carpetas
                if (creatingInNotebook)
                {
                    destinationNotebook = Path.Combine(folderPath, selectedNotebook);
                }

                string fullRoute = Path.Combine(destinationNotebook, $"{nameNote}.txt");

                if (File.Exists(fullRoute))
                {
                    string newFullRoute = Path.Combine(destinationNotebook, $"{newNameNote}.txt");

                    if (nameNote != newNameNote && File.Exists(newFullRoute))
                    {
                        MessageBox.Show($"Ya existe una nota con el nombre '{newNameNote}'. Por favor, elige un nombre diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (fullRoute != newFullRoute)
                    {
                        File.Move(fullRoute, newFullRoute);
                    }

                    //Se escribe el archivo.
                    tbx_Title.Text = newNameNote;

                    File.WriteAllText(newFullRoute, TextArea.Text);
                    MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar la lista de notas y seleccionar la nota recién guardada
                    UpdateNotes(destinationNotebook);
                    ls_Notes.SelectedItem = newNameNote;

                    // Si es necesario, actualizar la lista de cuadernos
                    if (!creatingInNotebook)
                    {
                        UpdateNotebooks();
                    }
                }
                else
                {
                    MessageBox.Show($"La nota '{nameNote}' no existe. Utiliza el botón 'Crear' para crear una nueva nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Elimina la nota//
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Obtener el archivo seleccionado
            string selectedNote = ls_Notes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedNote))
            {
                // Obtener la carpeta seleccionada en la ListBox de cuadernos
                string selectedNotebook = ls_NoteBooks.SelectedItem?.ToString();

                // Si hay un cuaderno seleccionado, la carpeta de destino es la del cuaderno; de lo contrario, es la carpeta raíz
                string destinationNotebook = selectedNotebook != null ? Path.Combine(folderPath, selectedNotebook) : folderPath;

                // Obtener la ruta completa del archivo
                string fullRoute = Path.Combine(destinationNotebook, $"{selectedNote}.txt");

                try
                {
                    // Verificar si el archivo existe antes de intentar eliminarlo
                    if (File.Exists(fullRoute))
                    {
                        // Eliminar el archivo
                        File.Delete(fullRoute);
                        ls_Notes.ClearSelected();
                        tbx_Title.Clear();
                        TextArea.Clear();

                        MessageBox.Show($"La nota '{selectedNote}' ha sido eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar la lista de notas después de eliminar
                        if (selectedNotebook != null)
                        {
                            // Si hay un cuaderno seleccionado, actualizar la lista de notas dentro del cuaderno
                            UpdateNotes(destinationNotebook);
                        }
                        else
                        {
                            // Si no hay cuaderno seleccionado, actualizar la lista de notas en la carpeta raíz
                            UpdateNotes();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"La nota '{selectedNote}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Logica para seleccionar una nota//
        private void ls_Notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el archivo seleccionado
            string selectedNote = ls_Notes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedNote))
            {
                // Obtener la carpeta seleccionada en la ListBox de cuadernos
                string selectedNotebook = ls_NoteBooks.SelectedItem?.ToString();

                // Obtener la ruta completa del archivo
                string fullRoute;

                if (string.IsNullOrEmpty(selectedNotebook))
                {
                    // Carpeta raíz
                    fullRoute = Path.Combine(folderPath, $"{selectedNote}.txt");
                }
                else
                {
                    // Cuaderno seleccionado
                    fullRoute = Path.Combine(folderPath, selectedNotebook, $"{selectedNote}.txt");
                }

                try
                {
                    // Leer el contenido del archivo y mostrarlo en el RichTextBox
                    TextArea.Text = File.ReadAllText(fullRoute);
                    TextArea.ReadOnly = false;
                    tbx_Title.ReadOnly = false;

                    // Establecer el título de la nota en el TextBox
                    tbx_Title.Text = Path.GetFileNameWithoutExtension(selectedNote);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Ordena las notas (modificado-alfabeticamente)
        private void btn_SortNotes_Click(object sender, EventArgs e)
        {
            // Obtener la carpeta del cuaderno seleccionado (o la carpeta raíz)
            string routeNotebook = creatingInNotebook ? selectedNotebook : folderPath;

            string selectedNote = ls_Notes.SelectedItem?.ToString();

            // Obtener la lista de notas en la carpeta del cuaderno
            List<string> notes = Directory.GetFiles(Path.Combine(folderPath, routeNotebook), "*.txt").ToList();

            // Decidir el tipo de orden y aplicar la ordenación correspondiente
            if (alphabeticalOrderNotes)
            {
                // Orden alfabético
                notes.Sort();
            }
            else
            {
                // Orden por fecha de modificación
                notes.Sort((n1, n2) =>
                {
                    DateTime dateN1 = File.GetLastWriteTime(n1);
                    DateTime dateN2 = File.GetLastWriteTime(n2);
                    return dateN2.CompareTo(dateN1);
                });
            }

            // Cambiar el tipo de orden para la próxima vez
            alphabeticalOrderNotes = !alphabeticalOrderNotes;

            // Limpiar y actualizar la ListBox con la nueva ordenación
            ls_Notes.Items.Clear();
            ls_Notes.Items.AddRange(notes.Select(note => Path.GetFileNameWithoutExtension(note)).ToArray());
            ls_Notes.SelectedItem = selectedNote;
        }


        //=============NoteBooks=============//


        //Logica para crear un Cuaderno//
        private void btn_NoteBook_Click(object sender, EventArgs e)
        {
            btn_Note.Visible = false;
            btn_NoteBook.Visible = false;
            lbl_Note.Visible = false;
            lbl_NoteBook.Visible = false;

            Notebook newNotebook = new Notebook();
            newNotebook.CreateNotebook(folderPath);
            UpdateNotebooks();
        }

        //Elimina el cuaderno seleccionado//
        private void btn_DeleteNotebook_Click(object sender, EventArgs e)
        {
            // Obtén el cuaderno seleccionado
            string selectedNotebook = ls_NoteBooks.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedNotebook))
            {
                MessageBox.Show("Por favor, selecciona un cuaderno antes de intentar eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construye la ruta completa del cuaderno
            string fullRoute = Path.Combine(folderPath, selectedNotebook);

            try
            {
                // Elimina la carpeta del cuaderno
                Directory.Delete(fullRoute, true);

                // Actualiza la lista de cuadernos
                UpdateNotebooks();

                // Limpiar la selección de cuaderno
                ls_NoteBooks.ClearSelected();

                // Actualizar la vista para mostrar las notas en la carpeta raíz
                UpdateNotes();

                // Limpiar los campos de título y área de texto
                tbx_Title.Clear();
                TextArea.Clear();
                tbx_Title.ReadOnly = true;
                TextArea.ReadOnly = true;
                tbx_NameNotebook.ReadOnly = true;
                tbx_NameNotebook.Text = Path.GetFileName(folderPath);


                MessageBox.Show($"Cuaderno '{selectedNotebook}' eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el cuaderno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Renombra el cuaderno seleccionado//
        private void btn_RenameNoteBook_Click(object sender, EventArgs e)
        {
            string selectedNote = ls_Notes.SelectedItem?.ToString();

            // Mostrar el cuadro de diálogo de entrada para que el usuario ingrese el nuevo nombre
            using (InputDialog inputDialog = new InputDialog())
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener el nuevo nombre ingresado por el usuario
                    string newName = inputDialog.UserInput;

                    try
                    {
                        if (ls_NoteBooks.SelectedItem != null)
                        {
                            // Se está intentando renombrar un cuaderno
                            string selectedNotebook = ls_NoteBooks.SelectedItem.ToString();
                            string currentFolderPath = creatingInNotebook ? Path.Combine(folderPath, selectedNotebook) : folderPath;
                            string newFolderPath = Path.Combine(Path.GetDirectoryName(currentFolderPath), newName);

                            // Renombrar la carpeta (cuaderno)
                            Directory.Move(currentFolderPath, newFolderPath);

                            // Actualizar la lista de cuadernos y notas
                            UpdateNotebooks();
                            ls_Notes.ClearSelected();
                            UpdateNotes(newFolderPath);

                            MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Volver a seleccionar el cuaderno renombrado en la lista
                            ls_NoteBooks.SelectedItem = newName;

                            // Mantener la nota seleccionada si la había antes de renombrar el cuaderno
                            if (!string.IsNullOrEmpty(selectedNote))
                            {
                                ls_Notes.SelectedItem = selectedNote;
                            }
                        }
                        else
                        {
                            // Se está intentando renombrar la carpeta raíz
                            string newRootFolderPath = Path.Combine(Path.GetDirectoryName(folderPath), newName);
                            Directory.Move(folderPath, newRootFolderPath);

                            // Actualizar la ruta de la carpeta raíz y las listas de cuadernos y notas
                            folderPath = newRootFolderPath;
                            rootPath = folderPath;
                            UpdateNotebooks();
                            UpdateNotes();
                            tbx_NameNotebook.Text = Path.GetFileName(folderPath);

                            MessageBox.Show("Carpeta raíz renombrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al intentar renombrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Logica para seleccionar un cuaderno//
        private void ls_NoteBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_NameNotebook.ReadOnly= false;
            tbx_Title.ReadOnly = true;
            TextArea.ReadOnly = true;

            // Obtener la carpeta seleccionada en la ListBox
            string notebookSelected = ls_NoteBooks.SelectedItem?.ToString();

            // Mostrar el nombre de la carpeta en el TextBox
            tbx_NameNotebook.Text = notebookSelected;

            // Actualizar la lista de archivos .txt según la nueva carpeta seleccionada
            UpdateNotes(notebookSelected);

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

        //Ordena los cuadernos (modificado-alfabeticamente)
        private void btn_SortNoteBooks_Click(object sender, EventArgs e)
        {
            string selectedNotebook = ls_NoteBooks.SelectedItem?.ToString();

            // Obtén la lista de cuadernos
            List<string> notebooks = Directory.GetDirectories(folderPath).ToList();

            // Decide el tipo de orden y aplica la ordenación correspondiente
            if (alphabeticalOrderNotebooks)
            {
                // Orden alfabético
                notebooks.Sort();
            }
            else
            {
                // Orden por fecha de modificación
                notebooks.Sort((c1, c2) =>
                {
                    DateTime dateC1 = Directory.GetLastWriteTime(c1);
                    DateTime dateC2 = Directory.GetLastWriteTime(c2);
                    return dateC2.CompareTo(dateC1);
                });
            }

            // Cambia el tipo de orden para la próxima vez
            alphabeticalOrderNotebooks = !alphabeticalOrderNotebooks;

            // Limpia y actualiza la ListBox con la nueva ordenación
            ls_NoteBooks.Items.Clear();
            ls_NoteBooks.Items.AddRange(notebooks.Select(cuaderno => Path.GetFileNameWithoutExtension(cuaderno)).ToArray());
            ls_NoteBooks.SelectedItem = selectedNotebook;
        }


        //============= In work =============//


        //Realiza el auto guardado del cuerpo de la nota
        private void TextArea_TextChanged(object sender, EventArgs e)
        {
            AutoSave();
        }

        private void tbx_Title_TextChanged(object sender, EventArgs e)
        {
            AutoSaveTitle();
        }

        //Funcion de autoguardado para el titulo
        private void AutoSaveTitle()
        {
            // Obtener la nota seleccionada
            string selectedNote = ls_Notes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedNote))
            {
                // Obtener la carpeta seleccionada en el ListBox de cuadernos
                string cuadernoSeleccionado = ls_NoteBooks.SelectedItem?.ToString();
                string destinationNotebook = creatingInNotebook ? selectedNotebook : folderPath;

                // Construir la ruta completa de la nota
                string nameNote = Path.GetFileNameWithoutExtension(selectedNote);
                string fullRoute;

                if (creatingInNotebook && !string.IsNullOrEmpty(cuadernoSeleccionado))
                {
                    // Carpeta del cuaderno
                    fullRoute = Path.Combine(folderPath, cuadernoSeleccionado, $"{nameNote}.txt");
                }
                else
                {
                    // Carpeta raíz
                    fullRoute = Path.Combine(destinationNotebook, $"{nameNote}.txt");
                }

                try
                {
                    // Verificar si el título no está vacío
                    if (!string.IsNullOrEmpty(tbx_Title.Text))
                    {
                        string newNameNote = tbx_Title.Text.Trim(); // Eliminar espacios en blanco al inicio y al final

                        // Construir la nueva ruta con el nuevo título
                        string newFullRoute;

                        if (creatingInNotebook && !string.IsNullOrEmpty(cuadernoSeleccionado))
                        {
                            // Carpeta del cuaderno
                            newFullRoute = Path.Combine(folderPath, cuadernoSeleccionado, $"{newNameNote}.txt");
                        }
                        else
                        {
                            // Carpeta raíz
                            newFullRoute = Path.Combine(destinationNotebook, $"{newNameNote}.txt");
                        }

                        // Verificar si el nuevo título es diferente al actual
                        if (nameNote != newNameNote)
                        {
                            // Verificar si el nuevo título ya existe
                            if (!File.Exists(newFullRoute) || fullRoute == newFullRoute)
                            {
                                // Renombrar el archivo con el nuevo título
                                File.Move(fullRoute, newFullRoute);

                                // Actualizar la lista de notas
                                UpdateNotes(destinationNotebook);

                                // Actualizar el título de la nota seleccionada
                                ls_Notes.SelectedItem = newNameNote;
                            }
                            else
                            {
                                MessageBox.Show($"Ya existe una nota con el nombre '{newNameNote}'. Por favor, elige un nombre diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el título de la nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Funcion de autoguardado//
        private void AutoSave()
        {
            string selectedNote = ls_Notes.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedNote))
            {
                // No hay nota seleccionada, no se puede guardar automáticamente
                return;
            }

            string destinationNotebook = creatingInNotebook ? selectedNotebook : folderPath;
            string nameNote = Path.GetFileNameWithoutExtension(selectedNote);
            string fullRoute;

            // Verificar si estamos dentro de un cuaderno o en la carpeta raíz
            if (creatingInNotebook)
            {
                // Estamos dentro de un cuaderno, construir la ruta de la nota dentro del cuaderno
                fullRoute = Path.Combine(folderPath, destinationNotebook, $"{nameNote}.txt");
            }
            else
            {
                // Estamos en la carpeta raíz, construir la ruta de la nota en la carpeta raíz
                fullRoute = Path.Combine(folderPath, $"{nameNote}.txt");
            }

            try
            {
                // Si el archivo de la nota existe, guardar automáticamente los cambios
                if (File.Exists(fullRoute))
                {
                    File.WriteAllText(fullRoute, TextArea.Text);
                    // Puedes mostrar un mensaje de éxito o actualizar otras partes de la interfaz aquí
                }
                else
                {
                    MessageBox.Show($"La nota '{nameNote}' no existe. Utiliza el botón 'Crear' para crear una nueva nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbx_Title_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Guardar la posición del cursor antes de realizar cambios
            int cursorPosition = tbx_Title.SelectionStart;

            // Realizar la operación de modificación (borrar un carácter)
            if (e.KeyChar == (char)Keys.Back && cursorPosition > 0)
            {
                tbx_Title.Text = tbx_Title.Text.Remove(cursorPosition - 1, 1);

                // Verificar si se ha eliminado toda la palabra
                if (cursorPosition > 0 && cursorPosition <= tbx_Title.Text.Length && char.IsWhiteSpace(tbx_Title.Text[cursorPosition - 1]))
                {
                    // Restaurar la posición del cursor al inicio de la palabra
                    while (cursorPosition > 0 && char.IsWhiteSpace(tbx_Title.Text[cursorPosition - 1]))
                    {
                        cursorPosition--;
                    }
                }

                // Restaurar la posición del cursor
                tbx_Title.SelectionStart = cursorPosition;

                // Indicar que se ha manejado el evento
                e.Handled = true;
            }
        }
    }
}
