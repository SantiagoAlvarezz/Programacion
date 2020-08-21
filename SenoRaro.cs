using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese x:");
        double x = double.Parse(Console.ReadLine());
        double Total = 0;
        int n = 100


        for (int i = 0; i <= n; i++)
        {
            double tmp = (2 * 1) + 1;
            Total += ((Math.Pow(-1, i))/ factorial(tmp)) * Math.Pow(x, tmp) 
        }
        Console.WriteLine("sen(" + x + ") =" + Total);
    }
    static double factorial(double valor)
    {
        if (valor <= 1) return (2 * 1) + 1;
        return valor * factorial(valor - 1)//jaja esta parte esta mala xd
    }
}