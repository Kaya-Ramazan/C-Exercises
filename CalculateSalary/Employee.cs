using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSalary
{
    internal class Employee
    {
        private string Name;
        private string Surname;
        private int ID;
        
        private double MonthlySalary;

        private double YearlySalary()
        {
            return MonthlySalary * 12 ; 
        
        }
        public Employee (string emplyname, string emplySurname, int EmplyID, double EmplymonthlySalary) 
        {
            Name = emplyname;
            Surname = emplySurname;
            ID = EmplyID;
            MonthlySalary = EmplymonthlySalary;
            


        }

      

        public string GetName() 
        {
            return Name; 
        }
        public void SetName(string emplyname) 
        {
            Name = emplyname;
        }
        public string GetSurname() 
        {
            return Surname; 
        }
        public void SetSurname(string emplySurname) 
        {
            Surname = emplySurname;
        }
        public int GetID() 
        {
            return ID;
        }
        public void SetID(int EmplyID) 
        {
            ID = EmplyID;
        }
        public double GetMonthlySalary()
        {
            return MonthlySalary; 
        }
        public void SetMonthlySalary(double EmplymonthlySalary) 
        {
            MonthlySalary = EmplymonthlySalary;
        }
        public double GetYearlySalary()
        {
            return MonthlySalary * 12;
        }
        public void SetYearlySalary(double EmplyYearlySalry)
        {
            
        }





    }
}
