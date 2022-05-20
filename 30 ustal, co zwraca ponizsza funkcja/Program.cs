using System;

namespace _30_ustal__co_zwraca_ponizsza_funkcja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //int fun(int n)
            //{
            //    if (n < 2) return n;
            //    else return fun(n - 2);
            //}

            int fun(int n)
            {
                if (n < 2) return n;
                if (n % 2 == 1) return fun(n - 1) + 1;
                else return fun(n - 1);
            }

            int ddd = 1 / 2 == 1 / 3;

            //int fun(int n)
            //{
            //    if (n < 2) return n;
            //    if (n % 2 == 1) return fun(n - 2);
            //    else return fun(n - 1);
            //}


            Console.WriteLine(fun(n));
        }
    }
}
