using System;

namespace _26._liczba_pierwsza_to_taka_liczba_naturalna_wieksza_od_1
{
    internal class Program
    {
        public static bool JestPierwsza(int n)
        {
            if (n <= 1) throw new ArgumentOutOfRangeException();
            int i = 2;
            while (n % i > 0 && i * i <= n)
                i++;
            if (n % i == 0) return false;
            return true;
        }

        public static bool JestPierwsza1(int n)
        {
             if(n<=1)throw new ArgumentOutOfRangeException();
             for(int i=2;i>=2&&i<Math.Sqrt(n);i++)
                 if(n % i == 0) return true;
             return false;
        }


        public static bool JestPierwsza2(int n)
        {
            if(n<=1) throw new ArgumentOutOfRangeException();
            int i = 1;
            while(n % i > 0 && i * i <= n)
        }
    }
}
