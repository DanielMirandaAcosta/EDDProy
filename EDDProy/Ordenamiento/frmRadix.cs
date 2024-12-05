using EDDemo.Ordenamiento.Clases; // Importa las clases necesarias para el ordenamiento
using System;
using System.Diagnostics; // Importa la clase Stopwatch para medir el tiempo
using System.Linq; // Importa LINQ para trabajar con colecciones
using System.Windows.Forms; // Importa las clases de Windows Forms

namespace EDDemo.Ordenamiento
{
    public partial class frmRadix : Form
    {
        private int[] listaNumeros; // Arreglo para almacenar los números

        public frmRadix()
        {
            InitializeComponent(); // Inicializa los componentes de la forma
            listaNumeros = new int[0]; // Inicializa la lista vacía
        }

        // Evento que se ejecuta al hacer clic en el botón "Insertar"
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Agrega un número manualmente a la lista
            if (int.TryParse(txtDato.Text, out int numero)) // Intenta convertir el texto a un número
            {
                // Agrega el número a la lista
                Array.Resize(ref listaNumeros, listaNumeros.Length + 1); // Redimensiona el arreglo
                listaNumeros[listaNumeros.Length - 1] = numero; // Asigna el número al final del arreglo

                // Actualiza el ListBox
                ActualizarListBox(); // Llama al método para actualizar la visualización
                txtDato.Clear(); // Limpia el TextBox
            }
            else
            {
                // Muestra un mensaje de error si la entrada no es válida
                MessageBox.Show("Por favor, ingresa un número válido. ");
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Crear lista"
        private void btnLista_Click(object sender, EventArgs e)
        {
            Random random = new Random(); // Crea una instancia de Random para generar números aleatorios
            listaNumeros = Enumerable.Range(0, 10).Select(_ => random.Next(-100, 101)).ToArray(); // Crea 10 números aleatorios entre -100 y 100

            // Actualiza el ListBox
            ActualizarListBox(); // Llama al método para actualizar la visualización
        }

        // Evento que se ejecuta al hacer clic en el botón "Ordenar lista"
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ordena la lista usando el método de ordenación Radix Sort
            RadixSort radixSort = new RadixSort(); // Crea una instancia de RadixSort
            Stopwatch stopwatch = Stopwatch.StartNew(); // Inicia la medición de tiempo de ejecución
            radixSort.Ordenar(listaNumeros); // Llama al método de ordenación
            stopwatch.Stop(); // Detiene la medición de tiempo

            // Actualiza el ListBox para mostrar la lista ordenada
            ActualizarListBoxOrdenada(); // Llama al método para actualizar la visualización de la lista ordenada

            // Muestra el tiempo de ejecución en la etiqueta
            lblTiempo.Text = $"Tiempo de ejecucion: {stopwatch.ElapsedMilliseconds} ms";
        }

        // Método para actualizar el ListBox con los números originales
        private void ActualizarListBox()
        {
            lista1.Items.Clear(); // Limpia el ListBox
            foreach (var numero in listaNumeros) // Itera sobre cada número en la lista
            {
                lista1.Items.Add(numero); // Agrega cada número al ListBox
            }
        }

        // Método para actualizar el ListBox con los números ordenados
        private void ActualizarListBoxOrdenada()
        {
            lista2.Items.Clear(); // Limpia el ListBox de la lista ordenada
            foreach (var numero in listaNumeros) // Itera sobre cada número en la lista
            {
                lista2.Items.Add(numero); // Agrega cada número ordenado al ListBox
            }
        }
    }
}
