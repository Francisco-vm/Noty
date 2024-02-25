using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noty
{
    internal class Notebook
    {
        private const string nombreBase = "NuevoCuaderno";

        public void CreateNotebook(string ruta)
        {
            int numeroCuaderno = ObtenerProximoNumeroCuaderno(ruta);
            string nombreCuaderno = $"{nombreBase}{numeroCuaderno}";

            string rutaCompleta = Path.Combine(ruta, nombreCuaderno);

            if (Directory.Exists(rutaCompleta))
            {
                MessageBox.Show("El cuaderno ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(rutaCompleta);
                    MessageBox.Show($"Nuevo cuaderno '{nombreCuaderno}' creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el nuevo cuaderno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int ObtenerProximoNumeroCuaderno(string ruta)
        {
            int numero = 1;

            while (Directory.Exists(Path.Combine(ruta, $"{nombreBase}{numero}")))
            {
                numero++;
            }

            return numero;
        }
    }
}
