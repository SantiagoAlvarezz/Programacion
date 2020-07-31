using System;

 public class Program
{
     public static void Main(string[] args)
    {
        int total = 0;
        Console.Write("Ingrese el número de datos: ");// Le pedimos que ingrese la cantidad de datos que calculará

        //Declaramos las variables
        int n = int.Parse(Console.ReadLine());
        int i = 0, max = 0, min = 200;
        string nombreMax = "", nombreMin = "";

        while (i < n)
        {
            Console.Write("Ingrese nombre:\n edad:\n");
            string nombre = Console.ReadLine().ToString();
            int edad = int.Parse(Console.ReadLine());

            if (edad > max)
            {
                max = edad;
                nombreMax = nombre;
            }
            if (edad < min)
            {
                min = edad;
                nombreMin = nombre;
            }
            total += edad;
            i++;
        }
        double promedio = (double)total / n;
        Console.Write("El promedio es: "+ promedio );
        Console.Write("\nEl mayor es: "+ nombreMax );
        Console.Write("\tCon : " + max);
        Console.Write("\n El menor es: "+ nombreMin);
        Console.Write("\t Con: " + min);
    }
}
