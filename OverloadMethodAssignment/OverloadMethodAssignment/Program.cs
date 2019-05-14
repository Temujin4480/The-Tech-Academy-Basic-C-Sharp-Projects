using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaSlices pizzaSlices = new PizzaSlices();

            int slices1 = 12;
            pizzaSlices.CanEat(slices1);
            Console.ReadLine();

            Console.WriteLine("How many pieces of pizza does your pizza have?");
            int slices2 = Convert.ToInt32(Console.ReadLine());

            pizzaSlices.CanEat(slices2);
            Console.ReadLine();

            int length = 12;
            int width;

            pizzaSlices.CalculateSquare(length, out width);
            Console.WriteLine(width);

            //To test if the overload is working: 
            Console.WriteLine("What is the width of your pizza in inches?  Please use a decimal:");
            double width1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the length of your pizza in inches? Please use a decimal:");
            double length1 = Convert.ToDouble(Console.ReadLine());

            pizzaSlices.CalculateSquare(length1, width1);

            //no need to instantiate the static class
            PizzaType.BestTopping();
            Console.ReadLine();
        }
    }
}
