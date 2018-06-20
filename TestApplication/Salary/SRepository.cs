using System;

namespace TestApplication
{
    static class SRepository
    {
        static Salary salary = new Salary();
        public static double CalculateSalaryEmployee(int id, DateTime completiondate)
        {
            return salary.CalculateSalaryEmployee(id, completiondate);
        }
        public static double TotalCalculateSalary(DateTime completiondate)
        {
            return salary.TotalCalculateSalary(completiondate);
        }
    }
}
