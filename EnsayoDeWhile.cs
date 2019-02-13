using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Máximos_y_Mínimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requerimos una entrada de datos para comenzar
            int edad = 0;
            double total = 0;
            int contador = 0;
            int maxima = 0;
            int minima = 150;
            string opcion = "si";
            string nombreMayor = "nadie";
            string nombreMenor = "nadie";

            //Comenzamos el ciclo
            while (opcion == "si")
            {
                //requerimos los datos
                Console.WriteLine("Dime tu nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingresa tu edad: ");
                edad = int.Parse(Console.ReadLine());

                //Comenzamos el condicional
                if (edad > maxima)
                {
                    maxima = edad;
                    nombreMayor = nombre;
                }

                if (edad < minima)
                {
                    minima = edad;
                    nombreMenor = nombre;
                }

                contador += 1;
                total += edad;

                Console.Write("Deseas continura:");
                opcion = Console.ReadLine();

            }

            //calculamos
            double media = total / contador;

            //Sacamos la informacion
            Console.WriteLine("la media es : " + media);
            Console.WriteLine("la edad mayor fue: " + maxima);
            Console.WriteLine("Su nombre fue: " +nombreMayor);
            Console.WriteLine("la edad menor fue: " + minima);
            Console.WriteLine("Su nombre fue: " + nombreMenor);
        }
    }
}
