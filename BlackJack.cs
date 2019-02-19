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
            //Iniciamos el primer ingreso
            Console.WriteLine("Saludos soy Failsafe, y estoy aqui para jugar contigo, ¿deseas jugar un poco de Blackjack?, de igual forma te quitaré dinero.");
            string iniciarJuego = Console.ReadLine();

            while (iniciarJuego == "si")
            {
                //Organizamos las posibles variables
                Random cartaAzar = new Random();
                Random manoEnemiga = new Random();
                int cartaAzar1 = 0, cartaAzar2 = 0, totalMano = 0, cartaAdicional = 0, totalManoEnemiga = 0;

                //Generamos la mano
                cartaAzar1 = cartaAzar.Next(1, 12);
                Console.WriteLine("Tu primera carta fue: " + cartaAzar1);

                cartaAzar2 = cartaAzar.Next(1, 12);
                Console.WriteLine("Tu segunda carta fue: " + cartaAzar2);

                //Delimitamos el inicio
                totalMano = cartaAzar1 + cartaAzar2;

                //Colocamos la situación inicial
                if (totalMano < 21)
                {
                    //Empezamos a preguntar si quiere seguir jugando
                    Console.WriteLine("Ahora estamos asi: " + totalMano);
                    Console.WriteLine("¿Deseas seguir? gallina");
                    string continuar = Console.ReadLine();

                    //Verificamos la continuidad
                    if ( continuar == "si")
                    {
                        //Preguntamos si desea otra carta
                        Console.WriteLine("Esa es la actitud capitan, otro que cae");
                        Console.WriteLine("¿Quieres otra carta?");
                        string otraCarta = Console.ReadLine();

                        //Asignamos el while
                        while ( otraCarta == "si" && totalMano < 21)
                        {
                            //Asignamos otra carta
                            cartaAdicional = cartaAzar.Next(1, 12);
                            Console.WriteLine("Tu nueva carta es: " + cartaAdicional);

                            //Sumamos mas
                            totalMano += cartaAdicional;

                            //Reintegramos el total
                            Console.WriteLine("Tu nueva mano es: " + totalMano);

                            if ( totalMano < 21)
                            {
                                //confirmamos la situacion
                                Console.WriteLine("¿Quieres otra carta?");
                                otraCarta = Console.ReadLine();
                            }
                            else if (totalMano == 21)
                            {

                                //Mensaje de victoria 
                                Console.Write("Increible capitan sacaste: " + totalMano);

                                //Generamos posible empate
                                totalManoEnemiga = manoEnemiga.Next(1, 22);

                                if (totalMano == totalManoEnemiga)
                                {
                                    //Introducimos la situacion
                                    Console.WriteLine("Vaya, vamos a desempatar esto, dado que tu contrincante saco: " + totalManoEnemiga);
                                    Console.WriteLine("Entonces vamos a jugar denuevo, con una sola carta, quien saque la mayor");

                                    //Formulamos los radom
                                    cartaAzar1 = cartaAzar.Next(1, 12);
                                    Console.WriteLine("Okey tu carta es: " + cartaAzar1);

                                    cartaAzar2 = cartaAzar.Next(1, 12);
                                    Console.WriteLine("Tu adversario tiene: " + cartaAzar2);

                                    //Acomodamos la situacion
                                    if (cartaAzar1 > cartaAzar2)
                                    {
                                        Console.WriteLine("Increible capitan sacaste: " + cartaAzar1);
                                        Console.WriteLine("Vaya es muy poco probable que esto ocurra, que maldita potra la tuya.");
                                        Console.WriteLine("Muy demalas tu adversario, que jodon eres me hiciste perder una apuesta >:C");

                                        //Preguntamos si desea continuar
                                        Console.WriteLine("¿Quieres volver a intentar?.");
                                        iniciarJuego = Console.ReadLine();
                                    }
                                    else if (cartaAzar1 == cartaAzar2)
                                    {
                                        Console.WriteLine("Oh... , que hijueputa joda con ustedes dos, no los soporto, repitan está monda mejor");

                                        //Preguntamos si desea continuar
                                        Console.WriteLine("¿Quieres volver a intentar?.");
                                        iniciarJuego = Console.ReadLine();
                                    }
                                    else
                                    {
                                        //Mensaje de perdida
                                        Console.WriteLine("Y mejor aun tu adversario tiene: " + cartaAzar2);
                                        Console.WriteLine("Vaya, y yo que habia apostado... bueno, almenos yo si me llevo dinero hoy :·3.");

                                        //Preguntamos si desea continuar
                                        Console.WriteLine("¿Quieres volver a intentar?.");
                                        iniciarJuego = Console.ReadLine();
                                    }

                                }
                                else
                                {
                                    //Terminamo todo
                                    Console.WriteLine("Y mejor aun tu adversario tiene: " + totalManoEnemiga);
                                    Console.WriteLine("Muy demalas tu adversario, que jodon eres me hiciste perder una apuesta >:C");
                                    Console.WriteLine("¿Quieres volver a intentar?.");
                                    iniciarJuego = Console.ReadLine();
                                }

                            }
                            else
                            {

                                //Mensaje de perdida
                                Console.WriteLine("Oh.... sacaste: " + totalMano);
                                Console.WriteLine("Vaya, y yo que habia apostado... bueno, almenos yo si me llevo dinero hoy :·3.");

                                //Preguntamos si desea continuar
                                Console.WriteLine("¿Quieres volver a intentar?.");
                                iniciarJuego = Console.ReadLine();

                            }

                        }

                    }
                    else
                    {

                        //Mensaje de victoria 
                        Console.WriteLine("Increible capitan sacaste: " + totalMano);

                        //Generamos posible empate
                        totalManoEnemiga = manoEnemiga.Next(1, 22);

                        if (totalMano == totalManoEnemiga)
                        {
                            //Introducimos la situacion
                            Console.WriteLine("Vaya, vamos a desempatar esto, dado que tu contrincante saco: " + totalManoEnemiga);
                            Console.WriteLine("Entonces vamos a jugar denuevo, con una sola carta, quien saque la mayor");

                            //Formulamos los radom
                            cartaAzar1 = cartaAzar.Next(1, 12);
                            Console.WriteLine("Okey tu carta es: " + cartaAzar1);

                            cartaAzar2 = cartaAzar.Next(1, 12);
                            Console.WriteLine("Tu adversario tiene: " + cartaAzar2);

                            //Acomodamos la situacion
                            if (cartaAzar1 > cartaAzar2)
                            {
                                Console.Write("Increible capitan sacaste: " + cartaAzar1);
                                Console.WriteLine("Vaya es muy poco probable que esto ocurra, que maldita potra la tuya.");
                                Console.WriteLine("Muy demalas tu adversario, que jodon eres me hiciste perder una apuesta >:C");

                                //Preguntamos si desea continuar
                                Console.WriteLine("¿Quieres volver a intentar?.");
                                iniciarJuego = Console.ReadLine();
                            }
                            else if (cartaAzar1 == cartaAzar2)
                            {
                                Console.WriteLine("Oh... , que hijueputa joda con ustedes dos, no los soporto, repitan está monda mejor");

                                //Preguntamos si desea continuar
                                Console.WriteLine("¿Quieres volver a intentar?.");
                                iniciarJuego = Console.ReadLine();
                            }
                            else
                            {
                                //Mensaje de perdida
                                Console.WriteLine("Y mejor aun tu adversario tiene: " + cartaAzar2);
                                Console.WriteLine("Vaya, y yo que habia apostado... bueno, almenos yo si me llevo dinero hoy :·3.");

                                //Preguntamos si desea continuar
                                Console.WriteLine("¿Quieres volver a intentar?.");
                                iniciarJuego = Console.ReadLine();
                            }

                        }
                        else if ( totalMano < totalManoEnemiga)
                        {
                            //Mensaje de perdida
                            Console.WriteLine("Y mejor aun tu adversario tiene: " + totalManoEnemiga);
                            Console.WriteLine("Vaya, y yo que habia apostado... bueno, almenos yo si me llevo dinero hoy :·3.");

                            //Preguntamos si desea continuar
                            Console.WriteLine("¿Quieres volver a intentar?.");
                            iniciarJuego = Console.ReadLine();
                        }
                        else
                        {
                            //Terminamo todo
                            Console.WriteLine("Y mejor aun tu adversario tiene: " + totalManoEnemiga);
                            Console.WriteLine("Muy demalas tu adversario, que jodon eres me hiciste perder una apuesta >:C");
                            Console.WriteLine("¿Quieres volver a intentar?.");
                            iniciarJuego = Console.ReadLine();
                        }

                    }
                }
                else if(totalMano == 21)
                {
                    //Mensaje de victoria 
                    Console.WriteLine("Increible capitan sacaste: " + totalMano);
                    Console.WriteLine("Vaya es muy poco probable que esto ocurra, que maldita potra la tuya.");

                    //Generamos posible empate
                    totalManoEnemiga = manoEnemiga.Next(1, 22);

                    if (totalMano == totalManoEnemiga)
                    {
                        //Introducimos la situacion
                        Console.WriteLine("Vaya, vamos a desempatar esto, dado que tu contrincante saco: " + totalManoEnemiga);
                        Console.WriteLine("Entonces vamos a jugar denuevo, con una sola carta, quien saque la mayor");

                        //Formulamos los radom
                        cartaAzar1 = cartaAzar.Next(1, 12);
                        Console.WriteLine("Okey tu carta es: " + cartaAzar1);

                        cartaAzar2 = cartaAzar.Next(1, 12);
                        Console.WriteLine("Tu adversario tiene: " + cartaAzar2);

                        //Acomodamos la situacion
                        if (cartaAzar1 > cartaAzar2)
                        {
                            Console.Write("Increible capitan sacaste: " + cartaAzar1);
                            Console.WriteLine("Vaya es muy poco probable que esto ocurra, que maldita potra la tuya.");
                            Console.WriteLine("Muy demalas tu adversario, que jodon eres me hiciste perder una apuesta >:C");

                            //Preguntamos si desea continuar
                            Console.WriteLine("¿Quieres volver a intentar?.");
                            iniciarJuego = Console.ReadLine();
                        }
                        else if (cartaAzar1 == cartaAzar2)
                        {
                            Console.WriteLine("Oh... , que hijueputa joda con ustedes dos, no los soporto, repitan está monda mejor");

                            //Preguntamos si desea continuar
                            Console.WriteLine("¿Quieres volver a intentar?.");
                            iniciarJuego = Console.ReadLine();
                        }
                        else
                        {
                            //Mensaje de perdida
                            Console.WriteLine("Y mejor aun tu adversario tiene: " + cartaAzar2);
                            Console.WriteLine("Vaya, y yo que habia apostado... bueno, almenos yo si me llevo dinero hoy :·3.");

                            //Preguntamos si desea continuar
                            Console.WriteLine("¿Quieres volver a intentar?.");
                            iniciarJuego = Console.ReadLine();
                        }
                        
                    }
                    else
                    {
                        //Terminamo todo
                        Console.WriteLine("Y mejor aun tu adversario tiene: " + totalManoEnemiga);
                        Console.WriteLine("Muy demalas tu adversario, que jodon eres me hiciste perder una apuesta >:C");
                        Console.WriteLine("¿Quieres volver a intentar?.");
                        iniciarJuego = Console.ReadLine();
                    }

                }
                else
                {
                    //Mensaje de perdida
                    Console.WriteLine("Oh.... sacaste: " + totalMano);
                    Console.WriteLine("Vaya, y yo que habia apostado... bueno, almenos yo si me llevo dinero hoy :·3.");

                    //Preguntamos si desea continuar
                    Console.WriteLine("¿Quieres volver a intentar?.");
                    iniciarJuego = Console.ReadLine();
                }

            }
                Console.WriteLine("Carai, no esperaba esto de ti capitan... , que niña de tu parte, ve a que tu mami te consuele");
        }
    }
}
