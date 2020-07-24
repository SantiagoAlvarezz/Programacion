using System;

namespace Boolean_Operator
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //Ingreso de datos votos por a, b, blanco, anulados, total de la poblacion y quienes son mayores de edad xd
            Console.Write("Ingrese:\nVotos por a:\nVotos por b:\nVotos en blanco:\nVotos anulados:\nNúmero total de la población:\nPorcentaje de la población que es mayor de edad, Ingrese el valor sin  %:\n");
            //Declaramos variables por que toca 
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), VotosBlancos = int.Parse(Console.ReadLine()), anulados = int.Parse(Console.ReadLine()), Poblacion = int.Parse(Console.ReadLine()), p = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            
            int mayoresDeEdad = (int)(p * 0.01 * Poblacion), totalVotantes = a + b + VotosBlancos + anulados;
            int abstencion = mayoresDeEdad - totalVotantes;
            //Booleanos
            bool ganoA = a > b && a > VotosBlancos;
            bool ganoB = b > a && b > VotosBlancos;

            //Datos de salida
            Console.Write("Personas Mayores de edad:" + mayoresDeEdad);

            Console.Write("\tTotal de votantes: " + totalVotantes);

            Console.Write("\tNo quisieron apoyar la democracia:" + abstencion);

            //Más datos de salida
            if ((anulados < ((a + b) * 0.30) || (a + b) > VotosBlancos) && abstencion < totalVotantes)
            {
                Console.WriteLine("\nLas votaciones fueron exitosas");
                if (ganoA) Console.Write("El ganador es el Partido A\n");
                if (ganoB) Console.Write("El ganador es el Partido B\n");
            }
            else Console.Write("Las elecciones deben repetirse\n");

        }
    }
}