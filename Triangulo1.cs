using System;

public class Program
{

	public static void Main()
	{
		// Ejercicio 02-01
		// El men pone el valor de y
		Console.Write("Ingrese el valor de y: ");
		double y = double.Parse(Console.ReadLine());

		// El men pone el valor de z
		Console.Write("Ingrese el valor de z: ");
		double z = double.Parse(Console.ReadLine());



		//Supongamos que sabemos lo que hacemos de aqui en adelante

		double a = Math.Atan(y / z);
		double A = a * (180.0 / Math.PI);

		double t = y / Math.Sin(a);

		double c = 90 - A;


		//PRUEBA

		Console.Write("a: " + A);

		Console.Write("t: " + t);

		Console.Write("c: " + c);

	}
}