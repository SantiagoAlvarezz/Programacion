using System;

public class Program
{

	public static void Main()
	{
		// Ejercicio 02-02 conozco t, a. Tambien me las pueden dar//datos de entrada
		// Creo que tambien son variables :V
		Console.Write("Ingrese el valor de t: ");
		double t2 = double.Parse(Console.ReadLine());

		Console.Write("Ingrese el valor de a: ");
		double a2 = double.Parse(Console.ReadLine());
		// Convertir a radianes :)))))))
		double a2Rad = a2 * Math.PI / 180;


		// Ecuaciones para encontrar los valores restantes
		double y2 = Math.Sin(a2Rad) * t2;

		double z2 = Math.Cos(a2Rad) * t2;

		double c2 = 90 - a2;



		// Prueba/resultado//datos de salida

		Console.Write("y: " + y2);

		Console.Write("z: " + z2);

		Console.Write("c: " + c2);

	}
}