using System;

namespace Práctica_Clase_Semana_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedimos la información necesaria para el proceso
            Console.WriteLine("De tu ecuacion de forma ax^2 + bx + c = 0, introduce los términos a,b y c para encontrar la definición de X:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
         

            //Cálculamos el indice de masa corporal de cada persona
            double discriminante = Math.Pow(b, 2) - (4 * a * c);




            if (discriminante == 0)
            {
                double x1 = (-b ) / (2 * a);

                Console.WriteLine("Existe una única solucion para esta ecuacion y este posee una X = " + x1);
            }
            else if (discriminante > 0)
            {
                //Cálculamos las posibles X
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double X2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine("Existen dos posibles soluciones de X: ");
                Console.WriteLine("para X1, el valor es = " + x1);
                Console.WriteLine("para X1, el valor es = " + x1);
            }
            else
            {
                Console.WriteLine("No es posible cálcular esta ecuacion, mi bebe, magandi noda " );
            }
          
        }
    }
}
