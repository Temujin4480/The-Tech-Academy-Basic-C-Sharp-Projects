using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAssignment
{
    public class Math
    {
        public void CalculateMethod1(int x)
        {
            int Triple = x * 3;

            Console.WriteLine("That integer multiplied by 3 is " + Triple + ".");
            Console.ReadLine();
        }

        public void CalculateMethod2(int x)
        {
            int Quarter = x / 4;

            Console.WriteLine("That integer divided by 4 is " + Quarter + ".");
            Console.ReadLine();
        }

        public void CalculateMethod3(int x)
        {
            int Sixth = x / 6;

            Console.WriteLine("That integer divided by 6 is " + Sixth + ".");
            Console.ReadLine();
        }
    }

    

}
