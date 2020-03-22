using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrMultiple = new int[3, 4] {
                {1,2,3,4 },
                { 2,3,4,5},
                { 2,4,5,6},
            };

            Console.Write(arrMultiple[1, 2]);

            int[] marks = new int[3];
            marks[0] = 10;
            marks[1] = 8;
            marks[2] = 6;

            int[] mark2 = { 10, 8, 6 };
            
            Console.ReadKey();

        }
    }
}
