using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuestaN;
            string colorVehiculo;
            int precio;
            int cantidadDeAutosRojos = 0;
            int cantidadDeAutosRojosMayor = 0;
            int cantidadMenor = 0;
            int precioMasCaro = int.MinValue;
            string colorCaro = "";
            int cantidadVehiculos = 0;
            int precioVehiculos = 0;


            do
            {

                do
                {
                    Console.WriteLine("Ingrese el color del vehiculo");
                    colorVehiculo = Console.ReadLine();

                } while (colorVehiculo != "rojo" && colorVehiculo != "verde" && colorVehiculo != "amarillo");

                do
                {
                    Console.WriteLine("ingrese el precio");
                    precio = int.Parse(Console.ReadLine());

                } while (precio < 0 && precio >= 10000);

                cantidadVehiculos++;
                precioVehiculos += precio;

                if (colorVehiculo == "rojo")
                {
                    cantidadDeAutosRojos++;

                    if (precio > 5000)
                    {
                        cantidadDeAutosRojosMayor++;
                    }
                }

                if (precio < 5000)
                {
                    cantidadMenor++;
                }

                if (precioMasCaro < precio)
                {
                    precioMasCaro = precio;
                    colorCaro = colorVehiculo;
                }

                Console.WriteLine("Si quiere seguir ingresando datos escriba 'si', si quiere el informe escriba 'no'");
                respuestaN = Console.ReadLine();

            } while (respuestaN != "no");

            int promedioVehiculos = precioVehiculos / cantidadVehiculos;


            Console.WriteLine("La cantidad de autos rojos: " + cantidadDeAutosRojos);
            Console.WriteLine("La cantidad de rojos con precio mayor a 5000: " + cantidadDeAutosRojosMayor);
            Console.WriteLine("La cantidad de vehículos con precio inferior a 5000: " + cantidadMenor);
            Console.WriteLine("El promedio de todos los vehículos ingresados: " + promedioVehiculos);
            Console.WriteLine($"El más caro sale {precioMasCaro} y su color es {colorCaro}");

            Console.ReadKey();
        }
    }
}
