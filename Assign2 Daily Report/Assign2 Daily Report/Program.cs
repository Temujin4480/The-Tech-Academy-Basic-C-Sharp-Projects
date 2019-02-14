using System;

namespace Assignment2_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine(); //is there a way to do this without converting a string to an integer? 
            int pageNum = Convert.ToInt16(pageNumber); // ushort might be better data type here bc page number won't go over 65,000.  However, don't know how to convert string to ushort and a Google search makes it seem like using ushort would really complicate the code

            Console.WriteLine("Were there any positive experiences you'd like to share?  Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            int hoStudy = Convert.ToInt16(hoursStudy);

            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();

        }
    }
}
