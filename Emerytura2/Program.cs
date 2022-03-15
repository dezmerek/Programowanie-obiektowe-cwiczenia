using System;

namespace Emerytura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nazwisko = Console.ReadLine();
            int wiekOsoby = Convert.ToInt32(Console.ReadLine());
            int wiekEmerytalny = Convert.ToInt32(Console.ReadLine());
            int doEmerytury = wiekEmerytalny - wiekOsoby;

            int ostatniaCyfra = doEmerytury % 10;

            Console.WriteLine($"Witaj, {nazwisko}!");

            if (wiekOsoby < 0 || wiekEmerytalny < 0)
            {
                Console.WriteLine("Wiek nie może być ujemny!");
            }
            else if (wiekOsoby >= wiekEmerytalny)
            {
                Console.WriteLine("Jesteś emerytem!");
            }
            else if (ostatniaCyfra == 2 || ostatniaCyfra == 3 || ostatniaCyfra == 4)
            {
                Console.WriteLine($"Do emerytury brakuje Ci {doEmerytury} lata!");
            }
            else if (doEmerytury == 1)
            {
                Console.WriteLine($"Do emerytury brakuje Ci {doEmerytury} rok!");
            }
            else
            {
                Console.WriteLine($"Do emerytury brakuje Ci {doEmerytury} lat!");
            }
        }
    }
}