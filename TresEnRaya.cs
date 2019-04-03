using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "o", "x" };
            int n = 10;
            int m = 15;
            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {

                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";

                }
            }

            Console.WriteLine("\nEntrada: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {

                    Console.Write("|" + tablero[i, j]);

                }
                Console.Write("|\n");
            }

            int x = 0;
            int y = 0;
            bool noPasaLimitesPositivos = (x + 1 <= tablero.GetLongLength(0) && y + 1 <tablero.GetLongLength(1)) || (x + 1 <= tablero.GetLongLength(0) && y + 1 < tablero.GetLongLength(1));
            bool noPasaLimitesNegativos = (x - 1 >= 0 && y - 1 >= 0) || (x - 2 >= 0 && y - 2 >= 0);

            bool repeticionXpositiva = tablero[x, y] == tablero[x + 1, y + 1] && tablero[x,y] == tablero[x + 2, y + 2];
            bool repeticionXpositivaNegativa = tablero[x, y] == tablero[x + 1, y + 1] && tablero[x, y] == tablero[x - 1, y - 1];

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                x = i;
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    y = j;
                    if (positivo && ) ;

                }
            }

            Console.WriteLine("\nSalida:");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {

                    Console.Write("|" + salida[i, j]);

                }
                Console.Write("|\n");
            }
            Console.Write("\n");
        }
    }
}
