using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment step 140: 
            //1.In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, 
            //as well as an Id. At least two employees should have the first name "Joe".
            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".
            //3.Do the same thing again, but this time with a lambda expression.
            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { FirstName = "Joe", LastName = "Louis", ID = 68 });
            employees.Add(new Employee { FirstName = "Joe", LastName = "Frazier", ID = 32 });
            employees.Add(new Employee { FirstName = "Jake", LastName = "LaMotta", ID = 83 });
            employees.Add(new Employee { FirstName = "George", LastName = "Foreman", ID = 76 });
            employees.Add(new Employee { FirstName = "Rocky", LastName = "Marciano", ID = 49 });
            employees.Add(new Employee { FirstName = "Ray", LastName = "Leonard", ID = 36 });
            employees.Add(new Employee { FirstName = "Jack", LastName = "Dempsey", ID = 61 });
            employees.Add(new Employee { FirstName = "Ray", LastName = "Robinson", ID = 175 });
            employees.Add(new Employee { FirstName = "Cassius", LastName = "Clay", ID = 56 });
            employees.Add(new Employee { FirstName = "Roy", LastName = "Jones", ID = 66 });

            //List<Employee> Joes = new List<Employee>();
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        Joes.Add(employee);
            //    }
            //}
            //foreach (Employee joe in Joes)
            //{
            //    Console.WriteLine(joe.FirstName + " " + joe.LastName + " " + joe.ID);
            //}

            //Console.ReadLine();

            //Part 1 + 2 above, Part 3 below: 
            List<Employee> Joes = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee joe in Joes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName + " " + joe.ID);
            }
            Console.ReadLine();

            //Part 4: 
            List<Employee> BigIDs = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee BigID in BigIDs)
            {
                Console.WriteLine("The employees with an ID greater than 5 are: " + BigID.FirstName + " " + BigID.LastName + " " + BigID.ID);
            }
            Console.ReadLine();
        }
    }
}
