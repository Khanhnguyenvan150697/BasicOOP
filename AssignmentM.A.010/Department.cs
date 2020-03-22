using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentM.A._010
{
    public class Department
    {
        private Department[] arrayDepartment;
        public string DepartmentName { get; set; }
        public List<SalariedEmployee> SalariedEmployees { get;set; }
        public List<HourlyEmployee> HourlyEmployees { get; set; }

        public static void SeachEmployeeByDepartmentName()
        {
            Console.Write("Enter your key search: ");
            string key = Console.ReadLine();
            if(key.Equals("Sa"))
            {
                foreach(var item in HourlyEmployee.arrHourly)
                {
                    Console.WriteLine($"name: {item.FirstName} {item.LastName}, Phone: {item.Phone}");
                }
                Console.WriteLine("Done");
            }

            if (key.Equals("Salaried department"))
            {
                foreach (var item in SalariedEmployee.arrSalaried)
                {
                    Console.WriteLine($"name: {item.FirstName} {item.LastName}, Phone: {item.Phone}");
                }
                Console.WriteLine("Done");
            }
        }

        public static void SearchByEmployeeName()
        {
            Console.Write("Nhap ten nhan vien: ");
            string keyName = Console.ReadLine();

            var arrSalariedEmployee = SalariedEmployee.arrSalaried;
            var arrHourlyEmployee = HourlyEmployee.arrHourly;

            for(int i = 0; i< arrSalariedEmployee.Length; i++)
            {
                if (arrSalariedEmployee[i].LastName.Equals(keyName))
                {
                    Console.WriteLine($"name: {arrSalariedEmployee[i].FirstName} {arrSalariedEmployee[i].LastName}, " +
                        $"Phone: {arrSalariedEmployee[i].Phone}, " +
                        $"Email: {arrSalariedEmployee[i].Email}, " +
                        $"Birth date: {arrSalariedEmployee[i].BirthDate}, " +
                        $"Commission rate: {arrSalariedEmployee[i].commissionRate}," +
                        $" Gross sale: {arrSalariedEmployee[i].GrossSales}, " +
                        $"Basic salary: {arrSalariedEmployee[i].BasicSalary}");
                }
            }
            
            for(int i = 0; i<arrHourlyEmployee.Length; i++)
            {
                if (arrHourlyEmployee[i].LastName.Equals(keyName))
                {
                    Console.WriteLine($"name: {arrSalariedEmployee[i].FirstName} {arrSalariedEmployee[i].LastName}, " +
                        $"Phone: {arrSalariedEmployee[i].Phone}," +
                        $"Email: {arrHourlyEmployee[i].Email}," +
                        $"Birth date: {arrHourlyEmployee[i].BirthDate}," +
                        $"Wage: {arrHourlyEmployee[i].Wage}," +
                        $"Working hours: {arrHourlyEmployee[i].WorkingHours}");
                }
            }
        }

        public void ListTypesOfDepartment()
        {
            var arrSalariedEmployee = SalariedEmployee.arrSalaried;
            var arrHourlyEmployee = HourlyEmployee.arrHourly;

            Console.WriteLine("List of departments: ");
            foreach(var item in arrayDepartment)
            {
                Console.WriteLine(item.DepartmentName);
            }


        }

    }
}
