using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_stringos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Narramos
            Console.WriteLine("Hola, soy Failsafe, y hoy vamos a analizar una frase, si... ya me estoy quedando sin ninguna idea...");
            Console.WriteLine("\nIngresa una hermosa frase");
            string frase = Console.ReadLine();

            Console.WriteLine("\nLa oracion que ingresaste posee palabras... :V, dime que palabras deseas idenficiar en esta frase");
            string palabra = Console.ReadLine();

            //Acomodamos
            frase = frase.ToLower();

            //Requerimos Variables
            int vecesRepetida = 0;

            //verificamos el nuemero de veces repetida
            for (int k = 0; k < frase.Length; k++)
            {
                char letraActual = frase[k];
                char letra = palabra[0];
                int sequitoParecido = 0;

                if (letraActual == letra)
                {
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (palabra[i] == frase[k + i])
                        {
                            sequitoParecido++;
                        }
                    }

                    if (sequitoParecido == palabra.Length)
                    {
                        vecesRepetida++;
                    }
                    
                }
            }

            int[] posicion = new int[vecesRepetida];

            //Guardamos la posicion de la letra repetida
            int externalCounter = 0;
            for (int k = 0; k < frase.Length; k++)
            {
                char letraActual = frase[k];
                char letra = palabra[0];
                int sequitoParecido = 0;

                if (letraActual == letra)
                {
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (palabra[i] == frase[k + i])
                        {
                            sequitoParecido++;
                        }
                    }

                    if (sequitoParecido == palabra.Length)
                    {
                        posicion[externalCounter] = k;
                        externalCounter++;
                    }

                }
            }

            //Mostramos resultados
            Console.Write("\n\nLa palabra " + palabra + " se repite un total de " + vecesRepetida + " y esto ocurre en las posiciones ");
            for (int i = 0; i < posicion.Length; i++)
            {
                Console.Write((posicion[i] + 1) + "°, ");
            }
            Console.WriteLine("para está frase.");


        }
    }
}
