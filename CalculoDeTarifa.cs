﻿using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Ingrese su salario mensual" );
		Double SM = Double.Parse(Console.ReadLine());
		int smmlv = 877803;

		

		if (SM < 2 * smmlv) 
        {
			Console.WriteLine("Tarifa A");

		}


		else if (2*smmlv <= SM && SM <= 4*smmlv)
        {
			Console.WriteLine("Tarifa B");

		}

		else
        {
			Console.WriteLine("Tarifa C");

		}
	}
}
