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
            Console.WriteLine("Saludos usuario, yo soy Failsafe, tu asistente computacional autonoma, Tu esclava prácticamente, quiero saber que tarifas moderadoras de citas médicas debes pagar este año segun tu salario, asi que..., dime cuanta pasta ganas por día esclavo:");
            double SMLV = double.Parse(Console.ReadLine());

            //declaramos las condiciones
            if (SMLV < 1656232)
            {
                Console.WriteLine("Saludos subordinado, dado que tus ingrésos se encuentran menos que dos salarios mínimos legales vigentes, a fuerza de lidia te permitimos ingresar,pero debes pagar una tarifa moderadora de 3200 pesos");
            }
            else if (1656232 < SMLV && SMLV < 414058)
            {
                Console.WriteLine("Saludos soldado, dado que tus ingresos son superiores a los 2 Salarios minimos legales vigentes pero menor a 5, no digas que me conoces y entra con una tarifa moderadora de 12700 desvalirizados pesos colombianos");
            }
            else
            {
                Console.WriteLine("Saludos capitan, la unidad cayde-6 a ordenado que tu tarifa moderadora sea 31600 pesos, sabes si dejaras de respirar podrias ayudar a la gente y facilitar mi trabajo...");
            }
        }
    }
}
