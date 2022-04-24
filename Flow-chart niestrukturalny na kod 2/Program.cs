using System;

namespace Flow_chart_niestrukturalny_na_kod_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wczytaj dane
            string wszystkieDane = Console.ReadLine();
            string[] podzieloneDane = wszystkieDane.Split(' ');

            int x = int.Parse(podzieloneDane[0]);
            int y = int.Parse(podzieloneDane[1]);
            int z = int.Parse(podzieloneDane[2]);

            for (; x > 0; ) 
            { 
                if(y>0)
                {
                    x = x - 1;
                    y = y - 1;
                    Console.Write("C");
                }
                else
                {
                    Console.Write("D");
                    if(z>0)
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

            for (; x <= 0;)
            {
                Console.Write("E");
                Console.Write("G");
                Console.WriteLine();
                return;
            }
        }
    }
}
