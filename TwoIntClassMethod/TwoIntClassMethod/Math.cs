using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntClassMethod
{
    public class Math//Create a class
    {
        public void Calculate1(int x, int y)//create a void method that takes two integers as parameters. 
        {
            int value1 = x * 4;
            int value2 = y;
            Console.WriteLine("The first integer 5, multiplied by 4 is: " + value1 + ". There was also a " + value2 + ".");
            //Have the method do a math operation on the first integer and display the second integer to the screen.
            Console.ReadLine();
        }


      
      
    }
}
