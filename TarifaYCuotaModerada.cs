﻿using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Ingrese su salario mensual");
		Double SM = Double.Parse(Console.ReadLine());
		int smmlv = 877803;



		if (SM < 2 * smmlv)
		{
			Console.WriteLine("Tarifa A");
			Console.WriteLine("El valor de su cuota moderada es: 3.400");

		}


		else if (2 * smmlv <= SM && SM <= 5 * smmlv)
		{
			Console.WriteLine("Tarifa B");
			Console.WriteLine("El valor de su cuota moderada es: 13.500");

		}

		else
		{
			Console.WriteLine("Tarifa C");
			Console.WriteLine("El valor de su cuota moderada es: 35.600");

		}
	}
}