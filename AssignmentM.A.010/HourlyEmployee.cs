using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentM.A._010
{
    public class HourlyEmployee : Employee
    {
        public static HourlyEmployee[] arrHourly;
        public double Wage { get; set; }
        public double WorkingHours { get; set; }
        public string department { get; set; }

        public void Input()
        {
            Console.Write("Department name: ");
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
            Console.Write("Wage: ");
            Wage = double.Parse(Console.ReadLine());
            Console.Write("Working hours: ");
            WorkingHours = double.Parse(Console.ReadLine());
        }
        public void AddToArray()
        {
            Console.Write("Enter numbers of hourly employee: ");
            int numbersEmployee = Int32.Parse(Console.ReadLine());
            arrHourly = new HourlyEmployee[numbersEmployee];
            for (int i = 0; i < arrHourly.Length; i++)
            {
                Console.WriteLine("Employee {0}", i + 1);
                arrHourly[i] = new HourlyEmployee();
                arrHourly[i].Input();
            }
        }
        public void Output()
        {
            foreach (var item in arrHourly)
            {
                Console.WriteLine($"Department name: {item.department}, " +
                    $"SSN: {item.SSN}, {item.FirstName} {item.LastName}, " +
                    $"Phone: {item.Phone}, " +
                    $"Email: {item.Email}, " +
                    $"BirthData: {item.BirthDate}, " +
                    $"Wage:{item.Wage}, " +
                    $"Working hours: {item.WorkingHours}");
            }
        }


    }
}
