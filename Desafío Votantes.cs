using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_Votantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedimos la información de las eleciones

            //votos totales
            Console.WriteLine("Hola soy failsafe, tu asistente electoral electronica, wiiii ._. ... , últimamente ocurrieron elecciones del dos partidos y vamos a revisarlas, dime cuantos botos consiguio el Frente Liberal Estatista Lista Azul y cuantos botos consiguio su oponente");
            int votosFLELA = int.Parse(Console.ReadLine());
            int votosB = int.Parse(Console.ReadLine());

            //votos especiales
            Console.WriteLine("Ahora analicemos cuantos fueron lo botos en blanco, mendigos aguastibias, dime cuantos fueron lo votos en blanco y dime cuantos fueron los anulados, si ni para rayar un papel sirven...");
            int votosBlanco = int.Parse(Console.ReadLine());
            int votosAnulados = int.Parse(Console.ReadLine());

            //datos topograficos
            Console.WriteLine("Muy bien,ya casi terminamos, ahora dime cuantas personas habitan en el lugar governado y dime que porcentaje de ellas puede votar");
            int poblacion = int.Parse(Console.ReadLine());
            double poblacionVotante = double.Parse(Console.ReadLine());

            //declaramos las condiciones booleanos
            bool c = (poblacion * poblacionVotante) / 100 < (poblacion * 30) / 100;
            bool b = Math.Abs(votosFLELA - votosB) < ((votosFLELA + votosB + votosAnulados) * 10) / 100 ;
            bool a = votosFLELA + votosB + votosAnulados + votosBlanco > poblacion ;

            //Verificamos las eleciones
            if ((c || b) && a)
            {


                Console.WriteLine("Perfecto con la suiguiente informacion:");
                Console.WriteLine("Frente Liberal Estatista Lista Azul: " + votosFLELA);
                Console.WriteLine("Opocision: " + votosB);
                Console.WriteLine("Votos en blanco: " + votosBlanco);
                Console.WriteLine("Votos anulados: " + votosAnulados);
                Console.WriteLine("Con una abstencion de: " + poblacionVotante);

                Console.WriteLine("Vaya... las elecciones se repiten... inutules ;-;.");
            }
            else
            {

                //Verificamos al ganadors
                if (votosFLELA > votosB)
                {
                    Console.WriteLine("Perfecto con la suiguiente informacion:");
                    Console.WriteLine("Frente Liberal Estatista Lista Azul: " + votosFLELA);
                    Console.WriteLine("Opocision: " + votosB);
                    Console.WriteLine("Votos en blanco: " + votosBlanco);
                    Console.WriteLine("Votos anulados: " + votosAnulados);
                    Console.WriteLine("Con una abstencion de: " + poblacionVotante);

                    Console.WriteLine("El ganador fue el Frente Liberal Estatista lista azul, que viva el listazulismo");
                }

                else
                {
                    Console.WriteLine("Perfecto con la suiguiente informacion:");
                    Console.WriteLine("Frente Liberal Estatista Lista Azul: " + votosFLELA);
                    Console.WriteLine("Opocision: " + votosB);
                    Console.WriteLine("Votos en blanco: " + votosBlanco);
                    Console.WriteLine("Votos anulados: " + votosAnulados);
                    Console.WriteLine("Con una abstencion de: " + poblacionVotante);

                    Console.WriteLine("El ganador fue el opositor... vaya, esto no estaba planeado, deja te comunico con el encargado de arreglar esto.");
                    Console.WriteLine("Gentlemen, voting in DC is about to commence.We need to swing a few voters the right way.You can help.");

                }
            }
    }
    }
}


