using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_Dados
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
                int dado = 0, total = 0, condicion10 = 0, condicionVictoria = 0;
                string continuar = "si";

                //Narramos
                Console.WriteLine("(Lanzas los dados...)");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...");

                //Lanzamos gratis sin perdida
                dado = dadoAleatorio.Next(1, 13);
                total += dado;
                Console.WriteLine("Tu dado fueron: " + dado);
                Console.WriteLine("Cuentas actualmente con un total de: " + total);
                Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                continuar = Console.ReadLine();

                //posibilad de ganar en los primeros lanzamientos
                if (dado == 10)
                {
                    condicion10 = condicion10 + 1;
                }

                //Proponemos repetir el ciclo gratis
                if (continuar == "si")
                {

                    //Narramos
                    Console.WriteLine("(Lanzas los dados...)");
                    Console.WriteLine("...");
                    Console.WriteLine("...");
                    Console.WriteLine("...");

                    //Nuevo Lanzamiento
                    dado = dadoAleatorio.Next(1, 13);
                    total += dado;

                    //Condicion de victoria secundaria
                    if (dado == 10)
                    {
                        condicion10 = condicion10 + 1;
                    }

                    if (dado != 12 && dado != 10)
                    {
                        condicion10 = 0;
                    }

                    if (dado == 12 && condicion10 >= 1)
                    {
                        Console.WriteLine("Tu dado fueron: " + dado);
                        Console.WriteLine("Cuentas actualmente con un total de: " + total);

                        // Enunciamos Victoria
                        Console.WriteLine(" -Lo logró capitan...- ");
                        Console.WriteLine(" -¿Lo logré?- ");
                        Console.WriteLine(" -¡¿Lo logró?!- ");


                        Console.WriteLine("Vaya potra capitan, ganaste por una sucecion de 10 y 12, y yo que queria irme con dinero hoy");
                        condicionVictoria = condicionVictoria + 2;


                    }

                    //Proseguimos el siclo normal
                    if (condicionVictoria < 2)
                    {
                        Console.WriteLine("Tu dado fueron: " + dado);
                        Console.WriteLine("Cuentas actualmente con un total de: " + total);
                        Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                        continuar = Console.ReadLine();

                        //Proseguimos el plan
                        if (continuar == "si")
                        {

                            dado = dadoAleatorio.Next(1, 13);
                            total += dado;
                            if (dado == 10)
                            {
                                condicion10 = condicion10 + 1;
                            }
                            if (dado != 12 && dado != 10)
                            {
                                condicion10 = 0;
                            }
                            if (dado == 12 && condicion10 >= 1)
                            {
                                //Narramos
                                Console.WriteLine("(Lanzas los dados...)");
                                Console.WriteLine("...");
                                Console.WriteLine("...");
                                Console.WriteLine("...");

                                Console.WriteLine("Tu dado fueron: " + dado);
                                Console.WriteLine("Cuentas actualmente con un total de: " + total);

                                // Enunciamos Victoria
                                Console.WriteLine(" -Lo logró capitan...- ");
                                Console.WriteLine(" -¿Lo logré?- ");
                                Console.WriteLine(" -¡¿Lo logró?!- ");


                                Console.WriteLine("Vaya potra capitan, ganaste por una sucecion de 10 y 12, y yo que queria irme con dinero hoy");
                                condicionVictoria = condicionVictoria + 2;
                            }
                            if (condicionVictoria < 2)
                            {
                                //Narramos
                                Console.WriteLine("(Lanzas los dados...)");
                                Console.WriteLine("...");
                                Console.WriteLine("...");
                                Console.WriteLine("...");

                                Console.WriteLine("Tu dado fueron: " + dado);
                                Console.WriteLine("Cuentas actualmente con un total de: " + total);
                                Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                                continuar = Console.ReadLine();
                            }
                        }
                    }
                }

                //Lanzamientos seguidos de los primeros
                while (continuar == "si" && total < 100 && dado % 2 == 0 && condicionVictoria < 2)
                {
                    //Repetimos el changos
                    dado = dadoAleatorio.Next(1, 11);
                    Console.WriteLine("Tu dado fueron: " + dado);

                    //Repetimos una segunda condicion
                    if (dado == 10)
                    {
                        condicion10 = condicion10 + 1;
                    }

                    if (dado != 12 && dado != 10)
                    {
                        condicion10 = 0;
                    }

                    if (dado == 12 && condicion10 >= 1)
                    {
                        //Narramos
                        Console.WriteLine("(Lanzas los dados...)");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("...");

                        Console.WriteLine("Tu dado fueron: " + dado);
                        Console.WriteLine("Cuentas actualmente con un total de: " + total);

                        // Enunciamos Victoria
                        Console.WriteLine(" -Lo logró capitan...- ");
                        Console.WriteLine(" -¿Lo logré?- ");
                        Console.WriteLine(" -¡¿Lo logró?!- ");


                        Console.WriteLine("Vaya potra capitan, ganaste por una sucecion de 10 y 12, y yo que queria irme con dinero hoy");
                        condicionVictoria = condicionVictoria + 2;
                    }

                    if (dado % 2 != 0)
                    {
                        //Narramos
                        Console.WriteLine("(Lanzas los dados...)");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("...");

                        //Perdio por sacar impar
                        Console.WriteLine(" -Snake eyes!-");
                        Console.WriteLine("laughed the Devil while slamming the floor.");
                        Console.WriteLine(" -You lose!-");
                        Console.WriteLine("The brothers trembled in fear as he loomed over them.");
                        Console.WriteLine(" -Now, about those souls..._");
                    }
                    if (total >= 100)
                    {
                        //Narramos
                        Console.WriteLine("(Lanzas los dados...)");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("...");

                        //Enunciamos Victoria
                        Console.WriteLine(" -Lo logró capitan...- ");
                        Console.WriteLine(" -¿Lo logré?- ");
                        Console.WriteLine(" -¡¿Lo logró?!- ");

                        Console.WriteLine("Capitan usted gano con un puntaje total de: " + total);
                        total += dado;
                    }
                    if (dado % 2 == 0 && condicionVictoria < 2)
                    {
                        //Narramos
                        Console.WriteLine("(Lanzas los dados...)");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        total += dado;
                        Console.WriteLine("Cuentas actualmente con un total de: " + total);

                        if (total < 100)
                        {
                            Console.WriteLine("¿Deseas volver a lanzar capitan?,...gallina.");
                            continuar = Console.ReadLine();
                        }
                    }
                }
                Console.WriteLine("Carai, no esperaba esto de ti capitan... , que niña de tu parte, ve a que tu mami te consuele");
                Console.WriteLine("Cuentas actualmente con un total de: " + total);
            }

        }
    }
}
