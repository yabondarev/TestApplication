using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApplication
{
    static class ERepository
    {
        static Employees employees = new Employees(SignIn.dbname);
        public static List<ListWithName> table = employees.GenEntries("*");
        static public void Reset()
        {
            employees = new Employees(SignIn.dbname);
            table = employees.GenEntries("*");
        }
        public static void AddEntry(string Name, DateTime Date, string Post, int Salary)
        {
            employees.AddEntry(Name, Date, Post, Salary);
        }
        public static void AddEntry(string Name, DateTime Date, string Post, int Salary, int pid)
        {
            employees.AddEntry(Name, Date, Post, Salary, pid);
        }
    }
}
