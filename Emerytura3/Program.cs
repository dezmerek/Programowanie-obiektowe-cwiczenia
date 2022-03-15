using System;

namespace Emerytura3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wszystkieDane = Console.ReadLine();
            string[] podzieloneDane = wszystkieDane.Split(' ');

            string nazwisko = podzieloneDane[0];
            int wiekOsoby = Convert.ToInt32(podzieloneDane[1]);
            int wiekEmerytalny = Convert.ToInt32(podzieloneDane[2]);
            int doEmerytury = wiekEmerytalny - wiekOsoby;

            int ostatniaCyfra = doEmerytury % 10;

            if (wiekOsoby < 0 || wiekEmerytalny < 0)
            {
                Console.WriteLine("Wiek nie może być ujemny!");
            }
            else if (wiekOsoby >= wiekEmerytalny)
            {
                Console.WriteLine($"Witaj emerycie {nazwisko}!");
            }
            else if (ostatniaCyfra == 2 || ostatniaCyfra == 3 || ostatniaCyfra == 4)
            {
                Console.WriteLine($"Witaj {nazwisko}! Do emerytury brakuje Ci {doEmerytury} lata!");
            }
            else if (doEmerytury == 1)
            {
                Console.WriteLine($"Witaj {nazwisko}! Do emerytury brakuje Ci {doEmerytury} rok!");
            }
            else
            {
                Console.WriteLine($"Witaj {nazwisko}! Do emerytury brakuje Ci {doEmerytury} lat!");
            }
        }
    }
}
