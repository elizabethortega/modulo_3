using System;

namespace AppPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, perimetro;
			string linea;
			Console.WriteLine ("programa que calcula el perimetro cuadrado");
			Console.WriteLine ("ingrese el lado");
			linea=Console.ReadLine ();
			lado = float.Parse (linea);
			perimetro = 4 * lado;
			Console.WriteLine ("El perimetro del cuadrado es: perimetro:"
			+ perimetro);


			Console.ReadKey ();

		}
	}
}
