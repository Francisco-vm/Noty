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
        public string Name { get; set; }

        private string BaseName = "NewNote";

        public Note(string name)
        {
            Name = name;
        }

        public void CreateNote(string Route, string SelectedNotebook = "")
        {
            int NumberNote = GetNextNoteNumber(Route, SelectedNotebook);
            string NameNote = $"{BaseName}{NumberNote}";

            string FullRoute = SelectedNotebook != ""
                ? Path.Combine(Route, SelectedNotebook, $"{NameNote}.txt")
                : Path.Combine(Route, $"{NameNote}.txt");

            if (File.Exists(FullRoute))
            {
                MessageBox.Show("The Note already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (File.Create(FullRoute)) { }
                    MessageBox.Show($"'{NameNote}' Created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating the new Note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetNextNoteNumber(string Route, string SelectedNotebook = "")
        {
            int Number = 1;
            string DestinationFolder = SelectedNotebook != "" ? SelectedNotebook : Route;

            while (File.Exists(Path.Combine(Route, DestinationFolder, $"{BaseName}{Number}.txt")))
            {
                Number++;
            }

            return Number;
        }
    }
}
