using System;

class Program
{
    static void Main(string[] args)
    {
        Random Aleatorio = new Random();
        int dado1, dado2, total = 0, vidas = 3, Turnodosdados = 0, Turnodevida = 0;
        string seguir = "s";

        while ((total < 100) && (seguir == "s"))
        {
            //Empieza a contar los turnos
            Turnodosdados += 1;
            Turnodevida += 1;

            //dos dados cada 3 turnos y que se gane una vida si estos salen doble
            if (Turnodosdados == 3)
            {
                Turnodosdados = 0;

                dado1 = Aleatorio.Next(1, 7);
                dado2 = Aleatorio.Next(1, 7);
                Console.WriteLine("\nDado 1: " + dado1);
                Console.WriteLine("Dado 2: " + dado2);
                total += dado1 + dado2;
                if (dado1 == dado2)
                {
                    vidas += 1;
                    Console.WriteLine("\nGanas 1 vida");
                    Console.WriteLine("Ahora tienes " + vidas + " vidas");
                }
            }
            else
            {
                dado1 = Aleatorio.Next(1, 7);
                Console.WriteLine("\nDado: " + dado1);
                total += dado1;
            }
            //Pierde vida cada 2 turnos :))
            if (Turnodevida == 2)
            {
                Turnodevida = 0;
                vidas -= 1;
                Console.WriteLine("\nPerdiste 1 vida");
                Console.WriteLine("Ahora tienes " + vidas + " vidas");
                if (vidas == 0)
                {
                    Console.WriteLine("\nPerdiste :(");
                    break;
                }
            }
           
            Console.WriteLine("\nTotal: " + total);
          
            if (total >= 100)
            {
                Console.WriteLine("\nGanaste :)");
                break;
            }
            
            else
            {
                Console.WriteLine("\nDesea continuar? (s/n)");
                seguir = Console.ReadLine();
                if (seguir == "n") break;
            }
        }
        Console.WriteLine("\nSu total fue: " + total);
        Console.WriteLine("Gracias por jugar");
    }
}
