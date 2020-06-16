using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public abstract class Employee //a base class for both HourlyEmployee as well as SalariedEmployee
    {
        private string First;
        private string Last;
        private int Age;
        private int Id;
        public Employee(string first, string last, int age, int ID)
        {
            First = first;
            Last = last;
            Age = age;
            Id = ID;
        }
        public string Getname()
        {
            return Last + ", " + First;
        }
        public int GetAge()
        {
            return Age;
        }
        public int GetEmployeeID()
        {
            return Id;
        }
        public abstract string CalculatePay();
    }
}
