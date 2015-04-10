using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLecturaTecladoNuemros
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, suma, dif, div, prod;

            Console.WriteLine("Digite num 1:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite num 2:");
            num2 = float.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                suma = num1 + num2;
                Console.WriteLine("suma= " + suma);
                dif = num1 - num2;
                Console.WriteLine(" diferencia: =" + dif);
            }
            else
            {
                prod = num1 * num2;
                Console.WriteLine("producto " + prod);

                div = num1 / num2;
                Console.WriteLine("divicion " + div);
            }

            Console.ReadKey();
    }
        }
    
}
