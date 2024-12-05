using System;

namespace Algoritmos_recursividad
{
    class BinarySearch
    {
        // Método estático que realiza una búsqueda binaria en un arreglo ordenado
        // array: el arreglo en el que se busca
        // target: el elemento que se desea encontrar
        // low: el índice más bajo del rango de búsqueda
        // high: el índice más alto del rango de búsqueda
        public static int Run(int[] array, int target, int low, int high)
        {
            // Caso base: si el rango de búsqueda es vacío, el elemento no se encuentra
            if (low > high)
                return -1;

            // Calcula el índice medio del rango actual
            int mid = (low + high) / 2;

            // Si el elemento en el índice medio es el objetivo, devuelve su índice
            if (array[mid] == target)
                return mid;
            // Si el elemento objetivo es mayor que el elemento medio,
            // busca en la mitad derecha del arreglo
            else if (array[mid] < target)
                return Run(array, target, mid + 1, high);
            // Si el elemento objetivo es menor que el elemento medio,
            // busca en la mitad izquierda del arreglo
            else
                return Run(array, target, low, mid - 1);
        }
    }
}