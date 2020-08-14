using System;


class Program
{
    static void Main(string[] args)
    {
        Random Aleatorio = new Random();
        int Cartas, total = 0, jugadores, contador = 1, max = 0;

        string seguir = "s", nombre = " ", nombreWin = " ";

        Console.WriteLine("¿Cuantos jugarán: (min 2, max 5)");
        jugadores = int.Parse(Console.ReadLine());
        //permitir el nro de jugadores


        while (jugadores < 2 || 5 < jugadores)
        {
            Console.WriteLine("Minimo 2, máximo 5. ¿Qué parte no entendió?, ingrese nuevamente el # de jugadores :)");
            jugadores = int.Parse(Console.ReadLine());
        }



        //Inicia el juego
        while (contador <= jugadores)
        {
            Console.WriteLine("\nJUGADOR {0}", contador);
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Cartas = Aleatorio.Next(1, 11);
            total += Cartas;
            Console.WriteLine("\nCarta: {0}", Cartas);

            //ciclo x jugador

            while (total < 22 && seguir == "s")
            {
                Cartas = Aleatorio.Next(1, 11);
                total += Cartas;
                Console.Write("Carta: {0}", Cartas);
                Console.Write("  |  Total: {0}", total);

                if (total > 21)
                {
                    Console.Write("\nHaz sido eliminado!");
                    Console.Write("  Su total fue: {0}", total);
                    total = 0;
                    break;
                }
                else
                {
                    Console.Write("  |  Desea seguir jugando? (s/n)");
                    if (total <= 22 && (max < total))
                    {
                        max = total;
                        nombreWin = nombre;
                    }
                    if (Console.ReadLine() != "s")
                    {
                        total = 0;
                        break;
                    }
                }
            }
            contador++;
        }
        Console.WriteLine("\nEl ganador es: {0}", nombreWin);
    }
}