using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noty
{
    internal class Notebook
    {
        private const string baseName = "NewNotebook";

        public void CreateNotebook(string Route)
        {
            int numberNotebook = GetNextNotebookNumber(Route);
            string nameNotebook = $"{baseName}{numberNotebook}";

            string fullRoute = Path.Combine(Route, nameNotebook);

            if (Directory.Exists(fullRoute))
            {
                MessageBox.Show("The notebook already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(fullRoute);
                    MessageBox.Show($"'{nameNotebook}' Created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating the notebook: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetNextNotebookNumber(string Route)
        {
            int number = 1;

            while (Directory.Exists(Path.Combine(Route, $"{baseName}{number}")))
            {
                number++;
            }

            return number;
        }
    }
}
