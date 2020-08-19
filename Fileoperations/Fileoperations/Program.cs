using System;
using System.IO;
using System.Text;

namespace Fileoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //File Class

            try
            {
                string path = @"C:\Users\RAHUL\Desktop\fileinput.txt";
                if (File.Exists(path)) File.Delete(path);
                //Using file stream to create file
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is Testing");
                    fs.Write(info, 0, info.Length);
                }

                //Using file stream to read file
                using (FileStream fs = File.OpenRead(path))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine(temp.GetString(b));
                    }
                }
                

                //Using StreamWriter to create file
                if (File.Exists(path)) File.Delete(path);
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine("Testing from StreamWriter");
                sw.Close();

                string[] rt = File.ReadAllLines(path);
                foreach (string s in rt)
                {
                    Console.WriteLine(s);
                }
                string rt2 = File.ReadAllText(path);
                Console.WriteLine(rt2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Data writing into file and reading from file using FileStream
            try
            {
                FileStream f = new FileStream("C:\\Users\\RAHUL\\Desktop\\Signify codes\\Fileoperations\\Fileoperations\\input.txt", FileMode.Open, FileAccess.ReadWrite);
                for(int i=0;i<10;i++)
                {
                    f.WriteByte((byte)i);
                }
                f.Position = 0;
                for (int i=0;i<10;i++)
                {
                    Console.WriteLine(f.ReadByte());
                }
                f.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Data writing into file and reading from file using StreamReader and StreamWriter

            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\RAHUL\\Desktop\\Signify codes\\Fileoperations\\Fileoperations\\input.txt");
                StreamReader sr = new StreamReader("C:\\Users\\RAHUL\\Desktop\\Signify codes\\Fileoperations\\Fileoperations\\input.txt");

                string[] a = {"rahul","govind","kantheti"};
                foreach(string n in a)
                {
                    sw.WriteLine(n);
                }
                sw.Close();
                string line;

                StreamWriter ss = new StreamWriter("C:\\Users\\RAHUL\\Desktop\\Signify codes\\Fileoperations\\Fileoperations\\output.txt");
                while ((line = sr.ReadLine())!=null)
                {
                    ss.WriteLine(line);
                    Console.WriteLine(line);
                }
                ss.Close();
                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
