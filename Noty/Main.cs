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
        private bool ordenAlfabetico = false;
        private bool ordenAlfabeticoNotas = false;
        private bool panelExpanded = false;

        public Main()
        {
            InitializeComponent();

            ls_NoteBooks.DrawMode = DrawMode.OwnerDrawFixed;
            ls_Notes.DrawMode = DrawMode.OwnerDrawFixed;
            this.DoubleBuffered = true;
        }

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
                    tbx_NameNotebook.Text = "Root";
                    UpdateNotes();
                }
            }
        }

        //Actualiza la lista de Notebooks//
        private void UpdateNotebooks()
        {
            string seleccionActualNoteBooks = ls_NoteBooks.SelectedItem?.ToString();
            ls_NoteBooks.Items.Clear();

            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                string[] NoteBooks = Directory.GetDirectories(folderPath);

                foreach (var Notebook in NoteBooks)
                {
                    ls_NoteBooks.Items.Add(Path.GetFileNameWithoutExtension(Notebook));
                }
            }

            ls_NoteBooks.SelectedItem = seleccionActualNoteBooks;
        }

        //Actualiza la lista de notas que se encuentran dentro de Root//
        private void UpdateNotes()
        {
            string seleccionActualNotes = ls_Notes.SelectedItem?.ToString();

            ls_Notes.Items.Clear();

            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                string[] archivosTxt = Directory.GetFiles(folderPath, "*.txt");

                foreach (var archivo in archivosTxt)
                {
                    // Agregar solo el nombre del archivo, no la ruta completa
                    //ls_Notes.Items.Add(Path.GetFileName(archivo));

                    ls_Notes.Items.Add(Path.GetFileNameWithoutExtension(archivo));
                    //ls_Notes.Items.Add(GetFileNameWithoutExtensionPreserveDecimal(archivo));
                }
            }

            ls_Notes.SelectedItem = seleccionActualNotes;
        }

        //Actualiza la lista de notas que se encuentran dentro de algun Notebook//
        private void UpdateNotes(string carpetaSeleccionada)
        {
            // Guarda la selección actual
            string seleccionActualNotes = ls_Notes.SelectedItem?.ToString();

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

            // Restaura la selección después de actualizar la lista
            ls_Notes.SelectedItem = seleccionActualNotes;
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

        //Logica para seleccionar un cuaderno//
        private void ls_NoteBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_Title.ReadOnly = true;
            TextArea.ReadOnly = true;
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

        //Logica para seleccionar una nota//
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
                    TextArea.ReadOnly = false;
                    tbx_Title.ReadOnly = false;

                    // Establecer el título de la nota en el TextBox
                    tbx_Title.Text = Path.GetFileNameWithoutExtension(archivoSeleccionado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Logica para crear una nota//
        private void btn_Note_Click(object sender, EventArgs e)
        {
            btn_Note.Visible = false;
            btn_NoteBook.Visible = false;

            numberNote++;
            string nombreNota = $"NuevaNota{numberNote}";

            // Obtén la ruta del cuaderno seleccionado (o la carpeta raíz)
            string carpetaCuaderno = creatingInNotebook ? selectedNotebook : folderPath;

            // Condición (cuaderno->exista)
            string carpetaCuadernoPath = Path.Combine(folderPath, carpetaCuaderno);
            if (!Directory.Exists(carpetaCuadernoPath))
            {
                MessageBox.Show($"Error: El cuaderno '{carpetaCuaderno}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crea la nota dentro del cuaderno
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

        //Logica para crear un Cuaderno//
        private void btn_NoteBook_Click(object sender, EventArgs e)
        {
            Notebook newNotebook = new Notebook();
            newNotebook.CreateNotebook(folderPath);
            UpdateNotebooks();
        }

        //Sin funciones//
        private void TextArea_MouseClick(object sender, MouseEventArgs e)
        {
            //Panel_Right.Visible = true;
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

            tbx_NameNotebook.Text = "Root";
        }

        //Guarda las notas nuevas y sus modificaciones//
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

            // Si hay un cuaderno seleccionado, la carpeta de destino es la del cuaderno; de lo contrario, es la carpeta raíz
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

                    //Se escribe el archivo.
                    tbx_Title.Text = nuevoNombreArchivo;

                    File.WriteAllText(rutaCompletaNuevo, TextArea.Text);
                    MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar la lista de notas y seleccionar la nota recién guardada
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
                    MessageBox.Show($"La nota '{nombreNotaActual}' no existe. Utiliza el botón 'Crear' para crear una nueva nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string archivoSeleccionado = ls_Notes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(archivoSeleccionado))
            {
                // Obtener la carpeta seleccionada en la ListBox de cuadernos
                string cuadernoSeleccionado = ls_NoteBooks.SelectedItem?.ToString();

                // Si hay un cuaderno seleccionado, la carpeta de destino es la del cuaderno; de lo contrario, es la carpeta raíz
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

                        MessageBox.Show($"La nota '{archivoSeleccionado}' ha sido eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar la lista de notas después de eliminar
                        if (cuadernoSeleccionado != null)
                        {
                            // Si hay un cuaderno seleccionado, actualizar la lista de notas dentro del cuaderno
                            UpdateNotes(carpetaDestino);
                        }
                        else
                        {
                            // Si no hay cuaderno seleccionado, actualizar la lista de notas en la carpeta raíz
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

        //Renombra el cuaderno seleccionado//
        private void btn_RenameNoteBook_Click(object sender, EventArgs e)
        {
            /*
            // Obtener el cuaderno seleccionado
            string cuadernoSeleccionado = ls_NoteBooks.SelectedItem as string;

            if (cuadernoSeleccionado != null)
            {
                using (InputDialog inputDialog = new InputDialog("Ingrese el nuevo nombre del cuaderno:", "Renombrar Cuaderno"))
                {
                    if (inputDialog.ShowDialog() == DialogResult.OK)
                    {
                        string nuevoNombreCuaderno = inputDialog.Result;

                        if (!string.IsNullOrEmpty(nuevoNombreCuaderno))
                        {
                            // Renombrar el cuaderno
                            string carpetaCuaderno = Path.Combine(folderPath, cuadernoSeleccionado);
                            string nuevaCarpetaCuaderno = Path.Combine(folderPath, nuevoNombreCuaderno);

                            try
                            {
                                Directory.Move(carpetaCuaderno, nuevaCarpetaCuaderno);
                                UpdateNotebooks(); // Actualizar la lista de cuadernos después de renombrar
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al renombrar el cuaderno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cuaderno antes de intentar renombrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            */

            //==========================================================

            
            // Obtén el nuevo nombre del cuaderno desde el TextBox
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
                    ls_NoteBooks.SelectedItem = nuevoNombreCuaderno;

                    // Informa al usuario sobre el éxito
                    MessageBox.Show($"El cuaderno se ha renombrado a '{nuevoNombreCuaderno}'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Ordena los cuadernos (modificado-alfabeticamente)
        private void btn_SortNoteBooks_Click(object sender, EventArgs e)
        {
            // Obtén la lista de cuadernos
            List<string> cuadernos = Directory.GetDirectories(folderPath).ToList();

            // Decide el tipo de orden y aplica la ordenación correspondiente
            if (ordenAlfabetico)
            {
                // Orden alfabético
                cuadernos.Sort();
            }
            else
            {
                // Orden por fecha de modificación
                cuadernos.Sort((c1, c2) =>
                {
                    DateTime fechaC1 = Directory.GetLastWriteTime(c1);
                    DateTime fechaC2 = Directory.GetLastWriteTime(c2);
                    return fechaC2.CompareTo(fechaC1);
                });
            }

            // Cambia el tipo de orden para la próxima vez
            ordenAlfabetico = !ordenAlfabetico;

            // Limpia y actualiza la ListBox con la nueva ordenación
            ls_NoteBooks.Items.Clear();
            ls_NoteBooks.Items.AddRange(cuadernos.Select(cuaderno => Path.GetFileNameWithoutExtension(cuaderno)).ToArray());
        }

        //Elimina el cuaderno seleccionado//
        private void btn_DeleteNotebook_Click(object sender, EventArgs e)
        {
            // Obtén el cuaderno seleccionado
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

                // Limpia la selección en la ListBox de cuadernos
                ls_NoteBooks.ClearSelected();

                MessageBox.Show($"Cuaderno '{cuadernoSeleccionado}' eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el cuaderno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Expand_Click(object sender, EventArgs e)
        {
            Panel_LeftTimer.Start();
            //lbl_Note.Visible = true;
            //lbl_Notebook.Visible = true;
        }

        //Ordena las notas (modificado-alfabeticamente)
        private void btn_SortNotes_Click(object sender, EventArgs e)
        {
            // Obtener la carpeta del cuaderno seleccionado (o la carpeta raíz)
            string carpetaCuaderno = creatingInNotebook ? selectedNotebook : folderPath;

            // Obtener la lista de notas en la carpeta del cuaderno
            List<string> notas = Directory.GetFiles(Path.Combine(folderPath, carpetaCuaderno), "*.txt").ToList();

            // Decidir el tipo de orden y aplicar la ordenación correspondiente
            if (ordenAlfabeticoNotas)
            {
                // Orden alfabético
                notas.Sort();
            }
            else
            {
                // Orden por fecha de modificación
                notas.Sort((n1, n2) =>
                {
                    DateTime fechaN1 = File.GetLastWriteTime(n1);
                    DateTime fechaN2 = File.GetLastWriteTime(n2);
                    return fechaN2.CompareTo(fechaN1);
                });
            }

            // Cambiar el tipo de orden para la próxima vez
            ordenAlfabeticoNotas = !ordenAlfabeticoNotas;

            // Limpiar y actualizar la ListBox con la nueva ordenación
            ls_Notes.Items.Clear();
            ls_Notes.Items.AddRange(notas.Select(nota => Path.GetFileNameWithoutExtension(nota)).ToArray());
        }

        private void btn_Bold_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

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

        //===============Notes===============//
        //=============NoteBooks=============//

    }
}
