using System;

namespace wartosc_zmiennej_calkowtia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int i = 0;
            int m = 0;
            int r = x;

            start:
            if(r != 0)
            {
                m = r % 2;
                r = r / 2;
                i = i + 1;
                goto start;
            }
            else
            {
                i = i - m;
                Console.WriteLine(i);
                Console.WriteLine(r);
                return;
            }
        }
    }
}
