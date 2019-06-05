using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment: 
            //1.Prints the current date and time to the console.
            //2.Asks the user for a number.
            //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

            //DateTime currentTime = new DateTime();
            Console.WriteLine("Current date and time are: " + DateTime.Now);
            Console.ReadLine();
            Console.WriteLine("Enter a number:");
            double hour = Convert.ToDouble(Console.ReadLine());
            //TimeSpan timeInXHours = hour + DateTime.Now; //TimeSpan not needed, can use DateTime.AddHours  
            Console.WriteLine("The time in " + hour + " hours will be " + DateTime.Now.AddHours(hour));
            Console.ReadLine();

        }
    }
}
