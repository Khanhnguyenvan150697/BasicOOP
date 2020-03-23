using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentM.A._010
{
    class DepartmentManage
    {
        static void Main(string[] args)
        {
            List<Department> listDepartment = new List<Department>();
            Department nhan_su_department = new Department
            {
                DepartmentName = "nhan su",
                ListEmployees = new List<Employee>()
            };
            Department hanh_chinh_department = new Department 
            {
                DepartmentName = "hanh chinh",
                ListEmployees = new List<Employee>()
            };
            Department san_xuat_department = new Department
            {
                DepartmentName = "san xuat",
                ListEmployees = new List<Employee>()
            };

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine("Moi ban chon loai nhan vien 1 hoac 2");
                Console.WriteLine("1. Salaried employee: ");
                Console.WriteLine("2. Hourly employee: ");
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        SalariedEmployee newSalariedEmp = new SalariedEmployee();
                        newSalariedEmp = CreateSalariedEmp();
                        Console.Write("Nhap ten phong ban: ");
                        string dpName = Console.ReadLine();
                        if (dpName.Equals(nhan_su_department.DepartmentName))
                        {
                            nhan_su_department.ListEmployees.Add(newSalariedEmp);
                            nhan_su_department.DepartmentName = dpName;
                            listDepartment.Add(nhan_su_department);
                        }
                        if (dpName.Equals(hanh_chinh_department.DepartmentName))
                        {
                            hanh_chinh_department.ListEmployees.Add(newSalariedEmp);
                            hanh_chinh_department.DepartmentName = dpName;
                            listDepartment.Add(hanh_chinh_department);
                        }
                        if (dpName.Equals(san_xuat_department))
                        {
                            san_xuat_department.ListEmployees.Add(newSalariedEmp);
                            san_xuat_department.DepartmentName = dpName;
                            listDepartment.Add(san_xuat_department);
                        }
                        break;
                    case 2:
                        HourlyEmployee newHourlyEmp = new HourlyEmployee();
                        newHourlyEmp = CreateHourlyEmp();
                        Console.Write("Nhap ten phong ban: ");
                        string dpName2 = Console.ReadLine();
                        if (dpName2.Equals(nhan_su_department.DepartmentName))
                        {
                            nhan_su_department.ListEmployees.Add(newHourlyEmp);
                            nhan_su_department.DepartmentName = dpName2;
                            listDepartment.Add(nhan_su_department);
                        }
                        if (dpName2.Equals(hanh_chinh_department.DepartmentName))
                        {
                            hanh_chinh_department.ListEmployees.Add(newHourlyEmp);
                            hanh_chinh_department.DepartmentName = dpName2;
                            listDepartment.Add(hanh_chinh_department);
                        }
                        if (dpName2.Equals(san_xuat_department.DepartmentName))
                        {
                            san_xuat_department.ListEmployees.Add(newHourlyEmp);
                            san_xuat_department.DepartmentName = dpName2;
                            listDepartment.Add(san_xuat_department);
                        }
                        break;
                    default:
                        Console.WriteLine("Ban chi duoc nhap 1 hoac 2");
                        break;
                }
            }

            Console.WriteLine("=========================== \n");
            Console.Write("Nhap vao ten phong ban: ");
            string nameDP = Console.ReadLine();
            if (nameDP.Equals(nhan_su_department.DepartmentName))
            {
                foreach (var item in listDepartment[0].ListEmployees)
                {
                    Console.WriteLine($"Name: {item.FirstName} {item.LastName}, " +
                        $"Email: {item.Email}, " +
                        $"Phone: {item.Phone}, " +
                        $"BirthDate: {item.BirthDate}");
                }
            }
            if (nameDP.Equals(hanh_chinh_department.DepartmentName))
            {
                foreach (var item in listDepartment[1].ListEmployees)
                {
                    Console.WriteLine($"Name: {item.FirstName} {item.LastName}, " +
                        $"Email: {item.Email}, " +
                        $"Phone: {item.Phone}, " +
                        $"BirthDate: {item.BirthDate}");
                }
            }
            if (nameDP.Equals(san_xuat_department.DepartmentName))
            {
                foreach (var item in listDepartment[2].ListEmployees)
                {
                    Console.WriteLine($"Name: {item.FirstName} {item.LastName}, " +
                        $"Email: {item.Email}, " +
                        $"Phone: {item.Phone}, " +
                        $"BirthDate: {item.BirthDate}");
                }
            }

            Console.WriteLine("=========================== \n");
            Console.Write("Nhap vao ten nhan vien: ");
            string nameEmp = Console.ReadLine();
            for(int i = 0; i<listDepartment.Count; i++)
            {
                for(int j = 0; j<listDepartment[i].ListEmployees.Count; j++)
                {
                    if (nameEmp.Equals(listDepartment[i].ListEmployees[j].LastName))
                    {
                        Console.Write("Department: " + listDepartment[i].DepartmentName);
                        foreach(var item in listDepartment[i].ListEmployees)
                        {
                            Console.WriteLine($"Name: {item.FirstName} {item.LastName}, " +
                                $"Phone: {item.Phone}, " +
                                $"Email: {item.Email}, " +
                                $"Birth date: {item.BirthDate}");
                        }
                        break;
                    }
                }
            }
            Console.WriteLine("=========================== \n");
            Console.Write("Danh sach cac phong ban: ");
            Console.Write("Cac phong ban co nhan vien la: ");
            for (int i = 0; i < listDepartment.Count; i++)
            {
                if (listDepartment[i].ListEmployees.Count == 0)
                {
                    continue;
                }
                Console.Write("\t" + listDepartment[i].DepartmentName + "\n");
                Console.WriteLine($"So nhan vien cua phong {listDepartment[i].DepartmentName} la: {listDepartment[i].ListEmployees.Count}");
            }
            Console.ReadKey();
        }
        public static SalariedEmployee CreateSalariedEmp()
        {
            SalariedEmployee salariedEmp = new SalariedEmployee();
            Console.Write("SSN: ");
            string ssn = Console.ReadLine();
            salariedEmp.SSN = ssn;
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            salariedEmp.FirstName = firstName;
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            salariedEmp.LastName = lastName;
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            if (ValidatePhone(phone))
            {
                salariedEmp.Phone = phone;
            }
            else
            {
                Console.WriteLine("phone is incorrect");
            }
            salariedEmp.Phone = phone;
            Console.Write("Email: ");
            string email = Console.ReadLine();
            if (ValidateEmail(email))
            {
                salariedEmp.Email = email;
            }
            else
            {
                Console.WriteLine("email is incorrect");
            }
            Console.Write("Birth date: ");
            string birthDate = Console.ReadLine();
            if (ConvertToDateTime(birthDate))
            {
                salariedEmp.BirthDate = birthDate;
            }
            else
            {
                Console.WriteLine("birth date is incorrect");
            }
            Console.Write("Commission sales: ");
            double commissionRate = double.Parse(Console.ReadLine());
            salariedEmp.CommissionRate = commissionRate;
            Console.Write("Basic salary: ");
            double basicSalary = double.Parse(Console.ReadLine());
            salariedEmp.BasicSalary = basicSalary;
            Console.Write("Gross sales: ");
            double grossSales = double.Parse(Console.ReadLine());
            salariedEmp.GrossSales = grossSales;

            return salariedEmp;
        }

        public static HourlyEmployee CreateHourlyEmp()
        {
            HourlyEmployee hourlyEmp = new HourlyEmployee();
            Console.Write("SSN: ");
            string ssn = Console.ReadLine();
            hourlyEmp.SSN = ssn;
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            hourlyEmp.FirstName = firstName;
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            hourlyEmp.LastName = lastName;
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            if (ValidatePhone(phone))
            {
                hourlyEmp.Phone = phone;
            }
            else
            {
                Console.WriteLine("phone is incorrect");
            }
            Console.Write("Email: ");
            string email = Console.ReadLine();
            if (ValidateEmail(email))
            {
                hourlyEmp.Email = email;
            }
            else
            {
                Console.WriteLine("email is incorrect");
            }
            Console.Write("Birth date: ");
            string birthDate = Console.ReadLine();
            if (ConvertToDateTime(birthDate))
            {
                hourlyEmp.BirthDate = birthDate;
            }
            else
            {
                Console.WriteLine("birth date is incorrect");
            }
            Console.Write("Wage: ");
            double wage = double.Parse(Console.ReadLine());
            hourlyEmp.Wage = wage;
            Console.Write("Working hours: ");
            double workingHours = double.Parse(Console.ReadLine());
            hourlyEmp.WorkingHours = workingHours;

            return hourlyEmp;
        }
        public static bool ConvertToDateTime(string date)
        {
            DateTime outDate;
            return DateTime.TryParseExact(date, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out outDate);

        }

        public static bool ValidatePhone(string phone)
        {
            if (phone.Length < 7)
                return false;
            return true;
        }
        public static bool ValidateEmail(string email)
        {
            const string regex = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";
            if (email != null)
                return Regex.IsMatch(email, regex);
            else
                return false;
        }
    }
}
