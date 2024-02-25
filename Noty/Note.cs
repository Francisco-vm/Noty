using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noty
{
    internal class Note
    {
        public string Name { get; set; }


        private string nombreBase = "NuevaNota";

        public Note(string name)
        {
            Name = name;
        }

        public void CreateNote(string ruta, string cuadernoSeleccionado = "")
        {
            int numeroNota = ObtenerProximoNumeroNota(ruta, cuadernoSeleccionado);
            string nombreNota = $"{nombreBase}{numeroNota}";

            string rutaCompleta = cuadernoSeleccionado != ""
                ? Path.Combine(ruta, cuadernoSeleccionado, $"{nombreNota}.txt")
                : Path.Combine(ruta, $"{nombreNota}.txt");

            if (File.Exists(rutaCompleta))
            {
                MessageBox.Show("El archivo ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (File.Create(rutaCompleta)) { }
                    MessageBox.Show($"Nueva nota '{nombreNota}' creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear la nueva nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int ObtenerProximoNumeroNota(string ruta, string cuadernoSeleccionado = "")
        {
            int numero = 1;
            string carpetaDestino = cuadernoSeleccionado != "" ? cuadernoSeleccionado : ruta;

            while (File.Exists(Path.Combine(ruta, carpetaDestino, $"{nombreBase}{numero}.txt")))
            {
                numero++;
            }

            return numero;
        }
    }
}
