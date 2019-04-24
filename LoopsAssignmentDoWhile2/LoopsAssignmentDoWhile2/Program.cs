using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignmentDoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trivia night.  What was Matt Damon's first movie?");
            Console.WriteLine("1. Thelma and Louise 2. Good Will Hunting 3. Mystic Pizza 4. The Bourne Identity");
            Console.WriteLine("Choose 1, 2, 3 or 4");
            int choice = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = choice == 3;

            do 
            {
                switch (choice) 
                {
                    case 1: 
                        Console.WriteLine("You guessed Thelma and Louise released in 1991. However, Matt Damon was not in that movie so you are incorrect.");
                        Console.WriteLine("Guess again, 1, 2, 3 or 4.");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break; 
                    case 2:
                        Console.WriteLine("You guessed Good Will Hunting released in 1997.  While this was one of his first starring roles it was not his first movie so you are incorrect.");
                        Console.WriteLine("Guess again, 1, 2, 3 or 4.");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed Mystic Pizza released in 1988. Congratulations, you are correct.  This was Matt Damon's first movie at age 18.");
                        isGuessed = true;
                        break;
                    case 4:
                        Console.WriteLine("You guessed The Bourne Identity released in 2002. You fool, you do not know Matt Damon's movie catalogue very well, and really shouldn't feel bad about that.");
                        Console.WriteLine("Guess again, 1, 2, 3 or 4.");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    default: 
                        Console.WriteLine("You've done something wrong.  Please type only 1, 2, 3 or 4.");
                        Console.WriteLine("Guess again, 1, 2, 3 or 4.");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);  
            Console.ReadLine();
        }
    }
}
