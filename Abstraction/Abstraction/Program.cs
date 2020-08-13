using System;

namespace Abstraction
{
    abstract class R
    {
        public R()
        {
            Console.WriteLine("Default Constructor");
        }
        public void a()
        {
            Console.WriteLine("Method a");
        }
        public abstract void b();
    }
    class Ra : R
    {
        public override void b()
        {
            Console.WriteLine("Ra : Overided Abstract Function");
        }
    }

    class Rb : R
    {
        public override void b()
        {
            Console.WriteLine("Rb : Overided Abstract Function");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ra ra = new Ra();
            ra.a();
            ra.b();
            Rb rb = new Rb();
            rb.a();
            rb.b();
        }
    }
}
