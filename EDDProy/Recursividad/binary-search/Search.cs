using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class Search : Form
    {
        private int[] array; // Arreglo para almacenar los elementos

        public Search(int[] array)
        {
            InitializeComponent(); // Inicializa los componentes de la forma
            this.array = array; // Asigna el arreglo
        }

        // Evento que se ejecuta al hacer clic en el botón "Buscar"
        private void SearchElement_Click(object sender, EventArgs e)
        {
            int target;
            // Intenta convertir el texto ingresado a un entero
            if (int.TryParse(number.Text, out target))
            {
                // Ordena el arreglo
                Array.Sort(array);

                // Inicia un cronómetro para medir el tiempo de procesamiento
                Stopwatch stopwatch = Stopwatch.StartNew();
                // Llama al método Run para buscar el elemento en el arreglo
                int result = BinarySearch.Run(array, target, 0, array.Length - 1);
                stopwatch.Stop(); // Detiene el cronómetro

                // Crea un mensaje con el resultado y el tiempo de ejecución
                string message;
                if (result != -1)
                {
                    message = $"El elemento {target} se encuentra en la posición {result + 1}";
                }
                else
                {
                    message = $"El elemento {target} no se encuentra en el arreglo";
                }
                message += $"\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms";
                message += $"\nComplejidad: O(log n)";

                // Muestra el mensaje en un cuadro de diálogo
                MessageBox.Show(message);
                this.Close(); // Cierra la forma actual
            }
            else
            {
                // Muestra un mensaje de error si la entrada no es válida
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Cancelar"
        private void back_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la forma actual
        }

        // Evento que se ejecuta al cargar la forma
        private void Search_Load(object sender, EventArgs e)
        {
            // Aquí se pueden inicializar componentes si es necesario
        }
    }
}