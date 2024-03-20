using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Noty
{
    internal class Note
    {   
        private string baseName = "NewNote";

        public void CreateNote(string Route, string SelectedNotebook = "")
        {
            int numberNote = GetNextNoteNumber(Route, SelectedNotebook);
            string nameNote = $"{baseName}{numberNote}";

            string fullRoute = SelectedNotebook != ""
                ? Path.Combine(Route, SelectedNotebook, $"{nameNote}.txt")
                : Path.Combine(Route, $"{nameNote}.txt");

            if (File.Exists(fullRoute))
            {
                MessageBox.Show("The Note already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (File.Create(fullRoute)) { }
                    MessageBox.Show($"'{nameNote}' Created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating the new Note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetNextNoteNumber(string Route, string SelectedNotebook = "")
        {
            int number = 1;
            string destinationNotebook = SelectedNotebook != "" ? SelectedNotebook : Route;

            while (File.Exists(Path.Combine(Route, destinationNotebook, $"{baseName}{number}.txt")))
            {
                number++;
            }

            return number;
        }
    }
}
