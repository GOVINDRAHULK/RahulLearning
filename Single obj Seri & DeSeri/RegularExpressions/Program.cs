using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RegularExpressions
{
    [Serializable]
    public class Person
    {
        public string fname { get; set; }
        public string lname { get; set; }
    }

    class DataSerializer
    {
        public void BinarySerialize(object data, string filepath)
        {
            if (File.Exists(filepath)) File.Delete(filepath);
            Stream fs = File.Create(filepath);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, data);
            fs.Close(); 
        }

        public object BinaryDeserialize(string filepath)
        {
            object obj = null;
            FileStream fss = File.OpenRead(filepath);
            BinaryFormatter bff = new BinaryFormatter();

            if(File.Exists(filepath))
            {
                obj = bff.Deserialize(fss);
                fss.Close();
            }
            return obj;
        }


        // XML SERIALIZER

        public void xmlserializer(Type datatype, object data, string filepath)
        {
            if (File.Exists(filepath)) File.Delete(filepath);
            StreamWriter sw = new StreamWriter(filepath);
            XmlSerializer x = new XmlSerializer(datatype);
            x.Serialize(sw, data);
            sw.Close();
        }

        public object xmldeserializer(Type datatype, string filepath)
        {
            object obj = null;

            StreamReader sr = new StreamReader(filepath);
            XmlSerializer xx = new XmlSerializer(datatype);
            obj = xx.Deserialize(sr);
            sr.Close();

            return obj;
        }

        // JSON SERIALIZER

        public void jsonserializer(object data, string filepath)
        {
            if (File.Exists(filepath)) File.Delete(filepath);
            StreamWriter sw = new StreamWriter(filepath);
            JsonSerializer j = new JsonSerializer();
            JsonWriter jw = new JsonTextWriter(sw);
            j.Serialize(jw, data);
            jw.Close();
            sw.Close();
        }

        public object jsondeserializer(Type datatype, string filepath)
        {
            JObject obj = null;

            JsonSerializer jj = new JsonSerializer();
            StreamReader sr = new StreamReader(filepath);
            JsonReader jr = new JsonTextReader(sr);
            obj = jj.Deserialize(jr) as JObject;

            return obj.ToObject(datatype);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\RAHUL\Desktop\bin3.txt";
            Person p = new Person();
            p.fname = "Rahul";
            p.lname = "kantheti";
            //DataSerializer a = new DataSerializer();
            //a.BinarySerialize(p,path);

            //Person pp = new Person();
            //pp = a.BinaryDeserialize(path) as Person;

            /*DataSerializer a = new DataSerializer();
            a.xmlserializer(typeof(Person),p,path);

            Person pp = new Person();
            pp = a.xmldeserializer(typeof(Person), path) as Person;*/

            DataSerializer a = new DataSerializer();
            a.jsonserializer(p, path);

            Person pp = new Person();
            pp = a.jsondeserializer(typeof(Person),path) as Person;

            Console.WriteLine($"{pp.fname}  ,  {pp.lname}");

        }
    }
}
