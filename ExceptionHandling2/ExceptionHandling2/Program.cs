using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise:
            //1.Ask the user for his age.
            //2.Display the year user born.
            //3.Exceptions must be handled using "try .. catch".
            //4.Display appropriate error messages if user enters zero or negative numbers.
            //5.Display a general message if exception caused by anything else.

            //Try this with bool value
            try
            {
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("How old are you?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("You have either entered your age in letters, used a decimal, or entered a number that is not realistic for your age.  Please try again with a number that is written in digits with no decimals.");
                    //Tested, this catches errors with writing in a string, using a decimal, or putting in a huge number bigger that int32 can handle.
                }
                if (age <= 0)
                {
                    throw new LessThanZeroException();
                }
                const int currentYear = 2019;
                int birthYear = currentYear - age;
                Console.WriteLine("You were born in {0}.", birthYear);
                Console.ReadLine();
            }
            catch (LessThanZeroException) //This will throw a message if user inputs zero or negative number. 
            {
                Console.WriteLine("You have entered a zero or a negative number.  Please try again with a positive integer.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("You've done something wrong.  I don't know what, but try again without doing what you just did.");
                Console.ReadLine();
            }
         



            //Try this with no while
            //try
            //{
            //    Console.WriteLine("How old are you?");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    if (age <= 0) throw new ArgumentOutOfRangeException("Number must be positive and non zero.  Please try again.");
            //    const int currentYear = 2019;
            //    int birthYear = currentYear - age;
            //    Console.WriteLine("You were born in {0}.", birthYear);
            //    Console.ReadLine();
            //}
            //catch (FormatException)//This should catch any decimals, non number characters, or if they type nothing:
            //{
            //    Console.WriteLine("Please enter only numbers, and only whole numbers.  No characters or decimals.  Try again.");
            //    Console.ReadLine();
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    Person person1 = new Person()
            //    if (age <= 0) Console.WriteLine("Number must be positive and non zero.  Please try again.");
            //}




            //    bool validAnswer = false;
            //    int age = 0;
            //    while (!validAnswer)
            //    {
            //        try
            //        {

            //            Console.WriteLine("How old are you?");
            //            validAnswer = int.TryParse(Console.ReadLine(), out age);
            //            if (!validAnswer) Console.WriteLine("Please enter a whole number only.  Don't add decimals or any other characters.  Try again.");
            //        }
            //        catch (ArgumentOutOfRangeException ex) //Believe I'll have to make a new class to reference here that has an exception for values 0 or less. Can't find a built in
            //        //exception for this condition
            //        {
            //            Person person1 = new Person(age); //I since deleted this class.  It wasn't working. 
            //            if (age < 0) Console.WriteLine(ex.Message);
            //            Console.ReadLine();
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Something went wrong.  Try again, but don't do whatever you just did.");
            //            Console.ReadLine();
            //        }

            //    }


            //    //int age = Convert.ToInt32(Console.ReadLine());
            //    const int currentYear = 2019;
            //    int birthYear = currentYear - age; //I realize this might not be correct depending on birth month, but figured the purpose of this 
            //    //exercise was to practice try catch loops and I didn't want to complicate it by using the DateTime data type. 
            //    Console.WriteLine("You were born in {0}.", birthYear);
            //    Console.ReadLine();
        }
    }
}

