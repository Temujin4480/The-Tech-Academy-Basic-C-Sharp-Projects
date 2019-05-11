using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassesAndMethods
{
    public class IntDoubleString
    {
        public void Calculate(int x)
        {
            int value1 = x * 50;
            Console.WriteLine(value1);
            Console.ReadLine();
        }

        public void Calculate(double y)
        {
            double value2 = y / 2.2;
            Console.WriteLine(value2);
            Console.ReadLine();
        }

        public void Calculate(string z)
        {
            int value3 = z.Length + 1;
            Console.WriteLine(value3);
            Console.ReadLine();
        }
    }
}
