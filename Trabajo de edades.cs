using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pedimos informacion inicial
            Console.WriteLine("Saludos soy Failsafe, hoy capitan tendremos una fiesta, de no muchos invitados, dame sus nombres y edades..., no es como si fuesemos a hacer algo muy loco :V....");
            Console.WriteLine("\nDime cuandos vendran...");
            int tamaño = int.Parse(Console.ReadLine());

            int[] edades = new int [tamaño];
            string[] nombres = new string [tamaño];

            int edadMayor = 0;
            int edadMenor = 99;
            string nombreMayor = "X";
            string nombreMenor;

            double totalEdades = 0;
            double totalDesviable = 0;

            double diferenciaEdades = 99;
            string nombreCercaPromedio = "X";



            for (int contador = 0; contador < tamaño; contador++)
            {
                //pedimos los nombres
                Console.WriteLine("\n\nCapitan dame el nombre de el " + (contador + 1) + "° invitado ");
                nombres[contador] = Console.ReadLine();

                //pedimos las edades
                Console.WriteLine("\nCapitan dame la edad de " + nombres[contador]);
                edades[contador] = int.Parse(Console.ReadLine());

                //Calculamos
                totalEdades += edades[contador];


                //Narramos
                Console.WriteLine("\n\nGrabando");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");

                //grabamos al mayor
                if (edades[contador] > edadMayor)
                {
                    edadMayor = edades[contador];
                    nombreMayor = nombres[contador];
                }

                //Grabamos al menor
                if (edades[contador] < edadMenor )
                {
                    edadMenor = edades[contador];
                    nombreMenor = nombres[contador];
 
                }
            }

            //Enunciamos al mayor y menor
            Console.WriteLine("\n\nDe tus invitados el mayor fue: " + nombreMayor + " con la edad de: " + edadMayor);
            Console.WriteLine("\nDe tus invitados el menor fue: " + nombreMayor + " con la edad de: " + edadMenor);

            //Promediamos
            double promedio = totalEdades / tamaño;

            for(int contadorDiferencias = 0; contadorDiferencias < tamaño; contadorDiferencias++)
            {
                if (Math.Abs(edades[contadorDiferencias] - promedio) < diferenciaEdades)
                {
                    diferenciaEdades = Math.Abs(edades[contadorDiferencias] - promedio);
                    nombreCercaPromedio = nombres[contadorDiferencias];
                }
            }

            //Enunciamos
            Console.WriteLine("\n\nEl promedio de edades fue: " + promedio + " y la persona con la edad mas cercana a esta es... " + nombreCercaPromedio);

            //desviamos
            for (int contadorDesviable = 0; contadorDesviable < tamaño ; contadorDesviable++)
            {
                totalDesviable += Math.Pow((promedio - edades[contadorDesviable]), 2);
            }

            double desviacion = Math.Sqrt(totalDesviable / tamaño);

            Console.WriteLine("\nLa desviacion fue de: " + desviacion);
        }
    }
}