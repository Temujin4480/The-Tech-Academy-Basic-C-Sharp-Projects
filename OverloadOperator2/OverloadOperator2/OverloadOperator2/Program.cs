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
            Employee emp1 = new Employee();// "Andy Renton", 007);
            emp1.Name = "Andy Renton"; //Alter the names and IDs to see if the code below actually works. 
            emp1.EmployeeID = 006;
            Employee emp2 = new Employee();// "James Bond", 007);
            emp2.Name = "James Bond";
            emp2.EmployeeID = 007;

            if (emp1.Name == emp2.Name) //Not sure if this is actually using the overloaded operator, or if this would just work without having overloaded it
                Console.WriteLine("Two employees with the same name!  Don't see that everyday!  Let's make sure they don't have the same ID number, that would be really confusing!");
            else
                Console.WriteLine("Each name is unique.");
            Console.ReadLine();

            if (emp1.EmployeeID == emp2.EmployeeID)
               Console.WriteLine("These two employees have the same ID, therefore one of the IDs needs to be altered.");
            else
                Console.WriteLine("These two employees each have a unique ID.  No adjustments needed.");
            Console.ReadLine();

            

        }
    }
}
