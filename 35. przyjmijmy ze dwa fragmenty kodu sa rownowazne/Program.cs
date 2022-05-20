using System;

namespace _35._przyjmijmy_ze_dwa_fragmenty_kodu_sa_rownowazne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oblicz(int, int, int);
            int a, b, c, wynik;

            if (a > 0)
            {
                wynik = oblicz(a, b, c);
            }
            else
            {
                wynik=oblicz(-a, b, c);
            }
        }
    }
}
