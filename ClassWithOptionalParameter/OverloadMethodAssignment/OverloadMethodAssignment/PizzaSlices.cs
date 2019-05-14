using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodAssignment
{
    public class PizzaSlices
    {
        public void CanEat(int x = 12)
        {
            int slices = x / 2;
            Console.WriteLine("If your pizza has " + x + " slices, you both can eat " + slices + " slices.");
            Console.ReadLine();
        }

        public void CalculateSquare(int length, out int width)//assuming the pizza is square
        //The Out parameter is used when a method returns multiple values, therefore I have area and circumference
        {
            width = 10;//I believe you have to give the out parameter a value
            int area = length * width;
            int circumference = length * 2 + width * 2;
            Console.WriteLine("The area of your pizza is " + area + " square inches and the circumference is " + circumference + " inches.");
            Console.ReadLine();
        }

        public void CalculateSquare(double length, double width)
        {
            double area = length * width;
            double circumference = length * 2 + width * 2;
            Console.WriteLine("The area of your pizza is " + area + " square inches and the circumference is " + circumference + " inches.");
            Console.ReadLine();
        } 
    }


    public static class PizzaType
    {
        public static void BestTopping()
        {
            Console.WriteLine("Pepperoni is the best topping.");
        }
    }
}
