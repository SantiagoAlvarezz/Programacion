using System;

public class Program
{

	public static void Main()
	{
		// Ejercicio 03-04 conozco w, d, x. Tambien me las pueden dar
		Console.Write("Ingrese el valor de w: ");
		double w2 = double.Parse(Console.ReadLine());

		Console.Write("Ingrese el valor de d: ");
		double d2 = double.Parse(Console.ReadLine());
		// Convertir a radianes :)))))))
		double d2Rad = d2 * Math.PI / 180;

		Console.Write("Ingrese el valor de x: ");
		double x2 = double.Parse(Console.ReadLine());


		// Ecuaciones para encontrar los valores restantes

		double t = (x2 * x2) + (w2 * w2) - 2 * x2 * w2 * Math.Cos(d2Rad);

		double t2 = Math.Sqrt(t);

		double b1 = Math.Sin(d2Rad) * x2;

		double b2 = b1 / t2;

		double b = Math.Asin(b2);

		double bGrados = b * (180 / Math.PI);

		double e = 180 - (bGrados + d2);

		double c = 180 - e;
		double cRad = c * Math.PI / 180;

		double a = 90 - c;
		double aRad = a * Math.PI / 180;

		double y2 = Math.Sin(aRad) * t2;

		double z2 = Math.Cos(aRad) * t2;

		// Prueba/resultado

		Console.Write("y: " + y2);



	}
}