using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an interface called IQuittable and have it define a void method called Quit().

            //2. Have your Employee class from the previous drill inherit that interface and implement the Quit() 
            //method in any way you choose.

            //3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
            //Hint: an object can be of an interface type if it implements that specific interface.

            Employee employee = new Employee();
            IQuittable employees1 = new Employee(); //Employee morphs into the superclass/interface Quittable
            List<string> employees = new List<string>(); //if I write it this way I can add to it
            //List<IQuittable> employees = new List<IQuittable>();
            employees.Add("Odell Beckham");
            employees.Add("Jarvis Landry");
            employees.Add("Tariq Black");

            employee.Quit();
            Console.ReadLine();


            //Following method works with my original Quit method, but don't think it follows the criteria of part 3 of the assignment:
            //Employee employee = new Employee();
            //employee.employees = new List<string>() { "Odell Beckham", "Jarvis Landry", "Tariq Black" };

            //employee.Quit(employee);
            //Console.ReadLine();
        }
    }
}
