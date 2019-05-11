using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IntDoubleString keshik = new IntDoubleString();

            int number1 = 12;

            keshik.Calculate(x: number1);
            Console.ReadLine();

            double number2 = 198.5;

            keshik.Calculate(y: number2);
            Console.ReadLine();

            string name = "Ben";

            keshik.Calculate(z: name);
            Console.ReadLine();
        }
    }
}
