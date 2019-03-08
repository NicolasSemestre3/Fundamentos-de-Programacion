using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, cartaRobada = 0;
            int total = 0, max = 0, indiceMax = 0;
            Console.WriteLine("ingrese el número de jugadores:");
            int n = int.Parse(Console.ReadLine());
            int[] jugadores = new int[n];
            int[] puntajes = new int[n];
            string Robar = "";
            
            for (int i = 0; i<n; i++)
            {
                jugadores[i] = i + 1;
                Console.WriteLine("Turno del jugador " + jugadores[i]);
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Tu primera carta: " + carta1);
                Console.WriteLine("Tu segunda carta: " + carta2);
                total = carta1 + carta2;
                Console.WriteLine("Tus puntos: " + total);
                Console.WriteLine("Desea Robar mas cartas? s/n");
                Robar = Console.ReadLine();
                while (Robar == "s" && total < 21)
                {
                    cartaRobada = aleatorio.Next(1, 11);
                    total = total + cartaRobada;
                    if (total >= 22)
                    {
                        Console.WriteLine("You Lose! La suerte no está de tu lado");
                        Console.WriteLine("Has robado un " + cartaRobada + " Pero te pasaste de 21");
                        Console.WriteLine("perdiste con " + carta1 + " " + carta2 + " " + cartaRobada + " para un total de " + total);
                        total = 0;
                        break;
                    }
                    else if (total == 21)
                    {
                        Console.WriteLine("Congratulations, Has robado un " + cartaRobada + " Para un limpio BlackJack");
                        Console.WriteLine("Has Ganado con " + carta1 + " " + carta2 + " " + cartaRobada);
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Acabas de robar un " + cartaRobada);
                        Console.WriteLine("posees: " + carta1 + " " + carta2 + " " + cartaRobada + " para un total de " + total);
                        Console.WriteLine("Deseas Robar mas cartas?");
                        Robar = Console.ReadLine();
                    }
                }
                puntajes[i] = total;
                if (total > max)
                {
                    max = total;
                    indiceMax = jugadores[i];
                }
                Console.WriteLine("Tu puntaje fue de: " + total);


            }
            Console.WriteLine("El Ganador es el jugador " + indiceMax + " Con " + max + "Puntos");
            

            
            Console.ReadLine();
            

        }
    }
}
