using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilos;
            string sabor;
            int kilosMenores = int.MaxValue;
            string saborDiferente = "";
            int sumaKilos = 0;
            int cantidadBolsas = 0;
            int kilosTotalesCarne = 0;

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese los kilos de la bolsa de alimentos");
                    kilos = int.Parse(Console.ReadLine());

                } while (kilos < 0 || kilos > 500);
                do
                {
                    Console.WriteLine("Ingrese el sabor");
                    sabor = Console.ReadLine();

                } while (sabor != "carne" && sabor != "pollo" && sabor != "vegetales");

                sumaKilos += kilos;

                if (kilos < kilosMenores)
                {
                    kilosMenores = kilos;
                    saborDiferente = sabor;
                }
                if (sabor == "carne")
                {
                    cantidadBolsas++;
                    kilosTotalesCarne += kilos;
                }
            }
            int promedioKilosTotales = sumaKilos / 3;
            int promedioKilosCarne = kilosTotalesCarne / cantidadBolsas;

            Console.WriteLine(sumaKilos);
            Console.WriteLine("El promedio de kilos totales es: " + promedioKilosTotales);
            Console.WriteLine($"La bolsa mas livina pesa {kilosMenores} y su sabor es {saborDiferente}");
            Console.WriteLine("La cantidad de bolsas de carne es: " + cantidadBolsas + " y el promedio de kilos es: " + promedioKilosCarne);


            Console.ReadKey();
        }
    }
}
