using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanCarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string Age1 = Console.ReadLine();
            int Old1 = Convert.ToInt16(Age1);
            Console.WriteLine("Have you ever had a DUI? Please respond True if you have, False if you haven't.");
            string Dui1 = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string Ticket1 = Console.ReadLine();
            int Tckt1 = Convert.ToInt16(Ticket1);

            Console.WriteLine("Qualified?");
            bool Qualified = (Old1 > 15 && Dui1 == "False" && Tckt1 <= 3);
            Console.WriteLine(Qualified);
            Console.ReadLine();
        }
    }
}
