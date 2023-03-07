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
            Employee emply1= new Employee("Kimmo", "Makela", 100000012,3000);


            Console.WriteLine("Employee name is : " + emply1.GetName());
            Console.WriteLine("Employee surname is : " + emply1.GetSurname());
            Console.WriteLine("Employee ID is : " + emply1.GetID());
            Console.WriteLine("Employee monthly Salary is : " + emply1.GetMonthlySalary());
            Console.WriteLine("Employee yearly salary is : " + emply1.YearlySalary());
            emply1.SetMonthlySalary(3000.0);
            Console.WriteLine("New monthly salary is : ", emply1.GetMonthlySalary());

            Console.ReadLine();
        }
    }
}
