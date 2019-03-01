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
            Console.WriteLine("Saludos soy Failsafe, hoy capitan verems si las coordenadas introducidas pertenecen al trayecto recto de nuestro viaje,... ya estoy viendo quien será el que extrelle el nuevo Exodo Negro.");

            double[] coordenadaX = { 0, 0, 0, 0 };
            double[] coordenadaY = { 0, 0, 0, 0 };

            double[] m = { 0, 0, 0, 0 };
            double[] b = { 0, 0, 0, 0 };
            double[] distancias = { 0, 0, 0, 0 };

            for(int contador = 0; contador < 3; contador ++)
            {
                //pedimos los puntos
                Console.WriteLine("Capitan dames las coordenadas de el lugar No" + (contador + 1) + " en X");
                coordenadaX[contador] = double.Parse(Console.ReadLine());

                //pedimos los puntos
                Console.WriteLine("Capitan dames las coordenadas de el lugar No" + (contador + 1) + " en Y");
                coordenadaY[contador] = double.Parse(Console.ReadLine());

                //Narramos
                Console.WriteLine("\n\nGrabando");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");
            }

            //calculamos

            for(int contadorM = 0; contadorM < 2; contadorM++)
            {
                //Calculamos pendiente
                m[contadorM] = (coordenadaY[contadorM + 1] - coordenadaY[contadorM]) / (coordenadaX[contadorM + 1] - coordenadaY[contadorM]);
            }

            for (int contadorB = 0; contadorB < 2; contadorB++)
            {
                //Calculamos b
                b[contadorB] = coordenadaY[contadorB] - (m[contadorB] * coordenadaX[contadorB]);
            }

            //clasificamos
            for (int contadorRecta = 0; contadorRecta < 2; contadorRecta++)
            {
                if (m[contadorRecta] == m[contadorRecta + 1] && b[contadorRecta] == b[contadorRecta + 1])
                {
                    Console.WriteLine("el punto (" + coordenadaX[contadorRecta] + " , " + coordenadaY[contadorRecta] + ") y el punto (" + coordenadaX[contadorRecta + 1] + " , " + coordenadaY[contadorRecta + 1] + ") Estan en la misma recta"); 
                }
                else
                {
                    Console.WriteLine("el punto (" + coordenadaX[contadorRecta] + " , " + coordenadaY[contadorRecta] + ") y el punto (" + coordenadaX[contadorRecta + 1] + " , " + coordenadaY[contadorRecta + 1] + ") Estan en una diferente recta");
                }
            }

            //distancia
            double mayorDistancia = 0;
            double puntoInicialX = 0;
            double puntoFinalX = 0;
            double puntoInicialY = 0;
            double puntoFinalY = 0;

            for (int contadorD = 0; contadorD < 2; contadorD++)
            {
                distancias[contadorD] = Math.Sqrt(Math.Pow((coordenadaX[contadorD] - coordenadaX[contadorD + 1]), 2) + Math.Pow((coordenadaY[contadorD] - coordenadaY[contadorD + 1]), 2));

                if(distancias[contadorD] > mayorDistancia)
                {
                    mayorDistancia = distancias[contadorD];
                    puntoInicialX = coordenadaX[contadorD];
                    puntoFinalX = coordenadaX[contadorD + 1];
                    puntoInicialY = coordenadaY[contadorD ];
                    puntoFinalY = coordenadaY[contadorD + 1];
                }
            }

            Console.WriteLine("La mayor distancia fue : " + mayorDistancia);
            Console.WriteLine("Entre el punto (" + coordenadaX[puntoFinalX] + " , " + coordenadaY[puntoFinalY] + ") y el punto (" + coordenadaX[] + " , " + coordenadaY[contadorRecta + 1] + ") Estan en la misma recta");

        }
    }
}
