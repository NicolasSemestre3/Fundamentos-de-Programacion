using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01_04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primero pedimos el ingreso de los datos
            Console.WriteLine("Ingresa la hipotenusa del triangulo exterior o mayor y la hipotenusa del triangulo rectangulo inscrito con su respectivo ángulo formado con la base:");
            double H = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine());

            //encontramos términos relacionados con la información dada
            double eGrados = 180 - cGrados;
            double e = eGrados * (Math.PI / 180);
            double d = Math.Asin((h * Math.Sin(e)) / H);
            double dGrados = d * (180 / Math.PI);

            //Ahora con ya los grados encontramos el ángulo del lado requerido
            double bGrados = 180 - dGrados - eGrados;
            double b = bGrados * (Math.PI / 180);
            double CX = (H * Math.Sin(b)) / Math.Sin(e);

            //Enunciamos el resultado
            Console.WriteLine("El segmento que completa la base del triangulo exterior es:" + CX);



        }
    }
}
