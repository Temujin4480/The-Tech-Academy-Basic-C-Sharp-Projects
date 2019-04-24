using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings:
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("Where are you from?");
            string from = Console.ReadLine();

            Console.WriteLine("Hello " + age + " year old " + name + " from " + from + ".");
            Console.ReadLine();

            //Convert a string to uppercase
            Console.WriteLine("What is your favorite football team?");
            string team = Console.ReadLine();
            team = team.ToUpper();
            Console.WriteLine("You like the " + team + "??!!");
            Console.ReadLine();

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder Address = new StringBuilder();
            Address.AppendLine("Just for that, you now have to listen to me recite the Gettysburg Address");
            Address.AppendLine();
            Address.Append("Four score and seven years ago,").AppendLine();
            Address.AppendLine();
            Address.Append("our fathers brought forth on this continent,").AppendLine();
            Address.AppendLine();
            Address.Append("a new nation, conceived in liberty, and dedicated to the proposition that all men are created equal.").AppendLine();
            Console.WriteLine(Address);
            Console.ReadLine();
        }
    }
}
