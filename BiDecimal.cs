﻿using System;

public class Program
{
    public static void Main()
    {
        // Entrada del usuario de las variables
        Console.WriteLine("Ingresa 5 dígitos en sistema binario");

        Console.Write("Ingrese el primer digito: ");
        double b4 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo digito: ");
        double b3 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer digito: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto digito: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el quinto digito: ");
        double b0 = double.Parse(Console.ReadLine());

        // Convertir variables binarias a decimales

        Double d4 = (b4 * (Math.Pow(2, 4)));

        Double d3 = (b3 * (Math.Pow(2, 3)));

        Double d2 = (b2 * (Math.Pow(2, 2)));

        Double d1 = (b1 * (Math.Pow(2, 1)));

        Double d0 = (b0 * (Math.Pow(2, 0)));

        // Resultado Decimal

        Double Decimal = (d4 + d3 + d2 + d1 + d0);
        Console.WriteLine("El número equivalente en decimal es:" + Decimal);

    }
}
