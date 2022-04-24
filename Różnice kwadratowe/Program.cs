using System;


namespace Różnice_kwadratowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // wczytaj dane
            Console.Write("a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c:");
            int c = int.Parse(Console.ReadLine());

            static void QuadraticEquation(double a, double b, double c)
            {
                double delta = (b * b) - (4 * a * c);

                if (a == 0 & b == 0 & c == 0)
                {
                    Console.WriteLine("infinity");
                    return;
                }
                else if (a == 0 & b == 0)
                {
                    Console.WriteLine("empty");
                    return;
                }
                else if (a == 0 & c == 0)
                {
                    double x = c / b;

                    Console.WriteLine("x=" + String.Format("{0:0.00}", Math.Round(x, 2)));
                    return;
                }
                else if (a == 0)
                {
                    double x = c / b;

                    Console.WriteLine("x=" + "-" + String.Format("{0:0.00}", Math.Round(x, 2)));
                    return;
                }

                if (delta == 0)
                {
                    double x0 = -b / (2 * a);

                    Console.WriteLine("x=" + String.Format("{0:0.00}", Math.Round(x0, 2)));
                }
                else if (delta < 0)
                {
                    Console.WriteLine("empty");
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("x1=" + String.Format("{0:0.00}", Math.Round(x1, 2)));
                    Console.WriteLine("x2=" + String.Format("{0:0.00}", Math.Round(x2, 2)));
                }
            }
            QuadraticEquation(a, b, c);
        }
    }
}
