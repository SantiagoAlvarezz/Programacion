using System;

class Program
{
    static void Main(string[] args)
    {
        double n = 100, x = 3, factorial = 0, Total = 0;
        for (int i = 0; i <= n; i++)
        {
            factorial *= i;
            if (factorial == 0) factorial = 1;
            Total += (Math.Pow(x, i)) / (factorial);

        }
        Console.WriteLine(Total);
    }
}