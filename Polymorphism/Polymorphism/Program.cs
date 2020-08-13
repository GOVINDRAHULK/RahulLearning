using System;

namespace Polymorphism
{
    //Overloading 

    class Overload
    {
        public void add()
        {
            Console.WriteLine("Default Add Method");
        }
        public void add(int a,int b)
        {
            Console.WriteLine($"2 Parameters : {a + b}");
        }
        public void add(int a, int b,int c)
        {
            Console.WriteLine($"3 Parameters : {a + b + c}");
        }

    }

    class Override
    {
        public virtual void pri()
        {
            Console.WriteLine("In Parent Class");
        }
    }
    class Override2 : Override
    {
        public override void pri()
        {
            Console.WriteLine("In Child Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Overloading
            Console.WriteLine("Overloading\n");
            Overload a = new Overload();
            a.add();
            a.add(2, 3);
            a.add(2, 3, 4);

            //Overriding
            Console.WriteLine("\nOverroading\n");
            Override oa = new Override();
            oa.pri();
            Override2 oa2 = new Override2();
            oa2.pri();
            Override oa3 = new Override2();
            oa3.pri();

        }
    }
}
