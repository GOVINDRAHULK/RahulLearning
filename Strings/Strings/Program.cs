using System;
using System.Linq;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //CharArray to String
            char[] a = {'a','b','c','d','e'};
            string b = new string(a);
            Console.WriteLine(b);

            //String to CharArray
            char[] c = b.ToCharArray();
            Console.WriteLine(c);

            //String length
            Console.WriteLine($"{b.Length}");

            string s = "hello";
            string ss = "world";

            //Compare function 0:equal s1>s2:1 s1<s2:-1 
            Console.WriteLine($"{string.Compare(s,ss)}");

            //Concat function
            Console.WriteLine($"{string.Concat(s,ss)}");

            //Contains function
            Console.WriteLine($"{s.Contains("el")}");

            //EndsWith function
            Console.WriteLine($"{s.EndsWith("lo")}");
            Console.WriteLine($"{s.EndsWith("l")}");

            //Indexof function
            Console.WriteLine($"{s.IndexOf('o')}");
            Console.WriteLine($"{s.IndexOf("lo")}");
            Console.WriteLine($"{s.IndexOf('l',3)}");

            //Insert function
            Console.WriteLine($"{s.Insert(2,"a")}");

            //Join function
            string[] j = {"a","b","c","d"};
            Console.WriteLine(string.Join("-",j));

            //Remove function
            Console.WriteLine(s.Remove(2,0));

            //Replace function
            Console.WriteLine(s.Replace('h','r'));

            //Split function
            Console.WriteLine(s.Split("-",4));

            //ToLower function
            Console.WriteLine(s.ToLower());

            //ToUpper function
            Console.WriteLine(ss.ToUpper());

            //PadLeft function
            Console.WriteLine(s.PadLeft(10,'.'));

            //PadRight function
            Console.WriteLine(s.PadRight(10,'.'));

            //Trim function
            char c1 = '*';
            string s1 = "***RahulGovindKantheti***";
            Console.WriteLine(s1.Trim(c1));

            //Equals function
            string m1 = "Hello";
            string m2 = "hell no";
            string m3 = "Hello";
            Console.WriteLine(Equals(m1,m2));
            Console.WriteLine(Equals(m1,m3));
        }
    }
}
