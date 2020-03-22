using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentM.A._010
{
    class DepartmentManage
    {
        static void Main(string[] args)
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee();
            salariedEmployee.AddToArray();

            HourlyEmployee hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.AddToArray();

            Console.WriteLine("List all employees: ");
            salariedEmployee.Output();
            hourlyEmployee.Output();

            Console.WriteLine("\n\n");
            Console.WriteLine("Search employee by department name: ");
            Department.SeachEmployeeByDepartmentName();

            Console.WriteLine("\n\n");
            Console.WriteLine("Search employee by employee name: ");
            Department.SearchByEmployeeName();


            Console.ReadKey();
        }
    }
}
