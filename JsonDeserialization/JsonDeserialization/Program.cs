using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Sample
{
	public string fname{ get;set;}
	public string mname { get; set; }
	public string lname { get; set; }
}

public class Root
{
	public List<Sample> Data { get; set; }
}

public class Program
{
	public static void Main()
	{
		string path = @"C:\Users\RAHUL\Desktop\jsontester.txt";

		StreamReader sr = new StreamReader(path);
		string line;
		string json2="";
		while((line = sr.ReadLine())!=null)
        {
			json2 += line;
        }

		var obj = JsonConvert.DeserializeObject<Root>(json2);

		foreach (var item in obj.Data)
		{
			Console.WriteLine(item.fname);
			Console.WriteLine(item.mname);
			Console.WriteLine(item.lname);
		}


	}
}


