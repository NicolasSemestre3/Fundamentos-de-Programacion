using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_Parcial_No1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exigimos la informacion requerida
            Console.WriteLine("Saludos soy Failsafe, una automata que te acompañara en el sistema de analisis economico, osea para que no te arruines basicamente, dime cuantos ganas mensualmente y si eres dependiente, osea 1, o independiente, osea 2, por que no creo que seas mas:");
            double SMLV = double.Parse(Console.ReadLine());
            int contrato = int.Parse(Console.ReadLine());
            int riesgo = 0;
            double porcentajeRiesgo = 0;

            //Dado el caso de ser independiente requeriremos saber el nivel de riesgo que posee el contraro
            if (contrato == 2)
            {
                Console.WriteLine("Veo que eres un laborador de contrato independiente, osea que no sabes socializar, dime en escala de 1 a 5 el tipo de riesgo que posee tu trabajo, mejor dicho que tan probable es que la palmes:");
                riesgo = int.Parse(Console.ReadLine());

            }

            //Continuamos cálculando
            double baseCotizacion = SMLV * (40 / 100);

            //pártimos desde ahora buscando segun el tipo de contrato
            if (contrato == 1)
            {
                double prima = SMLV;
                double pension = baseCotizacion * (4.0 / 100);
                double eps = baseCotizacion * (4.0/ 100);
                double SMLVnow = SMLV - pension - eps;

                //al ser dependiente este gana algunas prestaciones adicionales
                double salarioAnual = (SMLV * 12) + prima;

                //arrojamos los datos
                Console.WriteLine("oooh... lograste trabajar mucho, como burro, segun veo de tu salario mensual se te deduce una parte esto lo hace quedar en: " + SMLVnow);
                Console.WriteLine("pero miralo así, si trabajas un año completo, si alguien te soporta tanto, deberías estar ganando aproximadamente" + salarioAnual);
                Console.WriteLine("ademas anualmente ganas un bono de :" + prima);
            }
            else
            {
                double pension = baseCotizacion * (16.0 / 100);
                double eps = baseCotizacion * (12.5 / 100);

                //teniendo en cuenta el riesgo, podemos optar en ver las posibles situaciones
                if (riesgo == 1)
                {
                     porcentajeRiesgo = (0.522 / 100);
                }
                else if (riesgo == 2)
                {
                     porcentajeRiesgo = (1.044 / 100);
                }
                else if (riesgo == 3)
                {
                     porcentajeRiesgo = (2.436 / 100);
                }
                else if (riesgo == 5)
                {
                     porcentajeRiesgo = (4.350 / 100);
                }
                else
                {
                     porcentajeRiesgo = (6.960 / 100);
                }

                double arl = baseCotizacion * porcentajeRiesgo;
                double SMLVnow = SMLV - eps - pension - arl;

                //al ser independiente no gana muchas prestaciones
                double salarioAnual = SMLV * 12;

                //arrojamos resultados
                Console.WriteLine("oooh... lograste trabajar mucho, como burro, segun veo de tu salario mensual se te deduce una parte esto lo hace quedar en: " + SMLVnow);
                Console.WriteLine("pero miralo así, si trabajas un año completo, si alguien te soporta tanto, deberías estar ganando aproximadamente" + salarioAnual);


            }


        }
    }
}
