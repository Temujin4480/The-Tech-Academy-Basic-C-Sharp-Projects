using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();// "Andy Renton", 001);
            emp1.Name = "Andy Renton"; //Alter the names and IDs to see if the code below actually works. 
            emp1.EmployeeID = 001;
            Employee emp2 = new Employee();// "James Bond", 007);
            emp2.Name = "James Bond";
            emp2.EmployeeID = 007;


            Console.WriteLine(emp1.EmployeeID == emp2.EmployeeID);
            Console.ReadLine();
            //False means not equal, true means equal

            //The following code works as well in place of the ConsoleWriteLine above
            //if (emp1.EmployeeID == emp2.EmployeeID)
            //    Console.WriteLine("These two employees have the same ID, therefore one of the IDs needs to be altered.");
            //else
            //    Console.WriteLine("These two employees each have a unique ID.  No adjustments needed.");
            //    Console.ReadLine();
        }
    }
}
