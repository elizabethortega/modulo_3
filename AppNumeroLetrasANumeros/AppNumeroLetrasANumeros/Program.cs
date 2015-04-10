using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumeroLetrasANumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite el numero ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;

                default:
                    Console.WriteLine("fuera del rango");
                    break;
            }
            Console.ReadKey();

        }
    }
}
