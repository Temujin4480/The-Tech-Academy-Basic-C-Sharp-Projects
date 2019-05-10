using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that takes each 
            //integer in the list, divides it by the number the user entered, and displays the result to the screen.

            //List<int> listInts = new List<int>() { 9, 54, 18, 7, 10 };
            //Console.WriteLine("I am thinking of five numbers.  Please enter a number to divide all five numbers I am thinking of by.");
            //int numberOne = Convert.ToInt32(Console.ReadLine());


            //foreach (int number in listInts)
            //{
            //    int numberTwo = number / numberOne;
            //    {
            //        Console.WriteLine(numberTwo);
            //    }
            //}
            //Console.ReadLine();

            //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results. No problems

            //3.Run that code, entering in zero as the number to divide by. Note any error messages you get.
            //I get a System.DivideByZeroException: 'Attempted to divide by zero.' error message

            //4.Run that code, entering in a string as the number to divide by. Note any error messages you get.
            //I get a System.FormatException: 'Input string was not in a correct format.' error message

            //5. Redoing the code in try/catch format. 
            try
            {
                List<int> listInts = new List<int>() { 9, 54, 18, 7, 10 };
                Console.WriteLine("I am thinking of five numbers.  Please enter a number to divide all five numbers I am thinking of by.");
                int numberOne = Convert.ToInt32(Console.ReadLine());


                foreach (int number in listInts)
                {
                    int numberTwo = number / numberOne;
                    {
                        Console.WriteLine(numberTwo);
                    }
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("The program has exited the try/catch loop.");
                Console.ReadLine();
            }


        }
    }
}
