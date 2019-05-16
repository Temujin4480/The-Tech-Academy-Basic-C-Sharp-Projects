using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritExercise
{
    public class Person
    {
        //Add a list here and make the method SayName use a foreach loop? 
        //public List<string> FullNames { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        }
    }
}
