using System;
using System.IO;

namespace Fileoperations
{
    class Program
    {
        static void Main(string[] args)
        {
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
