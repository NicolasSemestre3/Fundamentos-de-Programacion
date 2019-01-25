using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Clase_2_No_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicialmente se pide una informacion para trabajar y se le asigna variables a dicha información
            Console.WriteLine("Ingrese porfavor los valores de dos catetos pertenecientes a un triángulo rectángulo, llamados Y, Z");
            double CY = double.Parse(Console.ReadLine());
            double CZ = double.Parse(Console.ReadLine());

            //Se encuentra la hipotenusa y los ángulos internos del triángulo en cuestion
            double H = Math.Sqrt((CY * CY) + (CZ * CZ));
            double a = Math.Asin(CY / H);
            double c = Math.Asin(CZ / H);

            //Convertir los ángulos a grados
            double aGrados = a * (180 / Math.PI);
            double cGrados = c * (180 / Math.PI);

            //Encontrada la información se presenta el resultado
            Console.WriteLine(" Se encontro con los catetos dados que, el triangulo formado, posee una Hipotenusa igual a: " + H);
            Console.WriteLine(" Se encontro que el Cateto Y y la hipotenusan forman un ángulo interno de: " + aGrados);
            Console.WriteLine(" Se encontro que el Cateto Z y la hipotenusan forman un ángulo interno de: " + cGrados);

        }
    }
}
