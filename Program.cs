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

            var jmn = Employee.GetEmployees().Where (e=> e.Joining_Date < new DateTime(2013,01,01));
            foreach (var emp in jmn)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var jmnt = Employee.GetEmployees().Where (e=> e.Joining_Date > new DateTime(2013,01,01));
            foreach (var emp in jmnt)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var ti = Employee.GetEmployees().Select (e=> new {   Joining_Date = e.Joining_Date.Day, Joining_Time = e.Joining_Date.TimeOfDay });
            foreach (var emp in ti)
            {
                Console.WriteLine($"Joining Date : {emp.Joining_Date} Time : {emp.Joining_Time}");
            }


            var mi = Employee.GetEmployees().Select (e=> new {   Joining_Date = e.Joining_Date, Joining_Time = e.Joining_Date.Millisecond });
            foreach (var emp in mi)
            {
                Console.WriteLine($"Joining Date : {emp.Joining_Date} Time : {emp.Joining_Time}");
            }

            //var ij = Employee.GetEmployees().Join(Incentive.GetIncentives(), emp=>emp.Employee_Id, inc => inc.Employee_Ref_Id,(emp,inc)=> new {First_Name= emp.First_Name, Difference_Date = inc.Incentive_Date - emp.Joining_Date }).ToList();
            //foreach (var emp in ij)
            //{
            //   Console.WriteLine($"Joining Date : {emp.Joining_Date} Time : {emp.Joining_Time}");
            //}


            //var date = DateTime.Now();
            //Console.WriteLine(date);

            var con = Employee.GetEmployees().Where(e=>e.Last_Name.Contains("%"));
            foreach (var emp in con)
            {
                Console.WriteLine($"ID : {emp.Employee_Id} Name : {emp.First_Name} {emp.Last_Name} Salary : {emp.Salary} Joining Date : {emp.Joining_Date} Department : {emp.Department}");
            }

            var rep = Employee.GetEmployees().Select(e=>e.Last_Name.Replace("%"," "));
            foreach (var emp in rep)
            {
                Console.WriteLine($"Name : {emp} ");
            }

            var gb = Employee.GetEmployees().GroupBy(e=>e.Department).Select(a=>new {Total_Salary= a.Sum(e=>e.Salary)});
            foreach (var emp in gb)
            {
                Console.WriteLine($"Total Salary : {emp.Total_Salary} ");
            }

            var ob = Employee.GetEmployees().GroupBy(e=>e.Department).Select(a=>new { Total_Salary= a.Sum(e=>e.Salary)}).OrderByDescending(a=>a.Total_Salary);
            foreach (var emp in ob)
            {
                Console.WriteLine($"Total Salary (Desc) : {emp.Total_Salary} ");
            }

            //var cn = Employee.GetEmployees().GroupBy(e=>e.Department).Select(a=>new { First_Name = a.First_Name, Total_Salary= a.Sum(e=>e.Salary)}).Count(a=>a.First_Name).OrderByDescending(a=>a.Total_Salary);
            //foreach (var emp in cn)
            //{
            //   Console.WriteLine($"Total Salary (Department) : {emp.Total_Salary} ");
            //}

            var avg = Employee.GetEmployees().GroupBy(e=>e.Department).Select(a=>new { Avg_Salary= a.Average(e=>e.Salary)}).OrderBy(a=>a.Avg_Salary);
            foreach (var emp in avg)
            {
                Console.WriteLine($"Average Salary (Department) : {emp.Avg_Salary} ");
            }

            var max = Employee.GetEmployees().GroupBy(e=>e.Department).Select(a=>new { Max_Salary= a.Max(e=>e.Salary)}).OrderBy(a=>a.Max_Salary);
            foreach (var emp in max)
            {
                Console.WriteLine($"Maximum Salary (Department) : {emp.Max_Salary} ");
            }

            var min = Employee.GetEmployees().GroupBy(e=>e.Department).Select(a=>new { Min_Salary= a.Min(e=>e.Salary)}).OrderBy(a=>a.Min_Salary);
            foreach (var emp in min)
            {
                Console.WriteLine($"Minimum Salary (Department) : {emp.Min_Salary} ");
            }

            var ym = Employee.GetEmployees().GroupBy(g => new {Year = g.Joining_Date.Year, Month = g.Joining_Date.Month}).Select(a=> new {No_of_Emp = a.Count()}).ToList();
            foreach (var emp in ym)
            {
                Console.WriteLine($"No. of Employee : {emp.No_of_Emp}");
            }

            var tsg = Employee.GetEmployees().GroupBy(e=>e.Department).Select(a=>new {Total_Salary= a.Sum(e=>e.Salary)}).Where(a=>a.Total_Salary>800000).OrderByDescending(a=>a.Total_Salary);
            foreach (var emp in tsg)
            {
                Console.WriteLine($"Total Salary  : {emp.Total_Salary}");
            }

            var ej = Employee.GetEmployees().Join(Incentive.GetIncentives(), emp=>emp.Employee_Id, inc => inc.Employee_Ref_Id,(emp,inc)=> new {First_Name= emp.First_Name, Incentive_Amount = inc.Incentive_Amount}).ToList();
            foreach (var emp in ej)
            {
                Console.WriteLine($"Name : {emp.First_Name}  Incentive Amount : {emp.Incentive_Amount}");
            }

            //var eij = from emp in Employee.GetEmployees() join inc in Incentive.GetIncentives() on emp.Employee_Id equals inc.Employee_Ref_Id into EmployeeIncentive from incentive in EmployeeIncentive.DefaultIfEmpty() select new {First_Name=emp.First_Name, Incentive_Amount = inc.Incentive_Amount };
            //foreach (var emp in eij)
            //{
            //    Console.WriteLine($"Name : {emp.First_Name}  Incentive Amount : {emp.Incentive_Amount}");
            //}

            
            var top = Employee.GetEmployees().OrderByDescending(e => e.Salary).Take(2).ToList();
            foreach (var emp in top)
            {
                Console.WriteLine($"Top 2 Salary : {emp.Salary} ");
            }

            var topn = Employee.GetEmployees().OrderByDescending(e => e.Salary).Take(5).ToList();
            foreach (var emp in topn)
            {
                Console.WriteLine($"Top 5 Salary : {emp.Salary} ");
            }

            var top2 = Employee.GetEmployees().OrderByDescending(e => e.Salary).Skip(1).First();
            Console.WriteLine($"2nd Highest Salary : {top2.Salary} ");
            
            var un = Employee.GetEmployees().Select(x => x.First_Name).Union(Employee.GetEmployees().Select(y => y.Last_Name)).ToList();
            foreach (var emp in un)
            {
                Console.WriteLine($"Name : {emp} ");
            }

            var ei = Employee.GetEmployees().Select(x => x.Employee_Id).Except(Incentive.GetIncentives().Select(y => y.Employee_Ref_Id)).ToList();
            foreach (var emp in ei)
            {
                Console.WriteLine($"Emp Id : {emp} ");
            }

            //var cases = Employee.GetEmployees().Select(e => new {First_Name = e.First_Name, First_Name = e.First_Name=="John"?e.Salary*.2:e.First_Name =="Roy"?e.Salary*.1:e.First_Name != null ? e.Salary*.15:"-"}).ToList();
            //foreach (var emp in cases)
            //{
            //    Console.WriteLine($"Emp Details : {emp} ");
            //}

            var cases2 = Employee.GetEmployees().Select(e => new {Department = e.Department=="Banking"?"Bank Dept":e.Department =="Insurance"?"Insurance Dept":e.Department=="Services"?"Services Dept":"-"});
            foreach (var emp in cases2)
            {
                Console.WriteLine($"Emp Details : {emp.Department} ");
            }



            Console.ReadKey();
        }
    }
}
