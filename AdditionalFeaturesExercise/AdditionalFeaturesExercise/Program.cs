using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE:
            //1.Create a const variable
            //2.Create a variable using the keyword "var".
            //3.Chain two constructors together.

            
            const double X = 2.2;  //1.Create a const variable
            Console.WriteLine("What is your first name?");
            string fName = Console.ReadLine();
            Console.WriteLine("What is your weight in pounds?");
            double weightLB = Convert.ToDouble(Console.ReadLine());
            var weightKG = weightLB / X; //2.Create a variable using the keyword "var"
            Console.WriteLine("Hello {0}, your weight in kilograms is {1}", fName, weightKG);
            Console.ReadLine();

            Person person1 = new Person("Mufasa"); //This should create a Person with first Name Mufasa and their weight should be 100 kg automatically
            //Unfortunately I'm only getting a null value.  
            //Nevermind previous comment.  After adding Name and WeightKG with { get; set; } in class Person, when I put a break at the following 
            //ReadLine it has Mufasa as person1 with a weight of 100kg.  
            Console.ReadLine();
        }
    }
}
