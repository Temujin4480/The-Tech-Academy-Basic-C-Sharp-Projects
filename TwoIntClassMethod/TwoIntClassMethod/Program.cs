using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();//In the Main() method of the console app, instantiate the class.
            //Console.WriteLine(math);
            //Console.ReadLine();


            int x = 5;
            int y = 10;

            math.Calculate1(x, y);//Call the method in the class, passing in two numbers.
            Console.ReadLine();
            

            //math = Calculate1(First, Second);

        
        }
    }
}
