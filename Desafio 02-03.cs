using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Clase_2_No_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicialmente se pide una informacion para trabajar y se le asigna variables a dicha información
            Console.WriteLine("Ingrese porfavor el valor del Cateto del triángulo rectángulo llamada, Z ,y el valor en grados del ángulo Omega");
            double CZ = double.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine());
            double aGrados = 90 - cGrados;

            //Convertimos los datos ingresado a unos trabajables, en este caso de grados a radianes
            double a = aGrados * (Math.PI / 180);
            double c = cGrados * (Math.PI / 180);

            //Se encuentra el cateto, la hipotenusa y el ángulo interno del triángulo restante
            double H = CZ / Math.Sin(c);
            double CY = Math.Sin(a) * H;

            //Encontrada la información se presenta el resultado
            Console.WriteLine(" Con el cateto entregado y el ángulo conocido, se forma una Hipotenusa denominado H: " + H);
            Console.WriteLine(" Se encontró, segun la suma de ángulos internos del triángulo que el ángulo desconosido es alfa: " + aGrados);
            Console.WriteLine(" Con la Hipotenusa encontrada y el ángulo encontrado, se forma un Cateto denominado Y: " + CY);
        }
    }
}
