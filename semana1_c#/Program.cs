using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
        }

        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"{nombre}, Bienvenido a FA de {carrera}");
        }
        static void ejer2()
        {
            
            Console.WriteLine("\"cristhofer\"");

        }
        static void ejer3()
        {
            Console.Write("ingrese su primer valor x:");
            int x = int.Parse(Console.ReadLine());

            Console.Write("ingrese su segundo valor y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("suma :" + (x + y));
            Console.WriteLine("resta :" + (x - y));
            Console.WriteLine("multiplicacion :" + (x * y));
            Console.WriteLine("division :" + ((double)x / (double)y));
        }
        static void ejer4()
        {

        }
        static void ejer5()
        {

        }
        static void ejer6()
        {

        }
    }
}
