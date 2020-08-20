using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Sample
    {
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
    }
    

    public class SerializationClass
    {
        public void xmlserializer(Type datatype, object data, string filepath)
        {
            if (File.Exists(filepath)) File.Delete(filepath) ;
            StreamWriter sw = new StreamWriter(filepath);
            XmlSerializer x = new XmlSerializer(datatype, new XmlRootAttribute("Sample"));
            x.Serialize(sw, data);
            sw.Close();
        }

        public void jsonserializer(object data,string filepath)
        {
            
            if (File.Exists(filepath)) File.Delete(filepath);
            StreamWriter sw = new StreamWriter(filepath);
            JsonWriter jw = new JsonTextWriter(sw);
            JsonSerializer j = new JsonSerializer();
            j.Serialize(jw, data);
            sw.Close();
            jw.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\RAHUL\Desktop\jsontester.txt";
            Sample p1 = new Sample();
            p1.fname = "govind";
            p1.mname = "rahul";
            p1.lname = "kantheti";

            Sample p2 = new Sample();
            p2.fname = "kantheti";
            p2.mname = "govind";
            p2.lname = "rahul";

            List<Sample> p = new List<Sample>();
            p.Add(p1);
            p.Add(p2);

            SerializationClass sc = new SerializationClass();
            sc.xmlserializer(p.GetType(), p,path);
            var dataObj = new { Data = p};
            sc.jsonserializer(dataObj, path);

        }
    }
}
