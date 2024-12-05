using System;

namespace EDDemo.Ordenamiento.Clases
{
    public class RadixSort
    {
        // Método para ordenar un arreglo de enteros utilizando el algoritmo de ordenación Radix Sort
        public void Ordenar(int[] datos)
        {
            if (datos == null || datos.Length == 0)
            {
                throw new ArgumentException("El arreglo está vacío o es nulo, no se puede ordenar.");
            }

            // Separa los números positivos y negativos
            int[] positivos = Array.FindAll(datos, x => x >= 0);
            int[] negativos = Array.FindAll(datos, x => x < 0);

            // Ordena los números positivos
            RadixSortAlgorithm(positivos);

            // Ordena los números negativos en valor absoluto
            for (int i = 0; i < negativos.Length; i++)
            {
                negativos[i] = -negativos[i]; // Convierte a positivo para ordenación
            }
            RadixSortAlgorithm(negativos);
            for (int i = 0; i < negativos.Length; i++)
            {
                negativos[i] = -negativos[i]; // Vuelve a convertir a negativo
            }
            Array.Reverse(negativos); // Invierte el orden para los negativos

            // Fusiona negativos y positivos
            Array.Copy(negativos, 0, datos, 0, negativos.Length);
            Array.Copy(positivos, 0, datos, negativos.Length, positivos.Length);
        }

        // Método para implementar el algoritmo Radix Sort (para números positivos)
        private void RadixSortAlgorithm(int[] datos)
        {
            if (datos.Length == 0) return;

            int max = GetMax(datos); // Encuentra el valor máximo en el arreglo

            // Realiza la ordenación basada en cada dígito, aumentando la posición del dígito en cada iteración
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                OrdenarPorDigito(datos, exp);
            }
        }

        // Método para ordenar los datos en función de un dígito específico
        private void OrdenarPorDigito(int[] datos, int exp)
        {
            int n = datos.Length;
            int[] output = new int[n]; // Arreglo de salida
            int count = 10; // Base 10

            // Inicializa el conteo
            int[] countArray = new int[count];
            for (int i = 0; i < n; i++)
            {
                int digit = (datos[i] / exp) % 10;
                countArray[digit]++;
            }

            // Cambia count[i] para que contenga la posición real de este dígito en output[]
            for (int i = 1; i < count; i++)
            {
                countArray[i] += countArray[i - 1];
            }

            // Construye el arreglo de salida
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (datos[i] / exp) % 10;
                output[countArray[digit] - 1] = datos[i];
                countArray[digit]--;
            }

            // Copia el arreglo de salida a datos[], para que contenga los números ordenados según el dígito actual
            Array.Copy(output, datos, n);
        }

        // Método para encontrar el valor máximo en un arreglo
        private int GetMax(int[] datos)
        {
            int max = datos[0];
            for (int i = 1; i < datos.Length; i++)
            {
                if (datos[i] > max)
                {
                    max = datos[i];
                }
            }
            return max;
        }
    }
}