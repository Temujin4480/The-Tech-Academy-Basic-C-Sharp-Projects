using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment:
            //1.Make the Employee class take a generic type parameter.
            //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
            //3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
            //4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
            //5. Create a loop that prints all of the Things to the Console.

            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.Things.Add("Bill Brasky");
            employee.Things.Add("Michelle Geslani");
            employee.Things.Add("Thao Nguyen");

            Employee<int> employeeID = new Employee<int>();
            employeeID.Things = new List<int>();
            employeeID.Things.Add(001);
            employeeID.Things.Add(002);
            employeeID.Things.Add(003);

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            foreach (int thing in employeeID.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
