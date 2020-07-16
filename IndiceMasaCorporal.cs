using System;

public class Program
{
	public static void Main(string[] args)
	{//Ingreso de datos, el peso EN KG y la altura EN METROS
		Console.WriteLine("Ingrese su peso en kg: ");
		double kg = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingresa su altura en metros: ");
		double m = double.Parse(Console.ReadLine());
		//Elevo la altura al cuadrado por que mas adelante lo necesitaremos para operar xd
		double mCuadrado = m * m;
		//ecuacion del imc
		double IMC = kg / mCuadrado;

		Console.WriteLine("Su indicie de masa corporal es:" + IMC);
		//si la ecuacion anterior es menor o igual a eso
		if (IMC <= 18.5)
		{
			Console.WriteLine("Estás bajo de peso :(");
		}
		//si esta entre ese rango GgEz
		else if (18.6 <= IMC && IMC <= 24.9)
		{
			Console.WriteLine("Tu peso es normal :D");
		}
		else if (25 <= IMC && IMC <= 29.9)
		{
			Console.WriteLine("Tienes sobrepeso D:");
		}
		else
		//De lo contrario
		{
			Console.WriteLine("Tienes obesidad :(");

		}

	}
}
