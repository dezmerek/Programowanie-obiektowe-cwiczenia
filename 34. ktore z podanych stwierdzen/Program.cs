using System;

namespace _34._ktore_z_podanych_stwierdzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 6;
            int val = 44;
            int[] a = new int[10];
            try
            {
                a[index] = val;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bonus ");
            }
            Console.WriteLine("Remaining program");
        }
    }
}
