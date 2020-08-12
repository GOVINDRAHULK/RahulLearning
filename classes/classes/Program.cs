using System;

namespace classes
{
    class Student
    {
        public string def ;
        public Student()
        { //Asigning value to the string def using default constructor. 
            def = "default message";
        }
       public string fname;
       public string mname;
       public string lname;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects for class Student 
            Student s = new Student();
            Student s1 = new Student();

            // Assigning values to the string fields 
            s.fname = "govind";
            s1.fname = "rohit";

            s.mname = "rahul";
            s1.mname = "rama";

            s.lname = "kantheti";
            s1.lname = "kantheti";

            //String Interpolation
            Console.WriteLine($"{s.fname} {s.mname} {s.lname} {s.def}");
            Console.WriteLine($"{s1.fname} {s1.mname} {s1.lname} {s1.def}");
        }
    }
}
