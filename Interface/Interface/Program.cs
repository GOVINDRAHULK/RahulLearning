using System;

namespace Interface
{
    interface R
    {
        void a();
    }
    interface R2
    {
        void b();
    }

    class A : R,R2
    {
        public void a()
        {
            Console.WriteLine("Interface R");
        }
        public void b()
        {
            Console.WriteLine("Interface R2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling methods by creating instance for interaface : R1\n");
            //Creating instance for interface
            R r = new A();
            r.a();
            Console.WriteLine("\nCalling methods by creating instance for interaface : R1\n");
            //Creating instance for interface
            R2 r2 = new A();
            r2.b();
            Console.WriteLine("\nCalling methos by creating a object to the class : A");
            //Object for class
            A aa = new A();
            aa.a();
            aa.b();
        }
    }
}
