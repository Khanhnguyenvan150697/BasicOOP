using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentM.A._010
{
    public class SalariedEmployee : Employee
    {
        public static SalariedEmployee[] arrSalaried;
        public double commissionRate { get; set; }
        public double GrossSales { get; set; }
        public double BasicSalary { get; set; }
        public string department { get; set; }

        public SalariedEmployee InputData()
        {
            SalariedEmployee newEmpl = new SalariedEmployee();
            Console.WriteLine("Department name: ");
            newEmpl.department = Console.ReadLine();
            Console.Write("SSN: ");
            newEmpl.SSN = Console.ReadLine();
            Console.Write("First name: ");
            newEmpl.FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            newEmpl.LastName = Console.ReadLine();
            Console.Write("Phone: ");
            newEmpl.Phone = Console.ReadLine();
            Console.Write("Email: ");
            newEmpl.Email = Console.ReadLine();
            Console.Write("Birth date: ");
            newEmpl.BirthDate = Console.ReadLine();
            Console.Write("Commission rate: ");
            newEmpl.commissionRate = double.Parse(Console.ReadLine());
            Console.Write("Gross sales: ");
            newEmpl.GrossSales = double.Parse(Console.ReadLine());
            Console.Write("Basic salary: ");
            newEmpl.BasicSalary = double.Parse(Console.ReadLine());
            return newEmpl;
        }
        public void Input()
        {
            Console.WriteLine("Department name: ");
            department = Console.ReadLine();
            Console.Write("SSN: ");
            SSN = Console.ReadLine();
            Console.Write("First name: ");
            FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            LastName = Console.ReadLine();
            Console.Write("Phone: ");
            Phone = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("Birth date: ");
            BirthDate = Console.ReadLine();
            Console.Write("Commission rate: ");
            commissionRate = double.Parse(Console.ReadLine());
            Console.Write("Gross sales: ");
            GrossSales = double.Parse(Console.ReadLine());
            Console.Write("Basic salary: ");
            BasicSalary = double.Parse(Console.ReadLine());
        }
        public void AddToArray()
        {
            Console.Write("Enter numbers of salaried employee: ");
            int numbersEmployee = Int32.Parse(Console.ReadLine());
            arrSalaried = new SalariedEmployee[numbersEmployee];
            for (int i = 0; i < arrSalaried.Length; i++)
            {
                Console.WriteLine("Employee {0}", i + 1);
                arrSalaried[i] = new SalariedEmployee();
                arrSalaried[i].Input();
            }
        }
        public void Output()
        {
            foreach(var item in arrSalaried)
            {
                Console.WriteLine($"Department name: {item.department}, " +
                    $"SSN: {item.SSN}, {item.FirstName} {item.LastName}," +
                    $" Phone: {item.Phone}, Email: {item.Email}, " +
                    $"BirthData: {item.BirthDate}, " +
                    $"Commission:{item.commissionRate}, " +
                    $"Gross: {item.GrossSales}, " +
                    $"salary: {item.BasicSalary}");
            }
        }
    }
}
