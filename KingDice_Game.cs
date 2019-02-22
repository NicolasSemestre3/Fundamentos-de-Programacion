using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingDice_Game
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
                int dado = dadoAleatorio.Next(1, 7);
                int total = dado;
                int paresNoContinuos1 = 0;
                int paresContinuos6 = 0;
                int vidaJugador = 3;

                //Narramos
                Console.WriteLine("(Lanzas los dados...)");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");

                Console.WriteLine("Tu dado fue: " + dado);
                Console.WriteLine("Cuentas actualmente con un total de: " + total);

                //posibilidad de perder
                if (dado == 1)
                {
                    paresNoContinuos1 += 1;
                }

                //posibilidad de ganar vida
                if (dado == 6)
                {
                    paresContinuos6 += 1;
                }
                

                //Comenzamos ciclo ludopata
                while ( vidaJugador >= 1)
                {
                    //incentivamos la ludopatia
                    Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                    string volverLanzar = Console.ReadLine();

                    if (volverLanzar == "si")
                    {
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

                        //posibilidad de perder
                        if (dado == 1 && paresNoContinuos1 == 0)
                        {
                            paresNoContinuos1 += 1;
                        }

                        if ((paresNoContinuos1 + dado) == 2 && dado == 1)
                        {
                            //restamos la vida
                            vidaJugador -= 1;
                            paresNoContinuos1 = 0;
                            total -= 10;
                            //Perdio por sacar par de 1
                            Console.WriteLine(" -Snake eyes!-");
                            Console.WriteLine("Cuidado capitan, sacaste 2 unos, te quedan ahora: " + vidaJugador + " vidas");
                        }

                        //posibilidad de ganar vida
                        if (dado == 6)
                        {
                            paresContinuos6 += 1;
                        }
                        else 
                        {
                            paresContinuos6 = 0;
                        }

                        if (paresContinuos6 == 1 && dado == 6 && vidaJugador < 3)
                        {
                            //restauramos vida
                            vidaJugador += 1;
                            paresContinuos6 = 0;

                            //Gana unito
                            Console.WriteLine(" -Heroes never Die!- ");
                            Console.WriteLine("Que buen suport, por sacar 2 seis consecutivos tu vida queda en: " + vidaJugador);
                        }

                        //Posibilidad de perder
                        if (vidaJugador == 0)
                        {
                            //Perdio por sacar par de 1
                            Console.WriteLine(" -Snake eyes!-");
                            Console.WriteLine("laughed the Devil while slamming the floor.");
                            Console.WriteLine(" -You lose!-");
                            Console.WriteLine("The brothers trembled in fear as he loomed over them.");
                            Console.WriteLine(" -Now, about those souls..._");

                            //Repetir juego
                            Console.WriteLine("Capitan no se deje mangonear de ese malandro de satanas, la otra de ley de ganas, ¿Jugamos otro?");
                            iniciarJuego = Console.ReadLine();
                            total = 0;
                            paresNoContinuos1 = 0;
                            paresContinuos6 = 0;
                        }
                        
                       // Posibilidad de Ganar
                       // if(total >= 100)
                       // {
                           // Enunciamos Victoria
                           // Console.WriteLine(" -Lo logró capitan...- ");
                           // Console.WriteLine(" -¿Lo logré?- ");
                           // Console.WriteLine(" -¡¿Lo logró?!- ");

                           // Console.WriteLine("Capitan usted gano con un puntaje total de: " + total);
                           // Console.WriteLine("Enhorabuena titan, ¿jugamos otra?");
                           // iniciarJuego = Console.ReadLine();
                           // total = 0;
                       // }

                    }
                    else
                    {
                        Console.WriteLine("Oh... como guste capitan, el poderse retirar es cuando usted desee,... que nene");
                        Console.WriteLine("Te retiraste con: " + total);

                        Console.WriteLine("¿Jugamos otra?");
                        iniciarJuego = Console.ReadLine();
                        total = 0;
                        paresNoContinuos1 = 0;
                        paresContinuos6 = 0;
                    }

                }
            }

            Console.WriteLine("Caray, no esperaba esto de ti capitan... , que niña de tu parte, ve a que tu mami te consuele");

        }
    }
}
