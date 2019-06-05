using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Added this for logging

namespace LoggingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment:
            //1.Ask a user for a number.
            //2.Log that number to a text file.
            //3.Print the text file back to the user.

            Console.WriteLine("Enter a number, any number:");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Ben\source\Logs\number.txt", number);
            string showLog = File.ReadAllText(@"C:\Users\Ben\source\Logs\number.txt");
            Console.WriteLine("The number you wrote was " + showLog);
            Console.ReadLine();
        }
    }
}
