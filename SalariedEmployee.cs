using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class SalariedEmployee: Employee //set up from the abstract class Employee to serve as the salaried employee objects
    {
        string Fname;
        string Lname;
        int ageOfEmployee;
        int ID;
        double Mounthpay;
        double total;
        double totalFICA;
        double totalFIT;
        public SalariedEmployee(string First, string Last, int age, int Id, double PayForMonth) : base(First, Last, age, Id)
        {
            Fname = First;
            Lname = Last;
            ageOfEmployee = age;
            ID = Id;
            Mounthpay = PayForMonth;
        }
        public override string CalculatePay()
        {
            double weeklyPay = Mounthpay / 4;
            weeklyPay = Math.Round(weeklyPay, 2);
            double FICA = weeklyPay * .0765;
            FICA = Math.Round(FICA, 2);
            double FIT = weeklyPay * .265;
            FIT = Math.Round(FIT, 2);
            double Total = weeklyPay - (FICA + FIT);
            total = Total;
            totalFICA = FICA;
            totalFIT = FIT;
            return Lname + ", " + Fname + "     gross= " + weeklyPay + "     Fica= " + FICA + "     Federal Income Tax= " + FIT + "     Total= " + Total;
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
