using System;

public class Program
{

	public static void Main()
	{
		// Ejercicio 04-04 conozco w, t, c. Tambien me las pueden dar
		Console.Write("Ingrese el valor de w: ");
		double w2 = double.Parse(Console.ReadLine());

		Console.Write("Ingrese el valor de c: ");
		double c2 = double.Parse(Console.ReadLine());
		// Convertir a radianes :)))))))
		double c2Rad = c2 * Math.PI / 180;

		Console.Write("Ingrese el valor de t: ");
		double t2 = double.Parse(Console.ReadLine());


		// Ecuaciones para encontrar los valores restantes

		double e = 180 - c2;
		double eRad = e * Math.PI / 180;

		double a = 90 - c2;
		double aRad = a * Math.PI / 180;

		double d1 = Math.Sin(eRad) * t2;
		double d2 = d1 / w2;

		double d = Math.Asin(d2);
		double dGrados = d * (180 / Math.PI);

		double b = 180 - (e + dGrados);
		double bRad = b * Math.PI / 180;

		double x1 = Math.Sin(bRad) * w2;
		double x = x1 / Math.Sin(eRad);



		// Prueba/resultado

		Console.Write("y: " + x);



	}
}