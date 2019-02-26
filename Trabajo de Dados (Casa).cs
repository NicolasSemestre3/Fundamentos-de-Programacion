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

                //Organizamos las variables
                Random dadoAleatorio = new Random();
                int dado1 = 0;
                int dado2 = 0;
                int total = dado1 + dado2;
                int contadorTurnos = 0;
                int turnoActual = 0;
                int vidaJugador = 3;
                string volverLanzar = "si";

                //Comenzamos ciclo ludopata
                while (vidaJugador >= 1 && volverLanzar == "si")
                {
                    turnoActual += 1;
                    contadorTurnos += 1;

                    if (contadorTurnos == 2)
                    {
                        //lanzamos un nuevo dado
                        dado1 = dadoAleatorio.Next(1, 7);
                        total += dado1;

                        //Narramos
                        Console.WriteLine("(Lanzas los dados...)");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("...");

                        Console.WriteLine("Tu dado fue: " + dado1);
                        Console.WriteLine("Cuentas actualmente con un total de: " + total);
                        Console.WriteLine("El turno actual es el: " + turnoActual);

                        //restamos la vida
                        vidaJugador -= 1;
                        
                        //Perdio por durar dos turnos
                        Console.WriteLine(" -Snake eyes!-");
                        Console.WriteLine("Cuidado capitan, lanzaste 2 turnos, te quedan ahora: " + vidaJugador + " vidas");

                        if (vidaJugador == 0)
                        {
                            break;
                        } 

                        //incentivamos la ludopatia
                        Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                        volverLanzar = Console.ReadLine();

                    }

                    else if (contadorTurnos == 3)
                    {
                        //posibilidad de doble dado
                        Console.WriteLine("Tenemos energia a tope capitan, osea que tiramos dos dados, si sacamos par podremos sumar una vida");

                        //lanzamos un nuevo dado
                        dado1 = dadoAleatorio.Next(1, 7);
                        dado2 = dadoAleatorio.Next(1, 7);
                        total += dado1 + dado2;

                        //Narramos
                        Console.WriteLine("(Lanzas los dados...)");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("...");

                        Console.WriteLine("Tu dado fue: " + dado1);
                        Console.WriteLine("Tu dado adicional fue: " + dado2);
                        Console.WriteLine("Cuentas actualmente con un total de: " + total);
                        Console.WriteLine("El turno actual es el: " + turnoActual);

                        //reiniciamos contador
                        contadorTurnos = 0;

                        if (dado2 == dado1)
                        {
                            vidaJugador += 1;
                            //Gana unito
                            Console.WriteLine(" -Heroes never Die!- ");
                            Console.WriteLine("Que buen suport, por sacar par tu vida queda en: " + vidaJugador);
                            
                            //incentivamos la ludopatia
                            Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                            volverLanzar = Console.ReadLine();
                        }
                        else
                        {
                            //incentivamos la ludopatia
                            Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                            volverLanzar = Console.ReadLine();
                        }

                    }

                    else
                    {
                        //lanzamos un nuevo dado
                        dado1 = dadoAleatorio.Next(1, 7);
                        total += dado1;

                        //Narramos
                        Console.WriteLine("(Lanzas los dados...)");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("...");

                        Console.WriteLine("Tu dado fue: " + dado1);
                        Console.WriteLine("Cuentas actualmente con un total de: " + total);
                        Console.WriteLine("El turno actual es el: " + turnoActual);

                        //incentivamos la ludopatia
                        Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                        volverLanzar = Console.ReadLine();
                    }
                }

                //Perdida 
                if (vidaJugador == 0)
                {
                    //Perdio por quedarse sin vidas
                    Console.WriteLine(" -Snake eyes!-");
                    Console.WriteLine("laughed the Devil while slamming the floor.");
                    Console.WriteLine(" -You lose!-");
                    Console.WriteLine("The brothers trembled in fear as he loomed over them.");
                    Console.WriteLine(" -Now, about those souls..._");

                    //Repetir juego
                    Console.WriteLine("Capitan no se deje mangonear de ese malandro de satanas, la otra de ley de ganas, ¿Jugamos otro?");
                    iniciarJuego = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Muy bien capian, jugaste: " + turnoActual + " turnos " + " y terminaste con un puntaje de: " + total + " ademas con: " + vidaJugador + " vidas.");
                    Console.WriteLine("Deseas volver a jugar capitan?");
                    iniciarJuego = Console.ReadLine();
                }
            }

            Console.WriteLine("Caray, no esperaba esto de ti capitan... , que niña de tu parte, ve a que tu mami te consuele");

        }
        }
}
