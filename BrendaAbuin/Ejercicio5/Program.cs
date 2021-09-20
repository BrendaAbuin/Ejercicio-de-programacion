using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuestaN;
            string nombre;
            int edad;
            char sexo;
            double notaFinal;
            int cantidadVaronesAprobados = 0;
            double notasMenoresDeEdad = 0;
            double cantidadDeMenores = 0;
            double cantidadAdolescentes = 0;
            double notasAdolescentes = 0;
            double cantidadMayores = 0;
            double notasMayores = 0;
            double cantidadM = 0;
            double notasM = 0;
            double cantidadF = 0;
            double notasF = 0;

            do
            {

                Console.WriteLine("Ingrese nombre de un estudiante");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su edad");
                edad = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Ingrese el sexo");
                    sexo = char.Parse(Console.ReadLine());

                } while (sexo != 'f' && sexo != 'm');

                do
                {
                    Console.WriteLine("Ingrese la nota final");
                    notaFinal = double.Parse(Console.ReadLine());

                } while (notaFinal < 0 || notaFinal > 10);


                if (sexo == 'm' && notaFinal >= 4)
                {
                    cantidadVaronesAprobados++;
                }
                if (edad < 18)
                {
                    cantidadDeMenores++;
                    notasMenoresDeEdad += notaFinal;
                }
                if (edad >= 13 || edad < 18)
                {
                    cantidadAdolescentes++;
                    notasAdolescentes += notaFinal;
                }
                if (edad >= 18)
                {
                    cantidadMayores++;
                    notasMayores += notaFinal;
                }
                if (sexo == 'm')
                {
                    cantidadM++;
                    notasM += notaFinal;
                }
                if (sexo == 'f')
                {
                    cantidadF++;
                    notasF += notaFinal;
                }

                Console.WriteLine("Si quiere seguir ingresando datos escriba 'si', de lo contrario escriba 'no'");
                respuestaN = Console.ReadLine();

            } while (respuestaN != "no");

            double promedioMenoresDeEdad = notasMenoresDeEdad / cantidadDeMenores;
            double promedioAdolescente = notasAdolescentes / cantidadAdolescentes;
            double promedioMayores = notasMayores / cantidadMayores;
            double promedioM = notasM / cantidadM;
            double promedioF = notasF / cantidadF;

            Console.WriteLine("La cantidad de varones aprobados: " + cantidadVaronesAprobados);
            Console.WriteLine("El promedio de las notas de los menores de edad: " + promedioMenoresDeEdad);
            Console.WriteLine("El promedio de notas de los adolescentes: " + promedioAdolescente);
            Console.WriteLine("El promedio de notas de los mayores: " + promedioMayores);
            Console.WriteLine("El promedio de notas para el sexo femenino: " + promedioF);
            Console.WriteLine("El promedio de notas para el sexo masculino: " + promedioM);

            Console.ReadKey();
        }
    }
}
