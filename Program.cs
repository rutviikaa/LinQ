using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> basicMethod = Employee.GetEmployees().ToList();
            foreach (Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            List<Employee> selectMethod = Employee.GetEmployees().Select(emp => new Employee() { First_Name = emp.First_Name, Last_Name = emp.Last_Name }).ToList();
            foreach (var emp in selectMethod)
            {
                Console.WriteLine($" Name : {emp.First_Name} {emp.Last_Name}  ");
            }

            List<Employee> Method = Employee.GetEmployees().Select(emp => new Employee() { First_Name = emp.First_Name }).ToList();
            foreach (var emp in Method)
            {
                Console.WriteLine($" Employee Name : {emp.First_Name}  ");
            }

            string[] Upper = Employee.GetEmployees().Select(emp => emp.First_Name.ToUpper()).ToArray();
            foreach (var emp in Upper)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }

            string[] Lower = Employee.GetEmployees().Select(emp => emp.First_Name.ToLower()).ToArray();
            foreach (var emp in Lower)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }

            var unique = Employee.GetEmployees().Select(e => e.Department).Distinct().ToList();
            foreach (var dept in unique)
            {
                Console.WriteLine($" Department : {dept}  ");
            }

            //var text = Employee.GetEmployees().Select(First_Name => String.Join("",First_Name).Take(3)).ToList();
            //foreach (var name in text)
            //{
            //    Console.WriteLine($" Employee Name : {name}  ");
            //}

            //var n = Employee.GetEmployees().Select(emp => emp.First_Name = "John" );
            string n = "John";
            char[] textarray = n.ToCharArray();

            for (int i = 1; i < n.Length; i++)
            {
                if (textarray[i].Equals('o'))
                {
                    Console.WriteLine("The letter is present in " + (i + 1) + "th position");
                    break;
                }

            }

            var trimr = Employee.GetEmployees().Select(e => e.First_Name.TrimEnd()).ToList();
            foreach (var emp in trimr)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }

            var triml = Employee.GetEmployees().Select(e => e.First_Name.TrimStart()).ToList();
            foreach (var emp in triml)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }

            var len = Employee.GetEmployees().Select(e => e.First_Name.Length).ToList();
            foreach (var emp in len)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }

            var re = Employee.GetEmployees().Select(e => e.First_Name.Replace("o","$")).ToList();
            foreach (var emp in re)
            {
                Console.WriteLine($" Employee Name : {emp}  ");
            }

            List<Employee> flname = Employee.GetEmployees().Select(emp => new Employee() { First_Name = emp.First_Name, Last_Name = emp.Last_Name }).ToList();
            foreach (var emp in flname)
            {
                Console.WriteLine($" Name : {emp.First_Name}_{emp.Last_Name}  ");
            }

            var join = Employee.GetEmployees().Select(e => new { First_Name = e.First_Name, Joining_Year = e.Joining_Date.Year, Joining_Month = e.Joining_Date.Month, Joining_Date = e.Joining_Date.Day });
            foreach (var emp in join)
            {
                Console.WriteLine($" Name : {emp.First_Name}  Joining Year : {emp.Joining_Year}  Joining Month : {emp.Joining_Month} Joining Day : {emp.Joining_Date}");
            }

            var asc = Employee.GetEmployees().OrderBy(e => e.First_Name).ToList();
            foreach (var emp in asc)
            {
                Console.WriteLine($"Name : {emp.First_Name}");
            }

            var de = Employee.GetEmployees().OrderByDescending(e => e.First_Name).ToList();
            foreach (var emp in de)
            {
                Console.WriteLine($"Name : {emp.First_Name}");
            }

            var ad = Employee.GetEmployees().OrderBy(e => e.First_Name).ThenByDescending(e=>e.Salary).ToList();
            foreach (var emp in ad)
            {
                Console.WriteLine($"Name : {emp.First_Name}  Salary : {emp.Salary}");
            }

            var en = Employee.GetEmployees().Where(e => e.First_Name == "John");
            foreach (var e in en)
            {
                Console.WriteLine($"Name : {e.First_Name}");
            }

            var en2 = Employee.GetEmployees().Where(e => e.First_Name == "John" || e.First_Name =="Roy");
            foreach (var e in en2)
            {
                Console.WriteLine($"Name : {e.First_Name}");
            }

            var en3 = Employee.GetEmployees().Where(e => e.First_Name != "John" || e.First_Name != "Roy");
            foreach (var e in en3)
            {
                Console.WriteLine($"Name : {e.First_Name}");
            }

            var en4 = Employee.GetEmployees().Where(e => e.First_Name.StartsWith("J"));
            foreach (var e in en4)
            {
                Console.WriteLine($"Name : {e.First_Name}");
            }

            var en5 = Employee.GetEmployees().Where(e => e.First_Name.Contains("o"));
            foreach (var e in en5)
            {
                Console.WriteLine($"Name : {e.First_Name}");
            }

            var en6 = Employee.GetEmployees().Where(e => e.First_Name.EndsWith("n"));
            foreach (var e in en6)
            {
                Console.WriteLine($"Name : {e.First_Name}");
            }

            //var q = Employee.GetEmployees().Select(e => e.First_Name.StartsWith("J") && e.First_Name => String.Join("", First_Name).Take(4)));

            var q = Employee.GetEmployees().Where(e => e.Salary > 600000).ToList();
            foreach (var emp in q)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var s = Employee.GetEmployees().Where(e => e.Salary < 800000).ToList();
            foreach (var emp in s)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var sa = Employee.GetEmployees().Where(e => e.Salary >= 500000 && e.Salary <= 800000);
            foreach (var emp in sa)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var sn = Employee.GetEmployees().Where(e=> e.First_Name == "John" || e.First_Name == "Michael");
            foreach (var emp in sn)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var dt = Employee.GetEmployees().Where (e=> e.Joining_Date.Year == 2013);
            foreach (var emp in dt)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var mn = Employee.GetEmployees().Where (e=> e.Joining_Date.Month == 01);
            foreach (var emp in mn)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var jmn = Employee.GetEmployees().Where (e=> e.Joining_Date < (01,01,2013));
            foreach (var emp in jmn)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var jmnt = Employee.GetEmployees().Where (e=> e.Joining_Date > (01,01,2013));
            foreach (var emp in jmnt)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var ti = Employee.GetEmployees().Select (e=> new {   Joining_Date = e.Joining_Date.Day, Joining_Time = e.Joining_Date.TimeOfDay });
            foreach (var emp in ti)
            {
                Console.WriteLine($"Joining Date : {emp.Joining_Date} Time : {emp.Joining_Time}");
            }


            Console.ReadKey();
        }
    }
}
