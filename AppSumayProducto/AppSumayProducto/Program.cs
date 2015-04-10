using System;

namespace AppSumayProducto
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("CALCULAR LA SUMA DE LOS DOS PRIMEROS DIGITOS Y EL PRODUCTO DEL TERCERO Y CUARTO DIGITO");

			float n1, n2, n3, n4, suma, producto;
			Console.WriteLine ("Digite Numero 1");
			n1 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Digite Numero 2");
			n2 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Digite Numero 3");
			n3 = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Digite Numero 4");
			n4 = float.Parse (Console.ReadLine ());
			suma = n1 + n2 ;
			producto = n3 * n4 ;
			Console.WriteLine ("la suma de los dos primeros es: "+suma);
			Console.WriteLine ("el producto entre el tercero y cuarto es: "+producto);

			Console.ReadKey ();
		}
	}
}
