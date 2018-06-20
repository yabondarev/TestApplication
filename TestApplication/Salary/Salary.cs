using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApplication
{
    class Salary
    {
        private int NumberYears(DateTime startdate, DateTime completiondate)
        {
            DateTime start = new DateTime(startdate.Year, startdate.Month, startdate.Day);
            DateTime completion = new DateTime(completiondate.Year, completiondate.Month, completiondate.Day);
            double days = (completion - start).TotalDays;
            int months = 0;
            while (true)
            {
                int daysinmonth = DateTime.DaysInMonth(start.Year, start.Month);
                if (days >= daysinmonth)
                {
                    days -= daysinmonth;
                    months++;
                    start = start.AddMonths(1);
                }
                else
                    break;
            }
            int years = months / 12;
            return years;
        }
        private Dictionary<int, double> CalculateSalary(int id, DateTime completiondate, Dictionary<int, double> allsalarys)
        {
            double salary = 0;
            ETree employee = new ETree
            {
                Line = ERepository.table[id - 1]
            };
            foreach (ETree child in employee)
            {
                CalculateSalary(child.GetHashCode(), completiondate, allsalarys);
            }
            employee.Line = ERepository.table[id - 1];
            int years = NumberYears(employee.Date(), completiondate);
            switch (employee.Post())
            {
                case "Employee":
                    if (years <= 10)
                        salary = employee.Salary() * (1 + 0.03 * years);
                    else
                        salary = employee.Salary() * 1.3;
                    break;
                case "Manager":
                    if (years <= 8)
                        salary = employee.Salary() * (1 + 0.05 * years);
                    else
                        salary = employee.Salary() * 1.4;
                    foreach (int a_employee in allsalarys.Keys)
                    {
                        ETree descendant = new ETree { Line = ERepository.table[a_employee - 1] };
                        if (employee.Contains(descendant))
                        {
                            salary += allsalarys[a_employee] * 0.005;
                        }
                    }
                    break;
                case "Salesman":
                    if (years <= 35)
                        salary = employee.Salary() * (1 + 0.01 * years);
                    else
                        salary = employee.Salary() * 1.35;
                    foreach (int a_employee in allsalarys.Keys)
                    {
                        ETree descendant = new ETree { Line = ERepository.table[a_employee - 1] };
                        if (ETree.IsDescendant(employee, descendant))
                        {
                            salary += allsalarys[a_employee] * 0.003;
                        }
                    }
                    break;
            }
            allsalarys.Add(employee.GetHashCode(), salary);
            return allsalarys;
        }
        public double CalculateSalaryEmployee(int id, DateTime completiondate)
        {
            Dictionary<int, double> dictionary = new Dictionary<int, double>();
            Dictionary<int, double> allsalarys = CalculateSalary(id, completiondate, dictionary);
            return allsalarys[id];
        }
        public double TotalCalculateSalary(DateTime completiondate)
        {
            ETree employee = new ETree();
            Dictionary<int, double> allsalarys = new Dictionary<int, double>();
            foreach (ETree child in employee)
            {
                if (!allsalarys.ContainsKey(child.GetHashCode()))
                {
                    Dictionary<int, double> dictionary = new Dictionary<int, double>();
                    Dictionary<int, double> salarys = CalculateSalary(child.GetHashCode(), completiondate, dictionary);
                    allsalarys = allsalarys.Union(salarys).ToDictionary(x => x.Key, x => x.Value);
                }
            }
            double totalsalary = 0;
            foreach (int a in allsalarys.Keys)
            {
                totalsalary += allsalarys[a];
            }
            return totalsalary;
        }
    }
}
