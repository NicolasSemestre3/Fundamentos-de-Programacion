﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Imposible_Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Iniciamos el programa
            Console.WriteLine("Hola soy Failsafe tu asistente y desde ahora tu docente de matematicas, por que no habia nadie mas que te soportara...");
            Console.WriteLine("\nHoy es la leccion numero 2, la mala secuela de este acto");
            Console.WriteLine("\nIniciando programa...");
            Console.WriteLine("\n...");
            Console.WriteLine("\n...");
            Console.WriteLine("\n...");
            Console.WriteLine("\n...");
            Console.WriteLine("\n...");

            //Declaramos Variables
            Console.WriteLine("\n\nLa segunda secion es sobre los interceptos de conjuntos asi que para iniciar...");
            Console.WriteLine("\nVamos a unir dos conjuntos capitan, por que eso si puedo unir lo que no puedo unir es tu corazon con otro, y encontrar sus interceptos");
            Console.WriteLine("\nEscriba por favor el tamaño del conjunto A");
            int tamanoA = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEscriba por favor el tamaño del conjunto B");
            int tamanoB = int.Parse(Console.ReadLine());

            //Llamamos al generador para acomodar los arreglos
            GeneradorDeArreglos arreglo = new GeneradorDeArreglos(tamanoA, tamanoB);

            //Llenamos los arreglos con los datos requeridos
            for (int i = 0; i < tamanoA; i++)
            {
                Console.WriteLine("\nPor favor ingrese el valor " + (arreglo.conjuntoA[i] + 1) + " del conjunto A");
                arreglo.conjuntoA[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < tamanoB; k++)
            {
                Console.WriteLine("\nPor favor ingrese el valor " + (arreglo.conjuntoB[k] + 1) + " del conjunto B");
                arreglo.conjuntoB[k] = int.Parse(Console.ReadLine());
            }

            //Llamamos al Union y lanzamos el conjunto Union
            arreglo.Union();


        }
    }
}
