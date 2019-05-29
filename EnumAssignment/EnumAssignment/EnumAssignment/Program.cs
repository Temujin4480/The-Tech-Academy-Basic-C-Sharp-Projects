using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment step 134: 
            //1.Create an enum for the days of the week.
            //2. Prompt the user to enter the current day of the week.
            //3. Assign the value to a variable of that enum data type you just created.
            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            //Note - In the last video, we explained the underlying concepts behinds enums.Nobody knows everything about a programming language and its 
            //features, so it's our job as programmers to do research on how to work with various data types, classes and libraries. For this drill, 
            //you'll need to do some additional research on how to parse enums.

            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string today = Console.ReadLine(); //Assign user input to variable

                //Add a while loop to get the try catch to work more than once, will probably have to add a boolean variable
               
                //int dayInt = Int32.Parse(today); //Convert user string input into an integer. Unfortunately, it is now throwing an exception if input is not in form of int
                //I thought I could use the inherint int values to check if the enum contained the user input.  

                //DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), today);
                //convert string today to enum day?? 

                //Trying to find what data type day is now...It's a variable of enum DaysOfTheWeek
                //Type dayType = day.GetType();
                //Console.WriteLine(dayType);
                //Console.ReadLine();

                if (today.GetType() == typeof(int))
                {
                    Console.WriteLine("Please enter the day in letters, not numbers");
                } 
                else
                {
                    Console.WriteLine(today.GetType());
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), today);
                    for (int i = 0; i < 7; i++)
                    {
                        if (day == (DaysOfTheWeek)i)
                        {
                            Console.WriteLine("Yes, today is " + today + ".");
                        }
                    }
                }

                //if (Enum.IsDefined(typeof(DaysOfTheWeek), day)) //Trying to write an if statement along the lines of if DaysOfTheWeek contains today then 
                //{
                //    Console.WriteLine("Yes, today is " + today + ".");
                //    Console.ReadLine();
                //}//This is working for strings, but for some reason it's not catching integers. 
            }
            //Even with the following FormatException, it's not catching user input not in the form of a string
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter the day of the week using letters.");
            //}

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine("Please enter an actual day of the week.");
            }
            finally //I believe this finally is unnecessary as there is no return in the code. 
            {
                Console.ReadLine();
            }

        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
