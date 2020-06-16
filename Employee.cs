using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public abstract class Employee //a base class for both HourlyEmployee as well as SalariedEmployee
    {
        public abstract string name { get; }
        public abstract int Age { get; }
        public abstract int EmployeeID { get; }
        public abstract string CalculatePay();
    }
}
