using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Deserialization
{
    [Serializable]
    public class Sample
    {
        public string fname ;
        public string mname;
        public string lname;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //XML DESERIALIZATION
            string path = @"C:\Users\RAHUL\Desktop\xmltester.txt";
            List<Sample> l = new List<Sample>();
            StreamReader sr = new StreamReader(path);
            XmlSerializer x = new XmlSerializer(typeof(List<Sample>), new XmlRootAttribute("Sample"));
            Sample s = new Sample();
            List<Sample> ss = (List<Sample>)x.Deserialize(sr);
            foreach(Sample xx in ss)
            {
                Console.WriteLine(xx.fname);
                Console.WriteLine(xx.mname);
                Console.WriteLine(xx.lname+"\n");
            }
        }
    }
}
