using System;

namespace Objętość_stożka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // wczytaj dane
            string wszystkieDane = Console.ReadLine();
            string[] podzieloneDane = wszystkieDane.Split(' ');

            int r = int.Parse(podzieloneDane[0]);
            int l = int.Parse(podzieloneDane[1]);

            if ((r < 0 || l < 0))
            {
                Console.WriteLine("ujemny argument");
            }
            else if (r > l)
            {
                Console.WriteLine("obiekt nie istnieje");
            }
            else
            {
                decimal PolePodstawy = (decimal)(Math.PI * r * r);
                decimal WysokoscStozka = ((decimal)Math.Sqrt(Math.Pow(l, 2) - Math.Pow(r, 2)));
                decimal ObjetoscStozka = PolePodstawy * WysokoscStozka / 3;

                decimal a = Math.Floor(ObjetoscStozka);
                decimal b = Math.Ceiling(ObjetoscStozka);

                Console.Write($"{a} {b}");
            }
        }
    }
}
