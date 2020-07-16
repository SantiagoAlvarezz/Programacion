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
		double Discriminante = (b * b) - 4 * (a * c);
		
		// que me muestre la solucion a ambas raices
		

		

		//ni me acuerdo que hice aquí, si las raices dan nros imaginarios/raros, no sé
		if (Discriminante < 0)
		{
			Console.WriteLine("No es posible calcular la solucion. Tas bien(?).");

		}
		else if (Discriminante >0 )
		{// Ambas son calculabes y correctas 
			double raizPositiva = (-b + (Math.Sqrt(Discriminante)) / (2 * a));
			double raizNegativa = (-b - (Math.Sqrt(Discriminante)) / (2 * a));
			Console.WriteLine("Ambas soluciones son correctas :D");
			Console.WriteLine("x1: " + raizPositiva);
			Console.WriteLine("x2: " + raizNegativa);




		}
		else
		{//tiene unica solución
			double raizPositiva = (-b  / (2 * a));
			Console.WriteLine("Unica Solución");
			Console.WriteLine("x:" + raizPositiva);


		}

	}
}