using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01_04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se pide la Información que requerimos para poder operar
            Console.WriteLine("Ingrese los valores de los ángulos formados por la hipotenusa de un triangulo rectangulo, Beta y Delta (siendo Beta la diferencia entre el ángulo del triángulo externo y un ángulo del triangulo inscrito en el); Ademas ingrese el cateto Y del triángulo rectángulo inscrito en el:");
            double bGrados = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double CY = double.Parse(Console.ReadLine());

            //Se cálcula el ángulo restante del triángulo cuyos ángulos internos son Beta y Delta
            double eGrados = 180 - bGrados - dGrados;

            //Se encuentra el ángulo cuyo cateto adyacente es CY
            double cGrados = 180 - eGrados;
            double c = cGrados * (Math.PI / 180);

            //Se encuentra la altura compartida por ambos triángulos o mejor dicho su cateto Z
            double CZ = Math.Tan(c) * CY;

            Console.WriteLine("El cateto encontrado que es la altura comun tanto del triángulo exterior como el triángulo inscrito es = " + CZ);
        }
    }
}
