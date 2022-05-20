using System;

class Program
{
    public static void Main()
    {
        int i = 2;
        int n = int.Parse(Console.ReadLine());
        
        start:
        if (i >= n)
        {
            Console.WriteLine("TAK");
            return;
        }
        else if ((n % i) == 0)
        {
            Console.WriteLine("NIE");
            return;
        }
        else
        {
            i = i + 1;
            goto start;
        }
    }
}