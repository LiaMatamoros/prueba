using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Program
    {
       
        
            static void Main(string[] args)
            {
            Console.WriteLine("      )O(======)O(======)O(======)O(======)O(======)O(======)O(");
            Console.WriteLine("      *                                                       *");
            Console.WriteLine("      |     ¡¡¡Holaa, por favor ingresa tu peso en Kg!!!     |");
            Console.WriteLine("      *                                                       *");
            Console.WriteLine("      )O(======)O(======)O(======)O(======)O(======)O(======)O(");

            Console.WriteLine("...........................................................................");
                                       double peso = Convert.ToDouble(Console.ReadLine());                               
            Console.WriteLine("...........................................................................");



            Console.WriteLine("      )O(======)O(======)O(======)O(======)O(======)O(======)O(");
            Console.WriteLine("      *                                                       *");
            Console.WriteLine("      |     ¡Muy bien! Ahora ingrese tu altura en metros :)   |");
            Console.WriteLine("      *                                                       *");
            Console.WriteLine("      )O(======)O(======)O(======)O(======)O(======)O(======)O(");

            Console.WriteLine("...........................................................................");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("...........................................................................");


            
            double indicecorporal = peso / (altura * altura);
            Console.WriteLine("Su Indice de masa corporal es de " + indicecorporal); if (indicecorporal > 29 && indicecorporal < 35)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("Usted se enceuntra en Obesidad I");
                Console.WriteLine("=============================================");

            }
            else if (indicecorporal >= 35 && indicecorporal < 40)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("Usted se encuentra en Obesidad II");
                Console.WriteLine("=============================================");

            }
            else if (indicecorporal >= 40)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("Usted se encuentra en Obesidad III ");
                Console.WriteLine("=============================================");

            }
            else if (indicecorporal >= 25 && indicecorporal < 30)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("Sobrepeso");
                Console.WriteLine("=============================================");

            }
            else if (indicecorporal >= 19 && indicecorporal < 25)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("Usted es saludable");
                Console.WriteLine("=============================================");

            }
            else
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("Estas demasiado delgado");
                Console.WriteLine("=============================================");

            }

            Console.ReadLine();
        }
    }

    }

