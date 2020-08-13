using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    //Single Inheritance
    public class A
    {
        public string s = "s : I'm a public string..i can be accessed from B class";
        private string ss = "ss : I'm a private string..i can't be accessed from B class";
        public A()
        {
            Console.WriteLine(ss);
            Console.WriteLine("I'm a default Constructor of Class A");
        }
        public void aa()
        {
            Console.WriteLine("I'm in Class A and in Method aa");
        }
        public void ab()
        {
            Console.WriteLine("I'm in Class A and in Method ab");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("I'm a default Constructor of Class B");
        }
        public void ba()
        {
            Console.WriteLine("I'm in Class A and in Method ba");
        }
        public void bb()
        {
            Console.WriteLine("I'm in Class A and in Method bb");
        }
    }

    //Multilevel Inheritance
    
    public class AA
    {
        public AA()
        {
            Console.WriteLine("Default Constructor : AA");
        }
        public void m()
        {
            Console.WriteLine("Method : m");
        }
    }
    public class BB : AA
    {
        public BB()
        {
            Console.WriteLine("Default Constructor : BB");
        }
        public void mm()
        {
            Console.WriteLine("Method : mm");
        }
    }
    public class CC : BB
    {
        public CC()
        {
            Console.WriteLine("Default Constructor : CC");
        }
        public void mmm()
        {
            Console.WriteLine("Method : mmm");
        }
    }

    //Hierarchical Inheritance
    
    public class H
    {
        public void h()
        {
            Console.WriteLine("Method H : h");
        }
    }

    public class H1 : H
    {
        public void h1()
        {
            Console.WriteLine("Method H1 : h1");
        }
    }
    public class H2 : H
    {
        public void h2()
        {
            Console.WriteLine("Method H2 : h2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Single Inheritance
            Console.WriteLine("Single Inheritace\n");
            B b = new B();
            b.aa();
            b.ab();
            A a = new B();
            a.aa();
            b.ba();
            b.bb();
            Console.WriteLine(a.s);
            Console.WriteLine("\nMultilevel Inheritace\n");
            // Multilevel Inheritance
            CC c = new CC();
            c.m();
            c.mm();
            c.mmm();
            //Hierarchical Inheritance
            Console.WriteLine("\nHierarchical Inheritace\n");
            H d = new H();
            d.h();
            H1 d1 = new H1();
            d1.h1();
            d1.h();
            H2 d2 = new H2();
            d2.h2();
            d2.h();
        }
    }
}
