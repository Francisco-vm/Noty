using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noty
{
    internal class Notebook
    {
        private const string BaseName = "NewNotebook";

        public void CreateNotebook(string Route)
        {
            int NumberNotebook = GetNextNotebookNumber(Route);
            string NameNotebook = $"{BaseName}{NumberNotebook}";

            string FullRoute = Path.Combine(Route, NameNotebook);

            if (Directory.Exists(FullRoute))
            {
                MessageBox.Show("The notebook already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(FullRoute);
                    MessageBox.Show($"'{NameNotebook}' Created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating the notebook: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetNextNotebookNumber(string Route)
        {
            int Number = 1;

            while (Directory.Exists(Path.Combine(Route, $"{BaseName}{Number}")))
            {
                Number++;
            }

            return Number;
        }
    }
}
