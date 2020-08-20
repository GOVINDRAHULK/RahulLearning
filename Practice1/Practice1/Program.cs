using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Xml.Serialization;

namespace Practice1
{   //Serializing Collection data in to XML format
    [Serializable]
    public class Xml
    {
        public List<Name> name { get; set; }
        public string mobile { get; set; }
        public string add { get; set; }
        public Xml()
        {
            name = new List<Name>();
        }
    }
    public class Name
    {
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }

        public Name() { }

        public Name(string fname,string mname, string lname)
        {
            this.fname = fname;
            this.mname = mname;
            this.lname = lname;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\RAHUL\Desktop\xmlnew.txt";
            
            //Serializing

            Name n = new Name();
            Xml x = new Xml();
            {
                x.name.Add(new Name("govind","rahul","kantheti"));
                x.mobile = "7550268844";
                x.add = "enclave";
            }
            Xml x2 = new Xml();
            {
                x2.name.Add(new Name("rohit", "rama", "kantheti"));
                x2.mobile = "8309072770";
                x2.add = "mahal";
            }

            List<Xml> p = new List<Xml>();
            p.Add(x);
            p.Add(x2);

            StreamWriter sw = new StreamWriter(path);
            XmlSerializer xx = new XmlSerializer(p.GetType(),new XmlRootAttribute("Details"));
            xx.Serialize(sw,p);
            sw.Close();

            //Deserializing
            
            StreamReader sr = new StreamReader(path);
            List<Xml> ss = (List<Xml>)xx.Deserialize(sr);
            
            foreach(Xml sss in ss)
            {
                foreach(Name ssss in sss.name)
                {
                    Console.WriteLine(ssss.fname);
                    Console.WriteLine(ssss.mname);
                    Console.WriteLine(ssss.lname);
                }
                    
                Console.WriteLine(sss.mobile);
                Console.WriteLine(sss.add + "\n");
            }


        }
    }
}
