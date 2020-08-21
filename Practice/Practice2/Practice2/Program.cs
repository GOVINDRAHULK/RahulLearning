using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Practice2
{
    //Serializing and Deserializing Collection data in to Json format
    [Serializable]
    public class Json
    {
        public List<Name> name { get; set; }
        public string mobile { get; set; }
        public string add { get; set; }
        public Json()
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

        public Name(string fname, string mname, string lname)
        {
            this.fname = fname;
            this.mname = mname;
            this.lname = lname;
        }
    }
    public class Root
    {
        public List<Json> Data { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\RAHUL\Desktop\jsonnew.txt";

            //Serializing

            Name n = new Name();
            Json x = new Json();
            {
                x.name.Add(new Name("govind", "rahul", "kantheti"));
                x.mobile = "7550268844";
                x.add = "enclave";
            }
            Json x2 = new Json();
            {
                x2.name.Add(new Name("rohit", "rama", "kantheti"));
                x2.mobile = "8309072770";
                x2.add = "mahal";
            }

            List<Json> p = new List<Json>();
            p.Add(x);
            p.Add(x2);

            StreamWriter sw = new StreamWriter(path);
            JsonWriter jw = new JsonTextWriter(sw);
            JsonSerializer jj = new JsonSerializer();
            var dataObj = new { Data = p };
            jj.Serialize(jw,dataObj);
            sw.Close();

            //Deserializing

            StreamReader sr = new StreamReader(path);
            string line;
            string json2 = "";
            while ((line = sr.ReadLine()) != null)
            {
                json2 += line;
            }

            var obj = JsonConvert.DeserializeObject<Root>(json2);

            foreach (var sss in obj.Data)
            {
                foreach (Name ssss in sss.name)
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
