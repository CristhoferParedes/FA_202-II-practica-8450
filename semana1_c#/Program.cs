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
            ejer5();
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
            Console.WriteLine("Ingrese un numero decimal:");
            double num = double.Parse(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num,0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1/3d);

            Console.WriteLine("raiz 2: " + raiz2);
            Console.WriteLine("Redondeado: " + redo);
            Console.WriteLine("al cubo: " + cubo);
            Console.WriteLine("raiz 3: " + raiz3);


        }
        static void ejer5()
        {
            Console.WriteLine("Ingrese numero: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("resto " + (entero%2));
            Console.WriteLine("resto " + (deci/3));
        }
        static void ejer6()
        {

        }
    }
}
