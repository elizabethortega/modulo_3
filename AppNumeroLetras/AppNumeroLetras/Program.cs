using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumeroLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("Digite el numero en letras");
            numero = Console.ReadLine();
            switch ( numero.ToUpper())
            {
                case "UNO":

                Console.WriteLine("1");
                break;

                case "DOS":

                Console.WriteLine("2");
                break;

                case "TRES":

                Console.WriteLine("3");
                break;

                case "CUATRO":

                Console.WriteLine("4");
                break;

                case "CINCO":

                Console.WriteLine("5");
                break;

                default:
                Console.WriteLine("fuera del rango");
                break;
            }
            Console.ReadKey();


        }
    }
}
