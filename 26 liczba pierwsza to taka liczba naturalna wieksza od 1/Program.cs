using System;

namespace _26_liczba_pierwsza_to_taka_liczba_naturalna_wieksza_od_1
{
    internal class Program
    {
            public static bool JestPierwsza(int n)
            {
            if (n <= 1) throw new ArgumentException();
            return JestPierwsza(n - 1);
            while()
            }
    }
}
