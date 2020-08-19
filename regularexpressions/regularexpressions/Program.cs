using System;
using System.Text.RegularExpressions;

namespace regularexpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capturing names string with R 
            string s = "Rohit,Rahul,Balaji,Sita" ;
            string pattern = @"[R]\w+";
            Regex r = new Regex(pattern);

            //Using Match class
            Match res = r.Match(s);
            while(res.Success)
            {
                Console.WriteLine(res.Value);
                res = res.NextMatch();
            }

            //Using Match Collection class
            MatchCollection matches = r.Matches(s);
            foreach(Match m in matches)
            {
                Console.WriteLine(m.Value);
            }

            //Group Collection
            foreach(Match mm in matches)
            {
                GroupCollection data = mm.Groups;
                Console.WriteLine(data[0]);
            }


            //Capturing the words ending with ing

            string s1 = "its raining outside, he is eating, he is bathing";
            string pattern2 = @"(\w*)ing";

            Regex r2 = new Regex(pattern2);
            MatchCollection matches1 = r2.Matches(s1);
            foreach(Match m in matches1)
            {
                GroupCollection gc = m.Groups;
                Console.WriteLine(gc[0]);
            }

            //Capturing Username and understanding the type of account in mail id
            string s2 = "govind.rahul.kantheti@signify.com,govindkantheti@gmail.com,govindrahul.kantheti2016@vitstudent.ac.in";
            string patter3 = @"(\w*\.?\w*\.?\w*\d?)@(\w*\.?\w*\.?\w*\d?)";

            Regex r3 = new Regex(patter3);
            MatchCollection matches2 = r3.Matches(s2);

            foreach (Match m in matches2)
            {
                GroupCollection gc2 = m.Groups;
                Console.WriteLine($"Mail id : {gc2[0]} ,Username : {gc2[1]}, Domain : {gc2[2]}");
            }

            //Replace Method
            string s3 = "govind.rahul.kantheti@signify.com,govindkantheti@gmail.com,govindrahul.kantheti2016@vitstudent.ac.in";
            string patter4 = @"(\w*\.?\w*\.?\w*\d?)@(\w*\.?\w*\.?\w*\d?)";

            Regex r4 = new Regex(patter4);
            string replaced = r4.Replace(s3,@"$2 of $1");
            Console.WriteLine(replaced);

            //Replace multiple spaces

            string s4 = "govind     rahul      kantheti";
            string pattern5 = @"\s+";

            Regex r5 = new Regex(pattern5);
            string replaced2 = r5.Replace(s4, " ");
            Console.WriteLine(replaced2);

            //Replace words starting with R with word replaced
            string s5 = "Rohit,Rahul,Balaji,Sita";
            string pattern6 = @"[R]\w+";

            Regex r6 = new Regex(pattern6);
            string replaced3 = r6.Replace(s5, "Replaced word");
            Console.WriteLine(replaced3);

            //Validate mobile number

            string pattern7 = @"(\(?\+?\d{2}\-?\)?\d{3}\-?\d{3}\-?\d{4})";
            string s6 = "+917013774541,+917550268844,+91-812-119-4367,(+91)8019112961,9247443410,+9247443411";
            Regex r7 = new Regex(pattern7);
            MatchCollection matches4 = r7.Matches(s6);

            foreach(Match m in matches4)
            {
                GroupCollection gc3 = m.Groups;
                Console.WriteLine($"Valid Mobile Number : { gc3[0]}") ;
            }

            //Spliting Method
            string s7 = "+917013774541,+917550268844,+91-812-119-4367,(+91)8019112961,9247443410,+9247443411";

            string[] split = Regex.Split(s7, @",");
            foreach(string x in split)
            {
                Console.WriteLine(x);
            }

            //IsMatch Method

            string pattern8 = @"(\(?\+?\d{2}\-?\)?\d{3}\-?\d{3}\-?\d{4})";
            string[] s8 = { "+917013774541" ,"+917550268844" ,"+91-812-119-4367" ,"(+91)8019112961","9247443410","+9247443411" };

            foreach(string xx in s8)
            {
                if (Regex.IsMatch(xx, pattern8))
                    Console.WriteLine($"{xx} is Valid Number");
                else
                    Console.WriteLine($"{xx} is Not Valid Number");
            }

            //BackReferencing - Number

            string s9 = "llab,bban,mkij,nnak,mjui,kijt";
            string pattern9 = @"(\w+)\1";
            Regex r9 = new Regex(pattern9);
            Match m2 = r9.Match(s9);
            while(m2.Success)
            {
                Console.Write(m2.Index+"\t");
                m2 = m2.NextMatch();
            }

            string s10 = "llab,bban,mkij,nnak,mjui,kijt";
            string pattern10 = @"(?<char>\w)\k<char>";
            Regex r10 = new Regex(pattern10);
            Match m3 = r10.Match(s10);
            while (m3.Success)
            {
                Console.WriteLine(m3.Index);
                m3 = m3.NextMatch();
            }



        }
    }
}
