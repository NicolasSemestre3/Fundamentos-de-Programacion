using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_Parcial__Dados_
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
                int dado1 = dadoAleatorio.Next(1, 7), dado2 = dadoAleatorio.Next(1, 7), total = dado1 + dado2, paresContinuos = 0, paresMaximos = 0, vecesLanzadas = 0;

                //Narramos
                Console.WriteLine("(Lanzas los dados...)");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");

                Console.WriteLine("Tus dados fueron: " + dado1 + "&" + dado2);
                Console.WriteLine("Cuentas actualmente con un total de: " + total);

                //Confirmamos su victoria o posible mala suerte
                if (dado1 > 1 && dado2 > 1)
                {
                    //Comenzamos a buscar repetir
                    while ((total <= 100 && paresContinuos < 3) &&  dado1 + dado2 > 2 && iniciarJuego == "si")
                    {
                        //incentivamos la ludopatia
                        Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                        string volverLanzar = Console.ReadLine();

                        if (volverLanzar == "si")
                        {
                            //lanzamos dados
                            dado1 = dadoAleatorio.Next(1, 7);
                            dado2 = dadoAleatorio.Next(1, 7);
                            total += dado1 + dado2;
                            vecesLanzadas += 1;

                            //Segunda condicion de victoria
                            if (dado1 == dado2 )
                            {
                                paresContinuos += 1;
                            }
                            else
                            {
                                paresContinuos = 0;
                            }

                            if (dado1 + dado2 > 6)
                            {
                                
                                paresMaximos += 1;
                            }
                            
                          

                            //Narramos
                            Console.WriteLine("(Lanzas los dados...)");
                            Console.WriteLine("...");
                            Console.WriteLine("...");
                            Console.WriteLine("...");

                            Console.WriteLine("Tus dados fueron: " + dado1 + "&" + dado2);
                            Console.WriteLine("Cuentas actualmente con un total de: " + total);
                            
                        }
                        else
                        {
                            //Finalizó el juego
                            Console.WriteLine("A... que nena, capitan tu puntaje fue: " + total);
                            Console.WriteLine("Lanzaste un total de: " + vecesLanzadas + " veces.");
                            Console.WriteLine("Ademas tuviste par perfecto: " + paresMaximos + " veces.");

                            //Incetivamos la ludopatia
                            Console.WriteLine("¿Jugamos otro capitan?, ¿o se le arruga?");
                            iniciarJuego = Console.ReadLine();
                            total = 0;
                        }
                    }

                    if (total >= 100 || paresContinuos >= 3)
                    {
                        //Enunciamos Victoria
                        Console.WriteLine(" -Lo logró capitan...- ");
                        Console.WriteLine(" -¿Lo logré?- ");
                        Console.WriteLine(" -¡¿Lo logró?!- ");

                        Console.WriteLine("Capitan usted gano con un puntaje total de: " + total);
                        Console.WriteLine("Despues de: " + vecesLanzadas + " Lanzamientos");
                        Console.WriteLine("Con: " + paresMaximos + " Veces que sacaste par de 6!");
                        Console.WriteLine("Enhorabuena titan, ¿jugamos otra?");
                        iniciarJuego = Console.ReadLine();

                    }

                    if (dado1 == 1 && dado2 == 2)
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
                    }

                }
                else
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
                }
            }

            Console.WriteLine("Carai, no esperaba esto de ti capitan... , que niña de tu parte, ve a que tu mami te consuele");
        }
    }
}
