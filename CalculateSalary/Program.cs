using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We create C# console application. After that created a class named
            //"Employee" with properties such as name, employee ID, and salary.
            //in this  methods we calculate the yearly salary of an employee based on their monthly salary.

            Employee emply1 = new Employee("Kimmo", "Makela", 100000012,3000);


            Console.WriteLine("Employee name is : " + emply1.GetName());
            Console.WriteLine("Employee surname is : " + emply1.GetSurname());
            Console.WriteLine("Employee ID is : " + emply1.GetID());
            Console.WriteLine("Employee monthly Salary is : " + emply1.GetMonthlySalary());
            Console.WriteLine("Employee yearly salary is : " + emply1.GetYearlySalary());
            emply1.SetMonthlySalary(3000.0);
            
            Console.ReadLine();
        }
    }
}
