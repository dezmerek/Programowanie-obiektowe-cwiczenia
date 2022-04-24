using System;

namespace Flow_chart_niestrukturalny_na_kod_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // wczytaj dane
            string wszystkieDane = Console.ReadLine();
            string[] podzieloneDane = wszystkieDane.Split(' ');

            int x = int.Parse(podzieloneDane[0]);
            int y = int.Parse(podzieloneDane[1]);
            int z = int.Parse(podzieloneDane[2]);

            start:
            if (x > 0)
            {
                if(y > 0)
                {
                    x = x - 1;
                    y = y - 1;
                    Console.Write("C");
                    goto start;
                }
                else
                {
                    Console.Write("D");
                    if(z > 0)
                    {
                        Console.WriteLine();
                        return;
                    }
                    else
                    {
                        Console.Write("G");
                        Console.WriteLine();
                        return;
                    }
                }
            }
            else
            {
                Console.Write("EG");
                Console.WriteLine();
                return;
            }
        }
    }
}
