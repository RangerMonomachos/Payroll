using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class MainController // this class is to make the main class in programs only hold three things, the two lists and the input for what choice is selected
    {
        public static string checkString(string input)
        {
            //while (true)
            //{
            //    if (string.IsNullOrEmpty(input))
            //    {
            //        Console.WriteLine("Nothing detected. Try again");
            //        input = Console.ReadLine();
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            return input;
        }
        public static int checkInt (string input)
        {
            bool corectinput = false;
            int output = 0;
            while (corectinput == false)
            {
                corectinput = int.TryParse(input, out output);
                if (corectinput == false)
                {
                    //Console.WriteLine("incorect input. try again.");
                    //input = Console.ReadLine();
                    return -100;
                }
            }
            return output;
        }
        public static double checkDouble ( string input)
        {
            bool corectinput = false;
            double output = 0.0;
            while (corectinput == false)
            {
                corectinput = double.TryParse(input, out output);
                if (corectinput == false)
                {
                    //Console.WriteLine("incorect input. try again.");
                    //input = Console.ReadLine();
                    return -100.0;
                }

            }
            return output;
        }
        // seting up the three methods to add a new hourly or salaried employee as well as output the totals
        public static SalariedEmployee AddSalariedEmployee()
        {
            Console.WriteLine("First Name of employee: ");
            string FirstName = checkString(Console.ReadLine());
            Console.WriteLine("Last Name of employee: ");
            string LastName = checkString(Console.ReadLine());
            Console.WriteLine("Age of employee: ");
            int Age = checkInt(Console.ReadLine());
            Console.WriteLine("Employee ID number: ");
            int EmployeeNumber = checkInt(Console.ReadLine());
            Console.WriteLine("Mounthly salery: ");
            double Salery = checkDouble(Console.ReadLine());
            return new SalariedEmployee(FirstName, LastName, Age, EmployeeNumber, Salery);
        }
        public static HourlyEmployee AddHourlyEmployee()
        {
            Console.WriteLine("First Name of employee: ");
            string FirstName = checkString(Console.ReadLine());
            Console.WriteLine("Last Name of employee: ");
            string LastName = checkString(Console.ReadLine());
            Console.WriteLine("Age of employee: ");
            int Age = checkInt(Console.ReadLine());
            Console.WriteLine("Employee ID number: ");
            int EmployeeNumber = checkInt(Console.ReadLine());
            Console.WriteLine("Hourly rate: ");
            double Rate = checkDouble(Console.ReadLine());
            Console.WriteLine("Hours worked this week: ");
            int HoursWorked = checkInt(Console.ReadLine());
            return new HourlyEmployee(FirstName, LastName, Age, EmployeeNumber, HoursWorked, Rate);
        }
        public static void printreport(List<HourlyEmployee> hourlies, List<SalariedEmployee> salarieds)
        {
            double hourlyTotal = 0;
            double hourlyFICA = 0;
            double hourlyFIT = 0;
            double salaryTotal = 0;
            double salaryFICA = 0;
            double salaryFIT = 0;
            double totalTotal;
            double totalFICA;
            double totalFIT;

            foreach(HourlyEmployee h in hourlies)
            {
                Console.WriteLine(h.CalculatePay());
                hourlyTotal = hourlyTotal + h.GetTotal();
                hourlyFICA = hourlyFICA + h.GetFICA();
                hourlyFIT = hourlyFIT + h.getFIT();
            }
            Console.WriteLine("total payed to FICA: " + hourlyFICA.ToString() + "   total payed for Federal Income Tax: " + hourlyFIT.ToString() + "   Total payed out to employee's: " + hourlyTotal.ToString());
            totalTotal = hourlyTotal;
            Console.WriteLine();

            foreach(SalariedEmployee s in salarieds)
            {
                Console.WriteLine(s.CalculatePay());
                salaryTotal = salaryTotal + s.GetTotal();
                salaryFICA = salaryFICA + s.GetFICA();
                salaryFIT = salaryFIT + s.getFIT();
            }
            Console.WriteLine("total payed to FICA: " + salaryFICA.ToString() + "   total payed for Federal Income Tax: " + salaryFIT.ToString() + "   Total payed out to employee's: " + hourlyTotal.ToString());
            totalTotal = totalTotal + salaryTotal;
            totalFICA = hourlyFICA + salaryFICA;
            totalFIT = hourlyFIT + salaryFIT;
            Console.WriteLine();
            Console.WriteLine("total payed to FICA: " + totalFICA.ToString() + "   total payed to Federal Income Tax: " + totalFIT.ToString() + "   total payed to employee's: " + totalTotal.ToString());
        }
    }
}
