using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_de_Dados__Casa_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciamos el  ingreso
            Console.WriteLine("Saludos soy Failsafe, y estoy aqui para jugar contigo, ¿deseas jugar un poco con los dados?, de igual forma te quitaré dinero.");
            string iniciarJuego = Console.ReadLine();

            while (iniciarJuego == "si")
            {
                //Iniciamos el juego
                Console.WriteLine("Perfecto capitan, ese es el espiritu, otro que cae...");

                //Pedimos numero de participantes
                Console.WriteLine("Veo que trajiste amigos capitan, ¿cuantos son?, mas para embaucar.");
                int jugadores = int.Parse(Console.ReadLine());
                int turnoJugador = 0;
                Random dadoAleatorio = new Random();

                while (turnoJugador < jugadores)
                {
                    //Jugador de turno
                    Console.WriteLine("\n\nEl jugador de turno es: " + (turnoJugador + 1));

                    //Organizamos las variables
                    
                    int dado = 0;
                    int total = dado;
                    int contadorTurnos = 0;
                    int turnoActual = 0;
                    string volverLanzar = "si";
                    int contadorUnos = 0;

                    //Comenzamos ciclo ludopata
                    while (contadorUnos <= 3 && volverLanzar == "si" )
                    {
                        turnoActual += 1;
                        contadorTurnos += 1;

                        //lanzamos un nuevo dado
                        dado = dadoAleatorio.Next(1, 7);
                        total += dado;

                        //Narramos
                        Console.WriteLine("(Lanzas los dados...)");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("...");

                        Console.WriteLine("Tu dado fue: " + dado);
                        Console.WriteLine("Cuentas actualmente con un total de: " + total);
                        Console.WriteLine("El turno actual es el: " + turnoActual);

                        //probabilidad de muerte
                        if (dado == 1 && contadorUnos == 2)
                        {
                            contadorUnos += 1;
                        }
                        else if (dado == 1 && contadorUnos == 1)
                        {
                            contadorUnos += 1;
                        }
                        else if (dado == 1 && contadorUnos == 0)
                        {
                            contadorUnos += 1;
                        }
                        else
                        {
                            contadorUnos = 0;
                        }

                        //Victoria royale 
                        if (total >= 100)
                        {
                            Console.WriteLine("Enhora buena jugador, alcansate un puntaje de: " + total + " mayor que 100");
                            break;
                        }
                        else
                        {
                            
                            //incentivamos la ludopatia
                            Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                            volverLanzar = Console.ReadLine();
                        }

                    }

                    if (total >= 100)
                    { 

                        Console.WriteLine("Muy bien capian, jugaste: " + turnoActual + " turnos " + " y terminaste con un puntaje de: " + total + " ademas GANASTE");
                        turnoJugador += 1;

                        Console.WriteLine("Deseas volver a jugar capitan?");
                        iniciarJuego = Console.ReadLine();

                    }

                    else
                    {
                        Console.WriteLine("Muy bien capian, jugaste: " + turnoActual + " turnos " + " y terminaste con un puntaje de: " + total );
                        turnoJugador += 1;
                    }

                }
            }

            Console.WriteLine("Caray, no esperaba esto de ti capitan... , que niña de tu parte, ve a que tu mami te consuele");

        }
    }
}
