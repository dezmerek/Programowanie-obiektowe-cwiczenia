using System;

namespace Flow_chart_niestrukturalny_na_kod_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wszystkieDane = Console.ReadLine();
            string[] podzieloneDane = wszystkieDane.Split(' ');

            int x = int.Parse(podzieloneDane[0]);
            int y = int.Parse(podzieloneDane[1]);
            int z = int.Parse(podzieloneDane[2]);

            while(x>0)
            {
                if(y>0)
                {
                    x=x-1;
                    y=y-1;
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

            while(x<=0)
            {
                Console.Write("E");
                Console.Write("G");
                Console.WriteLine();
                return;
            }
        }
    }
}
