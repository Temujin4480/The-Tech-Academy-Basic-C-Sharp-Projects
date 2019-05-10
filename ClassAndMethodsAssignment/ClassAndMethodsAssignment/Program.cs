using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please input an integer and hit enter.");
            int userInteger = Convert.ToInt32(Console.ReadLine());

            math.CalculateMethod1(userInteger);
            math.CalculateMethod2(userInteger);
            math.CalculateMethod3(userInteger);
        }
    }
}
