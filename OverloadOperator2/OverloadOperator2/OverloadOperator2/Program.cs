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
            Employee emp1 = new Employee("Andy Renton", 007);
            //emp1.Name = "Andy Renton";
            //emp1.EmployeeID = 006;
            //Employee emp2 = new Employee("Edward Donne", 001); //Let's just keep it to two
            //emp2.Name = "Edward Donne";
            //emp2.EmployeeID = 001;
            Employee emp2 = new Employee("James Bond", 007);
            //emp3.Name = "James Bond";
            //emp3.EmployeeID = 007;


            if (emp1 == emp2)
                Console.WriteLine("These two employees have the same ID, therefore one of the IDs needs to be altered.");
            else
                Console.WriteLine("These two employees each have a unique ID.  No adjustments needed.");
            Console.ReadLine();

        }
    }
}
