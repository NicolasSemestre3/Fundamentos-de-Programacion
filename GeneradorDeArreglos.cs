using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Imposible_Parte_1
{
    class GeneradorDeArreglos
    {
        //Generamos los arreglos de los dos conjuntos y sus tamaños
        public int[] conjuntoA;
        public int[] conjuntoB;
        int tamanoConjuntoA;
        int tamanoConjuntoB;

        //Manera de llamar al programa
        public GeneradorDeArreglos(int _tamanoConjuntoA, int _tamanoConjuntoB)
        {
            tamanoConjuntoA = _tamanoConjuntoA;
            tamanoConjuntoB = _tamanoConjuntoB;

            int[] _conjuntoA = new int[_tamanoConjuntoA];
            int[] _conjuntoB = new int[_tamanoConjuntoB];

            conjuntoA = _conjuntoA;
            conjuntoB = _conjuntoB;
        }

        //Acomodamos los datos introducidos
        public void Union()
        {
            
            //Para el conjunto A, acomodar de menor a mayor
            for (int i = 0; i < tamanoConjuntoA; i++)
            {

                int menorA = conjuntoA[i];

                for (int k = i; k < tamanoConjuntoA; k++)
                {
                    if (menorA > conjuntoA[k])
                    {

                        int pasar = menorA;
                        menorA = conjuntoA[k];
                        conjuntoA[k] = pasar;
                    }
                }

                conjuntoA[i] = menorA;
                Console.WriteLine("\nLos numeros ordenados son para el conjunto A: " + conjuntoA[i]);
            }

            //Para el conjunto B, acomodar de menor a mayor
            for (int i = 0; i < tamanoConjuntoB; i++)
            {

                int menorB = conjuntoB[i];

                for (int k = i; k < tamanoConjuntoB; k++)
                {
                    if (menorB > conjuntoB[k])
                    {
                        int pasar = menorB;
                        menorB = conjuntoB[k];
                        conjuntoB[k] = pasar;
                    }
                }

                conjuntoB[i] = menorB;
                Console.WriteLine("\nLos numeros ordenados son para el conjunto B: " + conjuntoB[i]);
            }
            //Fin Organizaciones
            Console.ReadKey();

            //Encontrar cuantos valores existen sin los repetidos
            int contador = 0;
            for (int i = 0; i < tamanoConjuntoA - 1; i++)
            {

                if (conjuntoA[i] == conjuntoA[i + 1])
                {
                    contador += 1;
                }
            }

            //Nuevo conjunto A sin repetidos
            int[] newConjuntoA = new int[tamanoConjuntoA - contador];
            Console.WriteLine("\n\nEl nuevo conjunto A contiene " + (tamanoConjuntoA - contador) + " elementos no repetidos");

            //Llenamos nuevo conjunto, evitando los valores repetidos
            contador = 0;
            for (int k = 0; k < tamanoConjuntoA - 1; k++)
            {

                if (conjuntoA[k] != conjuntoA[k + 1])
                {
                    newConjuntoA[contador] = conjuntoA[k];
                    Console.WriteLine(newConjuntoA[contador]);
                    contador++;
                }
            }

            int valorA = newConjuntoA.Length - 1;

            newConjuntoA[valorA] = conjuntoA[tamanoConjuntoA - 1];
            Console.WriteLine(newConjuntoA[valorA]);
            Console.ReadKey();

            //Encontrar cuantos valores existen sin los repetidos
            contador = 0;
            for (int i = 0; i < tamanoConjuntoB - 1; i++)
            {

                if (conjuntoB[i] == conjuntoB[i + 1])
                {
                    contador += 1;
                }
            }

            //Nuevo conjunto B sin repetidos
            int[] newConjuntoB = new int[tamanoConjuntoB - contador];
            Console.WriteLine("\nEl nuevo conjunto B contiene " + (tamanoConjuntoB - contador) + " elementos no repetidos");

            //Llenamos nuevo conjunto, evitando los valores repetidos
            contador = 0;
            for (int k = 0; k < tamanoConjuntoB - 1; k++)
            {

                if (conjuntoB[k] != conjuntoB[k + 1])
                {
                    newConjuntoB[contador] = conjuntoB[k];
                    Console.WriteLine(newConjuntoB[contador]);
                    contador++;
                }
            }

            int valorB = newConjuntoB.Length - 1;

            newConjuntoB[valorB] = conjuntoB[tamanoConjuntoB - 1];
            Console.WriteLine(newConjuntoB[valorB]);
            Console.ReadKey();

            //formamos el nuevo conjunto unitario
            int [] conjuntoUnitario = new int[newConjuntoA.Length + newConjuntoB.Length];

            //Llenamos la parte A
            for (int k = 0; k < newConjuntoA.Length ; k++)
            {
                conjuntoUnitario[k] = newConjuntoA[k];
            }

            //Llenamos la parte B
            int puntador = 0;
            for (int i = newConjuntoA.Length  ; i < (newConjuntoA.Length + newConjuntoB.Length); i++)
            {
                conjuntoUnitario[i] = newConjuntoB[puntador];
                puntador++;
            }

            //Imprimimos los datos
            Console.Write("\n\nEl conjunto unitario conformado por los valores de el conjunto A y el conjunto B, no repetidos (en los conjuntos solos), son  : [ ");
            for (int i = 0; i < conjuntoUnitario.Length; i++)
            {
                Console.Write(conjuntoUnitario[i] + ", ");
            }
            Console.WriteLine("]");

            //Imprimimos los datos sin repetir
            Console.Write("\n\nEl conjunto unitario conformado por los valores de el conjunto A y el conjunto B son  : [ ");
            for (int i = 0; i < conjuntoUnitario.Length; i++)
            {
                bool repetido = false;
                int menorU = conjuntoUnitario[i];

                for (int k = i+1; k < conjuntoUnitario.Length; k++)
                {
                    if (menorU == conjuntoUnitario[k])
                    {
                        repetido = true;
                    }
                }

                if(repetido == true)
                {
                    Console.Write("");
                }
                else
                {
                    Console.Write(conjuntoUnitario[i] + ", ");
                }
            }
            Console.WriteLine("]");

            Console.WriteLine("\n\nAgradeciemientos especiales a Gio por provarnos que no sabemos nada de programacion... >:V");

        }
    }
}
