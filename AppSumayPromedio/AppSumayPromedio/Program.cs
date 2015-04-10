using System;

namespace AppPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float n1, n2, n3, n4, suma, promedio;
			Console.WriteLine ("SUMA PROMEDIO");
			Console.WriteLine ("Digite Numero 1");
			n1 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Digite Numero 2");
			n2 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Digite Numero 3");
			n3 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Digite Numero 4");
			n4 = float.Parse (Console.ReadLine ());
			suma = n1 + n2 + n3 + n4;
			promedio = suma / 4;
			Console.WriteLine ("La Suma Es "+suma);
			Console.WriteLine ("El Promedio Es "+promedio);



			Console.ReadKey ();
		}
	}
}