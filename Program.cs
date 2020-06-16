using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Program
    {
        static void Main(string[] args)
        {


            mainMenu();
            Console.WriteLine("Thank you. Come again");
            Console.ReadLine();

        }
        public static void mainMenu()
        {
            List<HourlyEmployee> hourlyEmployees = new List<HourlyEmployee>();
            List<SalariedEmployee> salariedEmployees = new List<SalariedEmployee>();
            int choice;
            while (true)
            {
                Console.WriteLine(menu());
                choice = MainController.checkInt(Console.ReadLine());
                if (choice == 1)
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

         
        }
        public static string menu()
        {
            return "make a choice:\n1) Add a new Salaried Employee.\n2) Add a new Hourly Employee.\n3) print the weekly report. ";
        }
        
    }
}
