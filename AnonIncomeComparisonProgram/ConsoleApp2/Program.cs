using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string HourlyRate1 = Console.ReadLine();
            int HourRate1 = Convert.ToInt16(HourlyRate1);
            Console.WriteLine("Hours worked per week?");
            string HoursPerWeek1 = Console.ReadLine();
            int HoursWeek1 = Convert.ToInt16(HoursPerWeek1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string HourlyRate2 = Console.ReadLine();
            int HourRate2 = Convert.ToInt16(HourlyRate2);
            Console.WriteLine("Hours worked per week?");
            string HoursPerWeek2 = Console.ReadLine();
            int HoursWeek2 = Convert.ToInt16(HoursPerWeek2);

            Console.WriteLine("Weekly salary of Person 1:");
            int product1 = HourRate1* HoursWeek1;
            Console.WriteLine(product1);
            Console.WriteLine("Weekly salary of Person 2:");
            int product2 = HourRate2 * HoursWeek2;
            Console.WriteLine(product2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool Person1More = product1 > product2;
            Console.WriteLine(Person1More);
            Console.ReadLine();
        }
    }
}
