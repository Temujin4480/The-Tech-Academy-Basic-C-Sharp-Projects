using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithOptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Age age = new Age();
            int result;


            Console.WriteLine("Enter your age:");
            int age1 = Convert.ToInt32(Console.ReadLine());
            //if (!int.TryParse(Console.ReadLine(), out age1))
            //    throw new ArgumentException("no valid number");
            Console.WriteLine("Enter the age of your first child.  If you don't have a child press enter:");
            string age2 = Console.ReadLine();
            int age3;

            if (string.IsNullOrEmpty(age2))
            {
                result = age.Calculate(age1);
            }

            else
            {
                age3 = Convert.ToInt32(age2);
                result = age.Calculate(age1, age3);
            }


            //age.Calculate(age1, age3);
            Console.ReadLine();

        }
    }
}
