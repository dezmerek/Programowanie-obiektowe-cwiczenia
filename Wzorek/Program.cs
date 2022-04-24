using System;

namespace Wzorek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Wzorek(num);


            static void Wzorek(int n)
            {
                if (n % 2 == 0) n--;

                for(int i = 0; i <= n/2; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for(int j = 0; j < n-(i*2); j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
