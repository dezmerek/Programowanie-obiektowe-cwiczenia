
using System;

namespace jaka_bedzie_wartosc_zmiennej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int i = 0;
            int r = a;

            start:
            if(r>0)
            {
                r = r - b;
                i = i + 1;
                goto start;
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
