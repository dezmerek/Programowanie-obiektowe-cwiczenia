using System;
using System.Collections.Generic;

namespace _20._jaki_bedzie_stan_stosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            int[] b = new int[] { 5, 6, 7, 8 };

            Stack<int> S = new Stack<int>(a);
            Queue<int> Q = new Queue<int>(b);

            S.Push(Q.Peek()); Q.Dequeue();
            S.Push(Q.Peek()); Q.Dequeue();
            Q.Enqueue(S.Peek()); S.Pop();
            Q.Enqueue(S.Peek()); S.Pop();
            S.Push(Q.Peek()); Q.Dequeue();
            S.Push(Q.Peek()); Q.Dequeue();

            foreach (var item in S)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (var item in Q)
            {
                Console.WriteLine(item);
            }
        }
    }
}