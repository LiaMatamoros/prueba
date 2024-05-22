using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nahim", "Aracely", "Roberto", "Freedman", "Jordan", "Luzneiry",
                                 "Ana", "Bruno", "Carlos", "Diana", "Elena", "Felipe", "Gabriela", 
                                 "Hector", "Isabel", "Jorge", "Wendy", "Ximena", "Yolanda"};

            Console.WriteLine("====================================================");
            Console.WriteLine("      )0(   Ingrese el nombre a buscar   )0(        ");
            Console.WriteLine("====================================================");
            Console.WriteLine("...........................................................................");
            string buscar = Console.ReadLine(); bool encontrado = nombrelista(nombres, buscar);
            Console.WriteLine("...........................................................................");

            if (encontrado)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("El nombre se encuentra en la lista :D        ");
                Console.WriteLine("=============================================");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("El nombre no se encuentra en la lista :(     ");
                Console.WriteLine("=============================================");

                Console.ReadKey();
            }
        }
        static bool nombrelista(string[] arreglo, string valor)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
    
}
