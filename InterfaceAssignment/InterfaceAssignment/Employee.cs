using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    public class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        }

        public List<string> employees1 { get; set; }

        public void Quit() 
        {
            Console.WriteLine("Everyone is fired");

            //My original code below wasn't working, I believe because it was returning a valid and was not void.  
            //foreach (string employeee in employees1)
            //{
            //    if (employeee.Contains("q"))
            //    {
            //        Console.WriteLine(employeee + " Employment Status: No longer employed");
            //    }
            //    else
            //    {
            //        Console.WriteLine(employeee + " Employment Status: Currently employed");
            //    }
            //}
            //Console.ReadLine();
        }
    }
}
