using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales
{
    public class NodoBinario
    {
        // Dato almacenado en el nodo.
        public int Dato;
        // Referencia al hijo izquierdo.
        public NodoBinario Izq;
        // Referencia al hijo derecho.
        public NodoBinario Der;

        // Constructor de la clase NodoBinario.
        public NodoBinario(int Dato)
        {
            // Inicializa el dato y establece los hijos como nulos.
            this.Dato = Dato;
            this.Izq = null;
            this.Der = null;
        }
    }
}