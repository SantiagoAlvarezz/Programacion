using System;

public class Program
{

	public static void Main()
	{
		// Ejercicio 02-04 conozco b, d, y. Tambien me las pueden dar
		Console.Write("Ingrese el valor de d: ");
		double d2 = double.Parse(Console.ReadLine());
		double d2Rad = d2 * Math.PI / 180;
		Console.Write("Ingrese el valor de b: ");
		double b2 = double.Parse(Console.ReadLine());
		// Convertir a radianes :)))))))
		double b2Rad = b2 * Math.PI / 180;

		Console.Write("Ingrese el valor de y: ");
		double y2 = double.Parse(Console.ReadLine());


		// Ecuaciones para encontrar los valores restantes

		double e = 180 - (d2 + b2);
		double eRad = e * Math.PI / 180;
		// lo converti a rad por si masadelante lo necesito operar no complicarme jejej

		double c = 180 - e;
		double cRad = c * Math.PI / 180;

		double a = 90 - c;
        double aRad = a * Math.PI / 180;
		// aqui encontre t sin querer, ent lo dejé
		double t = y2 / Math.Sin(aRad);
		//Pitagorazo
		double z = Math.Sqrt((t * t) - (y2 * y2));












		// Prueba/resultado

		Console.Write("z: " + z );



	}
}