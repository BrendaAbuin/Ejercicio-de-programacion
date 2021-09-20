using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int precioPorDia = 100;

            Console.WriteLine("Ingrese a que continente quiere viajar");
            string continente = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de dias a viajar");
            int cantidadDias = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el metodo de pago");
            string metodoPago = Console.ReadLine();

            ValidarContinente(continente);

            ValidarMetodoDePago(metodoPago);

            Viajes(continente, metodoPago, precioPorDia, cantidadDias);


            Console.ReadKey();
        }

        static bool ValidarContinente(string continente)
        {
            if (continente == "america" || continente == "asia" || continente == "europa" || continente == "africa" || continente == "oceania")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ValidarMetodoDePago(string metodoPago)
        {
            if (metodoPago == "debito" || metodoPago == "credito" || metodoPago == "efectivo" || metodoPago == "mercado pago" || metodoPago == "cheque" || metodoPago == "leliq")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Viajes(string continente, string metodoPago, int precioPorDia, int cantidadDias)
        {
            double totalPrecio = precioPorDia * cantidadDias;
            double precioAmerica;
            double precio15;
            double precioMasDescuento;
            double precioDiez;
            double precioTreintaDescuento;
            double precioAfricaYOceania;
            double descuentoQuince;
            double descuentoEnAfrica;
            double descuentoVeinteEuropa;
            double precioEuropa;
            double descuentoQuinceEuropa;
            double descuentoEuropa;
            double descuentoDiezEuropa;
            double europaMercadoPago;
            double descuentoOtroMedio;
            double descuentoTotal;
            double recargo;
            double recargoTotal;
            double cheque;
            double chequeTotal;

            if (continente == "america")
            {
                precio15 = totalPrecio * 0.15;
                precioAmerica = totalPrecio - precio15;
                Console.WriteLine("El descuento por viajar America es del 15 %, el total es: " + precioAmerica);

                if (metodoPago == "debito")
                {
                    precioMasDescuento = (totalPrecio * 0.25);
                    precioDiez = totalPrecio - precioMasDescuento;
                    Console.WriteLine("Por pagar con debito y viajar a america el total es: " + precioDiez);
                }
            }
            if (continente == "africa" || continente == "oceania")
            {
                precioTreintaDescuento = totalPrecio * 0.30;
                precioAfricaYOceania = totalPrecio - precioTreintaDescuento;
                Console.WriteLine("El precio por viajar a Oceania y Africa es de: " + precioAfricaYOceania);


                if (metodoPago == "mercado pago" || metodoPago == "efectivo")
                {
                    descuentoQuince = (totalPrecio * 0.45);
                    descuentoEnAfrica = totalPrecio - descuentoQuince;
                    Console.WriteLine($"Por pagar con mercado pago o efectivo el total es: {descuentoEnAfrica}");
                }
            }
            if (continente == "europa")
            {
                descuentoVeinteEuropa = totalPrecio * 0.20;
                precioEuropa = totalPrecio - descuentoVeinteEuropa;
                Console.WriteLine("El total por viajar a europa es: " + precioEuropa);

                if (metodoPago == "debito")
                {
                    descuentoQuinceEuropa = (totalPrecio * 0.35);
                    descuentoEuropa = totalPrecio - descuentoQuinceEuropa;
                    Console.WriteLine("El total por viajar a europa y pagar con debito es de: " + descuentoEuropa);
                }
                if (metodoPago == "mercado pago")
                {
                    descuentoDiezEuropa = (totalPrecio * 0.30);
                    europaMercadoPago = totalPrecio - descuentoDiezEuropa;
                    Console.WriteLine("Por pagar con mercado pago el total es de: " + europaMercadoPago);
                }
                if (metodoPago != "debito" && metodoPago != "mercado pago")
                {
                    descuentoOtroMedio = (totalPrecio * 0.25);
                    descuentoTotal = totalPrecio - descuentoOtroMedio;
                    Console.WriteLine("El total por viajar a europa y pagar con otro medio es: " + descuentoTotal);
                }
            }
            if (metodoPago == "cheque")
            {
                cheque = totalPrecio * 0.15;
                chequeTotal = totalPrecio + cheque;
                Console.WriteLine("Si pagas con cheque el recargo es del 15%, el total es de: " + chequeTotal);
            }
            else
            {
                recargo = totalPrecio * 0.20;
                recargoTotal = totalPrecio + recargo;
                Console.WriteLine("Por viajar a Asia el total es de: " + recargoTotal);
            }
        }
    }
}
