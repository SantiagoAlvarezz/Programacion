using System;

public class Program
{
	public static void Main(string[] args)
	{//ingreso de variables a, b, c
		Console.WriteLine("Ingrese el valor de a: ");
		double a = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese el valor de b: ");
		double b = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese el valor de c: ");
		double c = double.Parse(Console.ReadLine());
		//ecuaciones una con raiz Negativa, la otra con raiz positiva
		double raizPositiva = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
		double raizNegativa = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
		// que me muestre la solucion a ambas raices
		Console.WriteLine("x1: " + raizPositiva);
		Console.WriteLine("x2: " + raizNegativa);
		//ni me acuerdo que hice aquí, si las raices dan nros imaginarios/raros, no sé
		if (raizNegativa.ToString() == "NaN" || raizPositiva.ToString() == "NaN")
		{
			Console.WriteLine("No es posible calcular la solucion. Tas bien(?).");

		}
		else if (raizPositiva != raizNegativa)
		{// Ambas son calculabes y correctas 
			Console.WriteLine("Ambas soluciones son correctas :D");



		}
		else
		{//tiene unica solución
			Console.WriteLine("Unica Solución");

		}

	}
}