using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Clase_2_No_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicialmente se pide una informacion para trabajar y se le asigna variables a dicha información
            Console.WriteLine("Ingrese porfavor el valor de la hipotenusa del triángulo rectángulo llamada, H ,y el valor en grados del ángulo Alfa");
            double H = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());
            double cGrados = 90 - aGrados;

            //Convertimos los datos ingresado a unos trabajables, en este caso de grados a radianes
            double a = aGrados * (Math.PI / 180);
            double c = cGrados * (Math.PI / 180);

            //Se encuentra los catetos y el ángulo interno del triángulo restante
            double CY = Math.Sin(a) * H;
            double CZ = Math.Sin(c) * H;
 
            //Encontrada la información se presenta el resultado
            Console.WriteLine(" Con la Hipotenusa entregada y el ángulo conocido, se forma un Cateto denominado Y: " + CY);
            Console.WriteLine(" Se encontró, segun la suma de ángulos internos del triángulo que el ángulo desconosido es omega: " + cGrados);
            Console.WriteLine(" Con la Hipotenusa entregada y el ángulo encontrado, se forma un Cateto denominado Z: " + CZ);

        }
    }
}
