using System;

namespace _11._ktora_z_instrukcji_dopiszesz_do_metody_fun
{
    class A
    {
        public virtual void Fun()
        {
            Console.Write("Witaj");
        }
    }
    class B: A
    {
        public override void Fun()
        {
            Fun();
            Console.WriteLine(" na kursie!");
        }
    }
    class MyProgram
    {
        static void Main(string[ ] args)
        {
            B b= new B();
            b.Fun();
        }
    }
}
