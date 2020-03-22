using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolationLab
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Lionel";
            customer.LastName = "Messi";
            customer.Age = 40;

            Console.WriteLine($"Full name is {customer.FirstName} {customer.LastName} and his age is {customer.Age} {(customer.Age < 40 ? "Year": "Years")}");
            Console.ReadKey();
        }
    }
}
