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
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";

 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol.PodarArbol();
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;
            String strOrientacion = "";

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            if (rbOrientacion2.Checked)
            {
                strOrientacion = "rankdir=\"LR\";";
            }
            StringBuilder b = new StringBuilder();
            //rankdir="LR";
            b.Append("digraph G { " + strOrientacion + " node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;



            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                Niveles.Text = "El arbol esta vacio";
                return;
            }
            Niveles.Text = "";
            miArbol.RecorridoPorNiveles(miRaiz);
            Niveles.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                return;
            }
            int BusNodo = int.Parse(CajaDeBuscar.Text);
            bool resultado = miArbol.BuscarNodo(BusNodo, miRaiz);

            if (resultado == true)
                MessageBox.Show("El nodo que buscas se encuentra en el arbol");
            else
                MessageBox.Show("El nodo que buscas no se encuentra en el arbol");
        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InfoArbol_Click_1(object sender, EventArgs e)
        {
            if (miArbol.EstaVacio())
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            string info = $"Altura del árbol: {miArbol.ObtenerAltura()}\n" +
                         $"Cantidad de hojas: {miArbol.ContarHojas()}\n" +
                         $"Total de nodos: {miArbol.ContarNodos()}\n " +
                         $"Es árbol completo: {miArbol.EsArbolCompleto()}\n" +
                         $"Es árbol lleno: {miArbol.EsArbolLleno()}";

            MessageBox.Show(info, "Informacion del Arbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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

                if (miArbol.EliminarNodo(datoEliminar))
                {
                    // Actualizar la visualización del árbol
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
