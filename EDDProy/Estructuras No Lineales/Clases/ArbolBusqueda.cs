using System;
using System.Collections.Generic;
using System.Text;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        // Nodo raíz del árbol binario.
        NodoBinario Raiz;
        // Cadena para representar el árbol.
        public String strArbol;
        // Cadena para representar el recorrido del árbol.
        public String strRecorrido;

        // Constructor de la clase ArbolBusqueda.
        public ArbolBusqueda()
        {
            // Inicializa la raíz como nula y las cadenas vacías.
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        // Método que verifica si el árbol está vacío.
        public Boolean EstaVacio()
        {
            // Retorna verdadero si la raíz es nula, de lo contrario falso.
            return Raiz == null;
        }

        // Método que devuelve la raíz del árbol.
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        // Método para insertar un nodo en el árbol.
        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            // Si el nodo actual es nulo, crea un nuevo nodo.
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // Si la raíz es nula, asigna el nuevo nodo como raíz.
                if (Raiz == null)
                    Raiz = Nodo;
            }
            // Si el dato es menor que el nodo actual, inserta en la subárbol izquierdo.
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            // Si el dato es mayor que el nodo actual, inserta en la subárbol derecho.
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }

        // Método para mostrar el árbol de forma horizontal.
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            // Si el nodo es nulo, retorna.
            if (nodo == null)
                return;

            // Muestra el subárbol derecho.
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            // Agrega espacios para la representación visual.
            for (int i = 0; i < nivel; i++)
            {
                strArbol += "      ";
            }
            // Agrega el dato del nodo a la cadena de representación.
            strArbol += nodo.Dato.ToString() + "\r\n";
            // Muestra el subárbol izquierdo.
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        // Método para convertir el árbol a formato DOT para visualización.
        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            // Si hay un hijo izquierdo, agrega la relación en formato DOT.
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }
            // Si no hay hijo izquierdo, agrega un nodo invisible.
            else
            {
                b.AppendFormat("{0}->L{1} [side=L, style=\"invis\" label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("L{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);
            }

            // Si hay un hijo derecho, agrega la relación en formato DOT.
            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            // Si no hay hijo derecho, agrega un nodo invisible.
            else
            {
                b.AppendFormat("{0}->R{1} [side=R, style=\"invis\" label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("R{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);
            }
            return b.ToString();
        }

        // Método para realizar un recorrido en preorden del árbol.
        public void PreOrden(NodoBinario nodo)
        {
            // Si el nodo es nulo, retorna.
            if (nodo == null)
                return;

            // Agrega el dato del nodo a la cadena de recorrido.
            strRecorrido += nodo.Dato + ", ";
            // Realiza el recorrido en el subárbol izquierdo.
            PreOrden(nodo.Izq);
            // Realiza el recorrido en el subárbol derecho.
            PreOrden(nodo.Der);
        }

        // Método para realizar un recorrido en inorden del árbol.
        public void InOrden(NodoBinario nodo)
        {
            // Si el nodo es nulo, retorna.
            if (nodo == null)
                return;

            // Realiza el recorrido en el subárbol izquierdo.
            InOrden(nodo.Izq);
            // Agrega el dato del nodo a la cadena de recorrido.
            strRecorrido += nodo.Dato + ", ";
            // Realiza el recorrido en el subárbol derecho.
            InOrden(nodo.Der);
        }

        // Método para realizar un recorrido en postorden del árbol.
        public void PostOrden(NodoBinario nodo)
        {
            // Si el nodo es nulo, retorna.
            if (nodo == null)
                return;

            // Realiza el recorrido en el subárbol izquierdo.
            PostOrden(nodo.Izq);
            // Realiza el recorrido en el subárbol derecho.
            PostOrden(nodo.Der);
            // Agrega el dato del nodo a la cadena de recorrido.
            strRecorrido += nodo.Dato + ", ";
        }

        // Método para buscar un nodo en el árbol.
        public bool BuscarNodo(int valor, NodoBinario nodo)
        {
            // Si el nodo es nulo, el valor no se encuentra.
            if (nodo == null)
                return false;
            // Si el valor es igual al dato del nodo, retorna verdadero.
            if (valor == nodo.Dato)
                return true;
            // Si el valor es menor, busca en la subárbol izquierdo.
            else if (valor < nodo.Dato)
                return BuscarNodo(valor, nodo.Izq);
            // Si el valor es mayor, busca en la subárbol derecho.
            else
                return BuscarNodo(valor, nodo.Der);
        }

        // Método para podar el árbol, eliminando todos los nodos.
        public void PodarArbol()
        {
            // Llama al método para podar el nodo raíz.
            PodarNodo(ref Raiz);
            // Reinicia la raíz y las cadenas de representación.
            Raiz = null;
            strArbol = string.Empty;
            strRecorrido = string.Empty;
        }

        // Método recursivo para podar un nodo.
        public void PodarNodo(ref NodoBinario nodo)
        {
            // Si el nodo es nulo, retorna.
            if (nodo == null) return;

            // Poda los subárboles izquierdo y derecho.
            PodarNodo(ref nodo.Izq);
            PodarNodo(ref nodo.Der);

            // Elimina el nodo actual.
            nodo.Izq = null;
            nodo.Der = null;
            nodo = null;
        }

        // Método para eliminar un nodo del árbol.
        public bool EliminarNodo(int dato)
        {
            NodoBinario padre = null;
            NodoBinario actual = Raiz;
            bool hijoizquierdo = false;

            // Si el árbol está vacío, retorna falso.
            if (actual == null) return false;

            // Busca el nodo a eliminar.
            while (actual != null && actual.Dato != dato)
            {
                padre = actual;
                if (dato < actual.Dato)
                {
                    actual = actual.Izq;
                    hijoizquierdo = true;
                }
                else
                {
                    actual = actual.Der;
                    hijoizquierdo = false;
                }
            }
            // Si el nodo no se encuentra, retorna falso.
            if (actual == null) return false;

            // Caso 1: El nodo a eliminar no tiene hijos.
            if (actual.Izq == null && actual.Der == null)
            {
                if (actual == Raiz)
                    Raiz = null;
                else if (hijoizquierdo)
                    padre.Izq = null;
                else
                    padre.Der = null;
            }
            // Caso 2: El nodo a eliminar tiene un hijo izquierdo.
            else if (actual.Der == null)
            {
                if (actual == Raiz)
                    Raiz = actual.Izq;
                else if (hijoizquierdo)
                    padre.Izq = actual.Izq;
                else
                    padre.Der = actual.Izq;
            }
            // Caso 3: El nodo a eliminar tiene un hijo derecho.
            else if (actual.Izq == null)
            {
                if (actual == Raiz)
                    Raiz = actual.Der;
                else if (hijoizquierdo)
                    padre.Izq = actual.Der;
                else
                    padre.Der = actual.Der;
            }
            // Caso 4: El nodo a eliminar tiene ambos hijos.
            else
            {
                NodoBinario sucesor = ObtenerSucesor(actual);
                if (actual == Raiz)
                    Raiz = sucesor;
                else if (hijoizquierdo)
                    padre.Izq = sucesor;
                else
                    padre.Der = sucesor;
                sucesor.Izq = actual.Izq;
            }

            return true;
        }

        // Método para obtener el sucesor de un nodo.
        private NodoBinario ObtenerSucesor(NodoBinario nodoELiminar)
        {
            NodoBinario sucesorPadre = nodoELiminar;
            NodoBinario sucesor = nodoELiminar;
            NodoBinario actual = nodoELiminar.Der;

            // Busca el sucesor más a la izquierda en el subárbol derecho.
            while (actual != null)
            {
                sucesorPadre = sucesor;
                sucesor = actual;
                actual = actual.Izq;
            }

            // Si el sucesor no es el hijo derecho del nodo a eliminar,
            // ajusta las referencias.
            if (sucesor != nodoELiminar.Der)
            {
                sucesorPadre.Izq = sucesor.Der;
                sucesor.Der = nodoELiminar.Der;
            }

            return sucesor;
        }

        // Método para realizar un recorrido por niveles del árbol.
        public void RecorridoPorNiveles(NodoBinario nodo)
        {
            // Si el nodo es nulo, retorna.
            if (nodo == null) return;

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(nodo);

            // Mientras haya nodos en la cola, procesa cada uno.
            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue();
                strRecorrido += actual.Dato + ", ";

                // Encola los hijos izquierdo y derecho.
                if (actual.Izq != null)
                    cola.Enqueue(actual.Izq);
                if (actual.Der != null)
                    cola.Enqueue(actual.Der);
            }
        }

        // Método para obtener la altura del árbol.
        public int ObtenerAltura()
        {
            return CalcularAltura(Raiz);
        }

        // Método recursivo para calcular la altura de un nodo.
        private int CalcularAltura(NodoBinario nodo)
        {
            // Si el nodo es nulo, la altura es 0.
            if (nodo == null) return 0;
            // Retorna 1 más la altura máxima de los subárboles izquierdo y derecho.
            return 1 + Math.Max(CalcularAltura(nodo.Izq), CalcularAltura(nodo.Der));
        }

        // Método para contar las hojas del árbol.
        public int ContarHojas()
        {
            return ContarHojasRecursivo(Raiz);
        }

        // Método recursivo para contar las hojas de un nodo.
        public int ContarHojasRecursivo(NodoBinario nodo)
        {
            // Si el nodo es nulo, retorna 0.
            if (nodo == null) return 0;
            // Si el nodo no tiene hijos, es una hoja.
            if (nodo.Izq == null && nodo.Der == null) return 1;
            // Retorna la suma de las hojas en los subárboles izquierdo y derecho.
            return ContarHojasRecursivo(nodo.Izq) + ContarHojasRecursivo(nodo.Der);
        }

        // Método para contar los nodos del árbol.
        public int ContarNodos()
        {
            return ContarNodosRecursivo(Raiz);
        }

        // Método recursivo para contar los nodos de un árbol.
        private int ContarNodosRecursivo(NodoBinario nodo)
        {
            // Si el nodo es nulo, retorna 0.
            if (nodo == null) return 0;
            // Retorna 1 más la suma de los nodos en los subárboles izquierdo y derecho.
            return 1 + ContarNodosRecursivo(nodo.Izq) + ContarNodosRecursivo(nodo.Der);
        }

        // Método para verificar si el árbol es completo.
        public bool EsArbolCompleto()
        {
            return EsArbolCompletoRecursivo(Raiz, 0, ContarNodos());
        }

        // Método recursivo para verificar si un árbol es completo.
        private bool EsArbolCompletoRecursivo(NodoBinario nodo, int index, int numeroNodos)
        {
            // Si el nodo es nulo, retorna verdadero.
            if (nodo == null) return true;
            // Si el índice es igual al número de nodos, retorna falso.
            if (index == numeroNodos) return false;
            // Retorna la verificación para los subárboles izquierdo y derecho.
            return EsArbolCompletoRecursivo(nodo.Izq, 2 * index + 1, numeroNodos) &&
                   EsArbolCompletoRecursivo(nodo.Der, 2 * index + 2, numeroNodos);
        }

        // Método para verificar si el árbol es lleno.
        public bool EsArbolLleno()
        {
            return EsArbolLlenoRecursivo(Raiz);
        }

        // Método recursivo para verificar si un árbol es lleno.
        private bool EsArbolLlenoRecursivo(NodoBinario nodo)
        {
            // Si el nodo es nulo, retorna verdadero.
            if (nodo == null) return true;
            // Si el nodo no tiene hijos, es una hoja y retorna verdadero.
            if (nodo.Izq == null && nodo.Der == null) return true;
            // Si el nodo tiene ambos hijos, verifica los subárboles.
            if (nodo.Izq != null && nodo.Der != null)
                return EsArbolLlenoRecursivo(nodo.Izq) && EsArbolLlenoRecursivo(nodo.Der);
            // Si el nodo no tiene ambos hijos, retorna falso.
            return false;
        }
    }
}