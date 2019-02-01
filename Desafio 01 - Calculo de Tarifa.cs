using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01___Calculo_de_Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se inscribe y pide la información requerida
            Console.WriteLine("Saludos usuario, yo soy Failsafe, tu asistente computacional autonoma, Tu esclava prácticamente, quiero saber que tarifas podemos ofrecerte segun cuantos ingresos ganas, asi que..., dime cuanta pasta ganas por día esclavo:");
            double SMLV = double.Parse(Console.ReadLine());

            //declaramos las condiciones
            if (SMLV < 1656232)
            {
                Console.WriteLine("Saludos subordinado, dado que tus ingrésos se encuentran menos que dos salarios mínimos legales vigentes, a fuerza de lidia te permitimos ingresar, y puedes acceder a la tarifa A");
            }
            else if (1656232 < SMLV && SMLV < 3312464)
            {
                Console.WriteLine("Saludos soldado, dado que tus ingresos son superiores a los 2 Salarios minimos legales vigentes pero menor a 4, no digas que me conoces y entra con una tarifa B");
            }
            else
            {
                Console.WriteLine("Saludos capitan, la unidad cayde-6 a ordenado que tu tarifa sea tipo C, sabes si dejaras de respirar podrias duplicar tu fama...");
            }
        }
    }
}
