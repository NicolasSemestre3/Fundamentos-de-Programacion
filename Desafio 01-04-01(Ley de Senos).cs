using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se pide la Información que requerimos para poder operar
            Console.WriteLine("Ingrese los valores de los catetos de un triangulo rectangulo, Z y Y, que esta inscrito a otro y el angulo Beta que es formado por la hipotenusa del triangulo inscrito con la hipotenusa del triangulo exterior:");
            double CZ = double.Parse(Console.ReadLine());
            double CY = double.Parse(Console.ReadLine());
            double bGrados = double.Parse(Console.ReadLine());

            //Se utiliza la formula para convertir los grados ingresados en radianes
            double b = bGrados * (Math.PI / 180);

            //Se encuntran ángulos adicionales para el triangulo inscrito
            double c = Math.Atan(CZ / CY);
            double cGrados = c * (180 / Math.PI);
            double aGrados = 180 - 90 - cGrados;

            //Se encuentran ángulos para el triángulo exterior
            double eGrados = 180 - cGrados;
            double dGrados = 180 - bGrados - eGrados;
            double d = dGrados * (Math.PI / 180);

            //Encontramos la Hipotenusa del triangulo inscrito y el segmento requerido
            double H = Math.Sqrt(Math.Pow(CZ , 2) + Math.Pow(CY , 2));
            double CX = H  * Math.Sin(b);

            //Enunciamos el resultado
            Console.WriteLine("Con la información ingresada se determino que el cateto opueso al ángulo Beta, llamado X, es =" + CX);
            //Console.WriteLine(b);
            //Console.WriteLine(H);
            //Console.WriteLine(d);


        }
    }
}
