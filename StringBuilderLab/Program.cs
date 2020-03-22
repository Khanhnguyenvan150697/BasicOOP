using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderLab
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Messi is a good player");

            //Append() method
            Console.WriteLine(sb.Append(", Ronaldo is also"));

            //AppendFormat() method
            StringBuilder sb2 = new StringBuilder("My salary is: ");
            sb2.AppendFormat("{0:C2}", 2500);
            Console.WriteLine(sb2);

            //Replace() method

            StringBuilder sb3 = new StringBuilder("create new password");
            Console.WriteLine(sb3.Replace("new", "a new")); // replace "new" to "a new"

            Console.ReadKey();
        }
    }
}
