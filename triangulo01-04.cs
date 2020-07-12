using System;

public class Program
{

	public static void Main()
	{
		// Ejercicio 01-04 conozco b, z, y. Tambien me las pueden dar
		Console.Write("Ingrese el valor de z: ");
		double z2 = double.Parse(Console.ReadLine());

		Console.Write("Ingrese el valor de b: ");
		double b2 = double.Parse(Console.ReadLine());
		// Convertir a radianes :)))))))
		double b2Rad = b2 * Math.PI / 180;

		Console.Write("Ingrese el valor de y: ");
		double y2 = double.Parse(Console.ReadLine());


		// Ecuaciones para encontrar los valores restantes


		double a = Math.Atan(y2 / z2);
		double A = a * (180.0 / Math.PI);

		double t = y2 / Math.Sin(a);

		double c = 90 - A;

		double e = 180 - c;

		double d = 180 - (e + b2);
		//lo de abajo es una conversion a radianes para poder operar :)

		double dRad = d * Math.PI / 180;
		


		//seguimos con ecuaciones :)
		double x1 = t * Math.Sin(b2Rad);
		double x2 = Math.Sin(dRad);
		

		double x = (x1 / x2);
		
		// Prueba/resultado

		Console.Write("x: " + x);

		

	}
}