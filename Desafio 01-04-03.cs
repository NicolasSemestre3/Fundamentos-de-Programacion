using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01_04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se pide la Información que requerimos para poder operar
            Console.WriteLine("Ingrese la hipotenusa de un triangulo rectangulo, la cual, forma con la base un ángulo Delta y que dicha base es la suma de un segmento X, que se debe ingresar, y la base de un triángulo inscrito en él:");
            double H = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double CX = double.Parse(Console.ReadLine());

            //Se transforma el ángulo ingresado a radianes
            double d = dGrados * (Math.PI / 180);

            //Se aplica la definicion definicion de coseno para tríangulos rectángulos
            double CY = (Math.Cos(d) * H) - CX;

            //Enuncia los resultados
            Console.WriteLine("El cateto o base del triángulo inscrito es =" + CY);
        }
    }
}
