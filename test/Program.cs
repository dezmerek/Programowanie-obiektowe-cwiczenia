using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int n = 6;

            while(!(i>4))
            {
                n += i;
                i++;
            }

            Console.WriteLine(n);
        }
    }
}
