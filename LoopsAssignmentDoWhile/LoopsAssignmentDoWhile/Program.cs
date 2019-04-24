using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignmentDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Do a boolean comparison using a while statement:
            Console.WriteLine("Cribbage simulator - Choose the best 4 cards from the 6 cards dealt to you.");
            Console.ReadLine();
            Console.WriteLine("You were dealt the cards 4 of diamonds, 4 of hearts, 5 of diamonds, 6 of clubs, jack of diamonds and queen of diamonds. Choose from the following options:");
            Console.WriteLine("Option 1: 4 of diamonds, 5 of diamonds, jack of diamonds, and queen of diamonds.");
            Console.WriteLine("Option 2: 4 of diamonds, 4 of hearts, 5 of diamonds, and 6 of clubs.");
            Console.WriteLine("Option 3: 4 of diamonds, 5 of diamonds, 6 of clubs, and jack of diamonds.");
            Console.WriteLine("Please choose from hands 1, 2 or 3 which one you think is worth the most points.");
            int choice = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = choice == 2;

            while (!isGuessed)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You chose 1.   Incorrect, this is worth 8 points, but another hand is worth more. Try again.");
                        Console.WriteLine("Choose hand 1, 2 or 3:");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You chose 3.   Incorrect, this is worth 7 points, but other hands are worth more. Try again.");
                        Console.WriteLine("Choose hand 1, 2 or 3:");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You chose 2.   This is correct. This hand is worth 12 points, while hand 1 is worth 8 points and hand 3 is worth 7 points. Good job.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Please only choose from numbers 1, 2 or 3.  Try again.");
                        Console.WriteLine("Choose hand 1, 2 or 3:");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();


            //ignore below, this was my original idea for a program, but I couldn't get it to work with the range of guesses.  I didn't want to delete though.
            //Console.WriteLine("The Burj Khalifa is the tallest building in the world.  Guess how tall it is in feet!");
            //int tall = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = tall == 2722;

            //while (!isGuessed)
            //{
            //    if (tall < 2000)
            //    { Console.WriteLine("You're way off!  Think bigger!");
            //      Console.WriteLine("Guess the height:");
            //      tall = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (tall >= 2000 && tall < 2500)
            //    { Console.WriteLine("It's a few hundred feet taller than that.  Guess again!");
            //      Console.WriteLine("Guess the height:");
            //      tall = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (tall >= 2500 && tall < 2700)
            //    { Console.WriteLine("You're not too far off now!  But it's still taller than that.  Try again!");
            //      Console.WriteLine("Guess the height:");
            //      tall = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (tall >= 2700 && tall <= 2721)
            //    { Console.WriteLine("You're so close!  Just a few feet bigger than that!");
            //      Console.WriteLine("Guess the height:");
            //      tall = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (tall == 2722)
            //    { Console.WriteLine("You got it!  Amazing guess!");
            //      isGuessed = true;
            //    }
            //    else if (tall >= 2723 && tall < 2800)
            //    { Console.WriteLine("You're so close!  You're within 100 feet, but that's a little too high still.  Guess lower.");
            //      Console.WriteLine("Guess the height:");
            //      tall = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (tall >= 2800 && tall < 3000)
            //    { Console.WriteLine("You're not too far off!  You're within 300 feet, but you guessed too high.");
            //      Console.WriteLine("Guess the height:");
            //      tall = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (tall >= 3000 && tall < 3200)
            //    { Console.WriteLine("Too high!  Try a bit lower than that.");
            //      Console.WriteLine("Guess the height:");
            //      tall = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (tall >= 3200)
            //    { Console.WriteLine("You're way off!  Think shorter!"); 
            //    Console.WriteLine("Guess the height:");
            //    tall = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.ReadLine();
        }
    }
}
