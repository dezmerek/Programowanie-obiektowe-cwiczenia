using System;
using System.Globalization;

namespace Parametry_trójkąta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            // wczytaj dane
            string wszystkieDane = Console.ReadLine();
            string[] podzieloneDane = wszystkieDane.Split(';');

            double a = double.Parse(podzieloneDane[0]);
            double b = double.Parse(podzieloneDane[1]);
            double c = double.Parse(podzieloneDane[2]);

            if (a <= 0 || b < 0 || c <= 0)
            {
                Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                return;
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
                return;
            }

            // i wykonaj obliczenia
            double obwod = a + b + c;
            double pierwiastek = obwod / 2;

            double pole = Math.Sqrt(pierwiastek * (pierwiastek - a) * (pierwiastek - b) * (pierwiastek - c));

            var obowdZaokraglanie = Math.Round(obwod, 2);
            var poleZaokraglanie = Math.Round(pole, 2);

            if (obowdZaokraglanie % 1 == 0)
            {
                Console.WriteLine($"obwód = {obowdZaokraglanie}.00");
            }
            else
            {
                Console.WriteLine($"obwód = {obowdZaokraglanie}");
            }

            if (poleZaokraglanie % 1 == 0)
            {
                Console.WriteLine($"pole = {poleZaokraglanie}.00");
            }
            else
            {
                Console.WriteLine($"pole = {poleZaokraglanie}");
            }

            if (a * a + b * b == c * c)
            {
                Console.WriteLine("trójkąt jest prostokątny");
            }
            else if (a * a + b * b > c * c)
            {
                Console.WriteLine("trójkąt jest ostrokątny");
            }
            else if (a * a + b * b < c * c)
            {
                Console.WriteLine("trójkąt jest rozwartokątny");
            }

            if (a == b & a == c & b == c)
            {
                Console.WriteLine("trójkąt równoboczny");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("trójkąt równoramienny");
            }
        }
    }
}

// 3;2;2 źle