using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Mourinho is a \"special one\"";
            string str2 = @"Mourinho is a ""special one""";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine("this is a string \nthis is a string");

            string str3 = "abc";
            string str4 = "dce";

            Console.WriteLine(String.Concat(str3, str4));

            string str5 = "Ronaldo is a good player";
            Console.WriteLine(str5.Substring(0, 7)); // output is Ronaldo


            Console.ReadKey();
        }
    } 
}
