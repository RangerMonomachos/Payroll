using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HourlyEmployee> hourlyEmployees = new List<HourlyEmployee>();
            List<SalariedEmployee> salariedEmployees = new List<SalariedEmployee>();
            int choice;
            while(true)
            {
                Console.WriteLine("make a choice:");
                Console.WriteLine("1) Add a new Salaried Employee.");
                Console.WriteLine("2) Add a new Hourly Employee.");
                Console.WriteLine("3) print the weekly report. ");
                choice = MainController.checkInt(Console.ReadLine());
                if(choice == 1)
                {
                    salariedEmployees.Add(MainController.AddSalariedEmployee());
                }
                else if (choice == 2)
                {
                    hourlyEmployees.Add(MainController.AddHourlyEmployee());
                }
                else if (choice == 3)
                {
                    MainController.printreport(hourlyEmployees, salariedEmployees);
                    break;
                }
                else
                {
                    Console.WriteLine("Did not understand.");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Thank you. Come again");
            Console.ReadLine();
        }
    }
}
