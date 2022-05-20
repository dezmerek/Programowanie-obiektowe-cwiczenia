using System;

namespace _5_Jaka_bedzie_wartosc_zmiennej_n_po_wykonaniu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 1; j <= 1; j++)
                {
                    if (i != j)
                    {
                        n=n-1;
                    }
                }
            }

            Console.WriteLine(n);
        }
    }
}
