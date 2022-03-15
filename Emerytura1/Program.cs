﻿using System;

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

            Console.WriteLine($"Witaj, {nazwisko}!");

            if (wiekOsoby < 0 || wiekEmerytalny < 0)
            {
                Console.WriteLine("Wiek nie może być ujemny!");
            }
            else if (wiekOsoby >= wiekEmerytalny)
            {
                Console.WriteLine("Jesteś emerytem!");
            }
            else
            {
                Console.WriteLine($"Do emerytury brakuje Ci {doEmerytury} lat!");
            }
        }
    }
}