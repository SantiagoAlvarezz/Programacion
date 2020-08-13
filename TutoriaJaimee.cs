using System;


public class Program
{
	public static void Main(string[] args)
	{
		Random aleatorio = new Random();

		int dado1 = aleatorio.Next(1, 7);
		int dado2 = aleatorio.Next(1, 7);
		int total = dado1 + dado2;
		int puntajeGanador = 100;
		int i = 0;
		int contador = 0;
		int c = 0;
		double porcentaje = 0;
		string continuar = "s";

		Console.WriteLine("Sus dados son: \tDado1: " + dado1);
		Console.WriteLine("\nDado2: " + dado2);
		Console.WriteLine("\nTotal: " + total);
		if (dado1 == 1 && dado2 == 1) Console.WriteLine("Perdiste :(");
		if (total > 6) contador++;

		while (total < puntajeGanador && continuar == "s" && (dado1 != 1 || dado2 != 1))
		{
			if (dado1 == dado2)
			{
				c++;
				if (c == 3)
				{
					Console.WriteLine("Ganaste por sacar 3 pares consecutivos :)");
					break;
				}
			}
			else c = 0;
			Console.WriteLine("Quieres seguir jugando? (s/n)");
			continuar = Console.ReadLine();
			if (continuar == "s")
			{
				dado1 = aleatorio.Next(1, 7);
				dado2 = aleatorio.Next(1, 7);
				if (dado1 == 1 && dado2 == 1)
				{
					Console.WriteLine("Dado1: " + dado1);
					Console.WriteLine("\nDado2: " + dado2);
					Console.WriteLine("\nSacaste par 1, perdiste :(");
					break;
				}
				int totalNuevosDados = dado1 + dado2;
				if (totalNuevosDados > 6) contador++;
				total += totalNuevosDados;

				Console.WriteLine("Tus nuevos dados son: \tDado1: " + dado1);
				Console.WriteLine("\nDado2: " + dado2);
				Console.WriteLine("\nTu nuevo total es: " + total);
			}
			i++;
		}
		if (i > 0) porcentaje = Math.Round((((double)contador / i) * 100), 2);
		if (continuar == "n") Console.WriteLine("¿porque te retiras?, el porcentaje de veces que sacaste mas de 6 fue: " + porcentaje + "%");
		break;
		if (total >= 100) Console.WriteLine("Ganaste, y tu porcentaje de veces que sacaste mas de 6 fue " + porcentaje + "%");
	}
}
