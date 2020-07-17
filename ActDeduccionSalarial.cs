﻿using System;

namespace Deducciones_salariales
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ingreso de Datos
            Console.Write("Salario Mensual: ");
            Double SM = Double.Parse(Console.ReadLine());

            Console.Write("Tipo de Contrato: ");
            Console.Write("oprima 1 si es independiente u otro numero si es dependiente: ");
            Double TC = Double.Parse(Console.ReadLine());

            int smmlv = 877803;

            // Entradas adicionales...

            if (TC == 1) // Término Independiente
            {
                Console.Write("¿Qué Tipo de Riesgo maneja?: ");
                Double TR = Double.Parse(Console.ReadLine());

                if (TR == 1)
                {
                    if (SM < smmlv)
                    {
                        SM = smmlv;
                        Double ARL = ((SM * 0.4) * (0.00522));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                    else
                    {
                        Double ARL = ((SM * 0.4) * (0.00522));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                }
                else if (TR == 2)
                {
                    if (SM < smmlv)
                    {
                        SM = smmlv;
                        Double ARL = ((SM * 0.4) * (0.01044));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                    else
                    {
                        Double ARL = ((SM * 0.4) * (0.01044));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                }
                else if (TR == 3)
                {
                    if (SM < smmlv)
                    {
                        SM = smmlv;
                        Double ARL = ((SM * 0.4) * (0.02436));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                    else
                    {
                        Double ARL = ((SM * 0.4) * (0.02436));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                }
                else if (TR == 4)
                {
                    if (SM < smmlv)
                    {
                        SM = smmlv;
                        Double ARL = ((SM * 0.4) * (0.04350));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                    else
                    {
                        Double ARL = ((SM * 0.4) * (0.04350));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                }
                else if (TR == 5)
                {
                    if (SM < smmlv)
                    {
                        SM = smmlv;
                        Double ARL = ((SM * 0.4) * (0.06960));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                    else
                    {
                        Double ARL = ((SM * 0.4) * (0.06960));
                        Double pension = ((SM * 0.4) * (0.16));
                        Double salud = ((SM * 0.4) * (0.125));

                        Double SalarioReal = SM - (salud + pension + ARL);
                        Double SalarioAnual = SalarioReal * 12;

                        Console.Write("Salario Real: " + SalarioReal);
                        Console.Write("   Salario Anual: " + SalarioAnual);
                    }
                }
            }
            else // Término depentiente
            {
                if (SM < smmlv)
                {
                    SM = smmlv;
                    Double ARL = 0;
                    Double pension = ((SM * 0.4) * (0.04));
                    Double salud = ((SM * 0.4) * (0.04));

                    Double SalarioReal = SM - (salud + pension + ARL);
                    Double SalarioAnual = (SalarioReal * 12) + SM;

                    Console.Write("Salario Real: " + SalarioReal);
                    Console.Write("   Salario Anual: " + SalarioAnual);
                }
                else
                {
                    Double ARL = 0;
                    Double pension = ((SM * 0.4) * (0.04));
                    Double salud = ((SM * 0.4) * (0.04));

                    Double SalarioReal = SM - (salud + pension + ARL);
                    Double SalarioAnual = (SalarioReal * 12) + SM;

                    Console.Write("Salario Real: " + SalarioReal);
                    Console.Write("   Salario Anual: " + SalarioAnual);
                }
            }
        }
    }
}