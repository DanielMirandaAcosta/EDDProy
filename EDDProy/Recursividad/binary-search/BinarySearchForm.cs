using System;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class BinarySearchForm : Form
    {
        public BinarySearchForm()
        {
            InitializeComponent(); // Inicializa los componentes de la forma
        }

        // Evento que se ejecuta al hacer clic en el botón "Aceptar"
        private void Accept_Click(object sender, EventArgs e)
        {
            int size;
            // Intenta convertir el texto ingresado a un entero
            if (int.TryParse(arreglo.Text, out size))
            {
                // Crea una nueva instancia de ArrayItems para ingresar los elementos del arreglo
                ArrayItems arrayItems = new ArrayItems(size);
                arrayItems.ShowDialog(); // Muestra el formulario para ingresar elementos
            }
            else
            {
              
                // Muestra un mensaje de error si la entrada no es válida
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Regresar"
        private void back_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la forma actual
        }

        // Evento que se ejecuta al cargar la forma
        private void BinarySearchForm_Load(object sender, EventArgs e)
        {
            // Aquí se pueden inicializar componentes si es necesario
        }
    }
}