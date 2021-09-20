using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            double numero2 = double.Parse(Console.ReadLine());

            double resto = numero / numero2;

            if (numero == numero2)
            {
                double elevoAlCuadrado = Math.Pow(numero, 2);
                Console.WriteLine("El cuadrado es: " + elevoAlCuadrado);
            }
            if (numero % numero2 == 0)
            {
                double resta = numero - numero2;
                Console.WriteLine("La resta es: " + resta);
            }
            if (resto > 3)
            {
                Console.WriteLine("El resto es mayor a 3");
            }
            else
            {
                Console.WriteLine("El resto es: " + resto);
            }


            Console.ReadKey();
        }
    }
}
