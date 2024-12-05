using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        // Instancia del árbol de búsqueda.
        ArbolBusqueda miArbol;
        // Referencia a la raíz del árbol.
        NodoBinario miRaiz;

        // Constructor de la clase frmArboles.
        public frmArboles()
        {
            InitializeComponent();
            // Inicializa el árbol de búsqueda y la raíz.
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        // Evento para insertar un nodo en el árbol.
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Obtiene el nodo raíz del árbol.
            miRaiz = miArbol.RegresaRaiz();
            // Limpia la cadena donde se concatenan los nodos del árbol.
            miArbol.strArbol = "";
            // Inserta el nodo con el dato capturado.
            miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);
            // Lee el árbol completo y muestra su representación en el cuadro de texto.
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            txtDato.Text = "";
        }

        // Evento para limpiar el árbol.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Poda el árbol y reinicia la instancia.
            miArbol.PodarArbol();
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        // Evento para generar la gráfica del árbol.
        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;
            String strOrientacion = "";

            // Obtiene la raíz del árbol.
            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Determina la orientación de la gráfica.
            if (rbOrientacion2.Checked)
            {
                strOrientacion = "rankdir=\"LR\";";
            }
            StringBuilder b = new StringBuilder();
            // Construye la cadena en formato DOT.
            b.Append("digraph G { " + strOrientacion + " node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            // Genera la imagen de la gráfica.
            Bitmap bm = FileDotEngine.Run(graphVizString);
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        // Evento para realizar los recorridos del árbol.
        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            // Realiza el recorrido en PreOrden.
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";
            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El árbol está vacío";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);
            lblRecorridoPreOrden.Text = miArbol.strRecorrido;

            // Realiza el recorrido en InOrden.
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";
            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El árbol está vacío";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;

            // Realiza el recorrido en PostOrden.
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";
            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El árbol está vacío";
                return;
            }
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;

            // Realiza el recorrido por niveles.
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";
            if (miRaiz == null)
            {
                Niveles.Text = "El árbol está vacío";
                return;
            }
            Niveles.Text = "";
            miArbol.RecorridoPorNiveles(miRaiz);
            Niveles.Text = miArbol.strRecorrido;
        }

        // Evento para crear un árbol con nodos aleatorios.
        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            // Limpia los objetos y clases del árbol anterior.
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
            miArbol.strArbol = "";

            Random rnd = new Random();

            // Inserta nodos aleatorios en el árbol.
            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                miRaiz = miArbol.RegresaRaiz();
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            // Muestra la representación del árbol en el cuadro de texto.
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            txtDato.Text = "";
        }

        // Evento para buscar un nodo en el árbol.
        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                return;
            }
            int BusNodo = int.Parse(CajaDeBuscar.Text);
            bool resultado = miArbol.BuscarNodo(BusNodo, miRaiz);

            // Muestra un mensaje indicando si el nodo fue encontrado o no.
            if (resultado == true)
                MessageBox.Show("El nodo que buscas se encuentra en el árbol");
            else
                MessageBox.Show("El nodo que buscas no se encuentra en el árbol");
        }

        // Evento que se ejecuta al cargar el formulario.
        private void frmArboles_Load(object sender, EventArgs e)
        {
        }

        // Evento para mostrar información del árbol.
        private void InfoArbol_Click_1(object sender, EventArgs e)
        {
            if (miArbol.EstaVacio())
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Muestra información sobre la altura, cantidad de hojas y nodos del árbol.
            string info = $"Altura del árbol: {miArbol.ObtenerAltura()}\n" +
                         $"Cantidad de hojas: {miArbol.ContarHojas()}\n" +
                         $"Total de nodos: {miArbol.ContarNodos()}\n " +
                         $"Es árbol completo: {miArbol.EsArbolCompleto()}\n" +
                         $"Es árbol lleno: {miArbol.EsArbolLleno()}";

            MessageBox.Show(info, "Información del Árbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento para eliminar un nodo del árbol.
        private void EliminarBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EliminarText.Text))
                {
                    MessageBox.Show("Por favor ingrese el valor a eliminar");
                    return;
                }

                int datoEliminar = int.Parse(EliminarText.Text);

                // Intenta eliminar el nodo y actualiza la visualización del árbol.
                if (miArbol.EliminarNodo(datoEliminar))
                {
                    miRaiz = miArbol.RegresaRaiz();
                    miArbol.strArbol = "";
                    miArbol.MuestraArbolAcostado(1, miRaiz);
                    txtArbol.Text = miArbol.strArbol;

                    MessageBox.Show($"El nodo {datoEliminar} ha sido eliminado correctamente");
                }
                else
                {
                    MessageBox.Show($"El nodo {datoEliminar} no se encontró en el árbol");
                }

                txtDato.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el nodo: {ex.Message}");
            }
        }
    }
}