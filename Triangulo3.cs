using System;

public class Program
{

	public static void Main()
	{
		// Ejercicio 02-03 conozco z, c. Tambien me las pueden dar
		Console.Write("Ingrese el valor de z: ");
		double z2 = double.Parse(Console.ReadLine());

		Console.Write("Ingrese el valor de c: ");
		double c2 = double.Parse(Console.ReadLine());
		// Convertir a radianes :)))))))
		double c2Rad = c2 * Math.PI / 180;


		// Ecuaciones para encontrar los valores restantes
		

		double t2 = z2 / Math.Sin(c2Rad);

		double y2 = Math.Cos(c2Rad) * t2;

		double a2 = 90 - c2;



		// Prueba/resultado

		Console.Write("y: " + y2);

		Console.Write("t: " + t2);

		Console.Write("a: " + a2);

	}
}