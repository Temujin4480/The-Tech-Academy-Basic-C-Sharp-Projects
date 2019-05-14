using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithOptionalParameter
{
    public class Age
    {

        public int Calculate(int x, int y = 0)
        {
            int ageCombined = x + y;

            Console.WriteLine("Your age and your first child's age is " + ageCombined + ".");
            //Console.WriteLine("Your age and your first child's age is {0}", ageCombined + "."); //another way to write the same thing
            Console.ReadLine();//These lines have to be put above the return
            return ageCombined;
        }
    }

    
}
