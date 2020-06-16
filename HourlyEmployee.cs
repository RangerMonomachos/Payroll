using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class HourlyEmployee : Employee //set up from the abstract class Employee to serve as the Hourly employee objects
    {
        string Fname;
        string Lname;
        int ageOfEmployee;
        int ID;
        int Hours;
        double PayRate;
        double total;
        double totalFIT;
        double totalFICA;
        public HourlyEmployee(string first, string last, int age, int Id, int hours, double rate)
        {
            Fname = first;
            Lname = last;
            ageOfEmployee = age;
            ID = Id;
            Hours = hours;
            PayRate = rate;
        }
        public override string name
        {
            get
            {
                return Lname + ", " + Fname;
            }
        }
        public override int Age
        {
            get
            {
                return ageOfEmployee;
            }
        }
        public override int EmployeeID
        {
            get
            {
                return ID;
            }
        }
        public override string CalculatePay()
        {
            double weeklyPay = Hours * PayRate;
            weeklyPay = Math.Round(weeklyPay, 2);
            double FICA = weeklyPay * .0765;
            FICA = Math.Round(FICA, 2);
            double FIT = weeklyPay * .265;
            FIT = Math.Round(FIT, 2);
            double Total = weeklyPay - (FICA + FIT);
            total = Total;
            totalFICA = FICA;
            totalFIT = FIT;
            return name + "     gross= " + weeklyPay + "     Fica= " + FICA + "     Federal Income Tax= " + FIT + "     Total= " + Total;
        }
        public double GetTotal()
        {
            return total;
        }
        public double GetFICA()
        {
            return totalFICA;
        }
        public double getFIT()
        {
            return totalFIT;
        }
    }
}
