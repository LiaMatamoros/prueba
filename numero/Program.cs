using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*           *                                                   *           *");
            Console.WriteLine("|       *       *   ¡¡¡Ingrese el tamaño del arreglo: !!!   *        *      |");
            Console.WriteLine("*   *               *                                  *                 *  *");

       
            int tamaño = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tamaño];
            Console.Clear();

            Console.WriteLine(")O(======)O(======)O(======)O(======)O(======)O(======)O(");
            Console.WriteLine("           Ingrese los elementos del arreglo             ");
            Console.WriteLine(")O(======)O(======)O(======)O(======)O(======)O(======)O(");

            for (int i = 0; i < tamaño; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            BubbleSort(numeros);

            Console.WriteLine(")O(======)O(======)O(======)O(======)O(======)O(======)O(");
            Console.WriteLine("         Ingrese el número que desea buscar:             ");
            Console.WriteLine(")O(======)O(======)O(======)O(======)O(======)O(======)O(");

            int numerobuscar = Convert.ToInt32(Console.ReadLine()); 
            int indice = BusquedaBinaria(numeros, numerobuscar);

            if (indice != -1)
            {
                Console.WriteLine("...........................................................................");
                Console.WriteLine("El número se encuentra en el índice " + indice + " delarreglo.");
                Console.WriteLine("...........................................................................");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("...........................................................................");
                Console.WriteLine("El número no se encuentra en el arreglo.");
                Console.WriteLine("...........................................................................");
                Console.ReadKey();
            }
        }
        static void BubbleSort(int[] arreglo)
        {
            int n = arreglo.Length; for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j]; arreglo[j] = arreglo[j + 1]; arreglo[j + 1] = temp;
                    }
                }
            }
        }
        private static int BusquedaBinaria(int[] arreglo, int valor)
        {
            int inicio = 0; int fin = arreglo.Length - 1;
            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2; if (arreglo[medio] == valor)
                {
                    return medio;
                }
                else if (arreglo[medio] < valor)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }
            return -1;
        }
    }
}

        
    

