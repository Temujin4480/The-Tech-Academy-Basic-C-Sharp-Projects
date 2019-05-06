using System;
using System.Collections.Generic;
using System.Linq;


namespace ArrayAndListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array,
            //adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line:

            string[] studentNames = { "Mike Smith", "Beth Johnson", "Ted Bundy" };
            Console.WriteLine("Please write the full name (first and last) of the student who will be enrolling at the Tech Academy:");
            string studentName = Console.ReadLine();

            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine(studentNames[i] + ", " + studentName);
            }
            Console.ReadLine();

            Console.WriteLine("The students currently enrolled are: ");
            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //2.Create an infinite loop.

            int age = 27;
            //I had to comment out the infinite loop so I could progress
            //for (int i = 0; i != age; i += 5)
            //{
            //    Console.WriteLine("Oh no, it's an infinite loop!!!!");
            //}


            //3. Fix the infinite loop so it will execute.

            for (int i = 0; i != age; i += 27)
            {
                Console.WriteLine("That should take care of that.");
            }
            Console.ReadLine();

            //4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            for (int i = 0; i < age; i++)
            {
                Console.WriteLine(i + " is too young to join the 27 club.");
            }
            Console.ReadLine();

            //5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            Console.WriteLine("Hit enter if you want to be transported away");
            Console.ReadLine();
            for (int i = 9; i <= age; i += 9)
            {
                Console.WriteLine("There's no place like home");
            }
            Console.ReadLine();

            //6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 
            //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //8. Add code to that above loop that stops it from executing once a match has been found.

            List<string> favoriteCharacters = new List<string>() { "Jon", "Daenerys", "Tyrion", "Arya", "Ramsay", "Cersei", "Sansa", "Jaime", "Joffrey" };
            Console.WriteLine("Write the first name of your favorite character from Game of Thrones.");
            string favoriteCharacter = Console.ReadLine();

            bool Character = true;
            while (Character)
            {
                for (int i = 0; i < favoriteCharacters.Count; i++)
                {
                    if (favoriteCharacters[i] == favoriteCharacter)
                    {
                        Console.WriteLine(favoriteCharacter + " is at index " + i);
                        Character = false;
                    }
                }
                if (Character)
                {
                    Console.WriteLine("We have no match for that character.  Sorry.  Please try again.");
                    favoriteCharacter = Console.ReadLine();
                }
            }

            Console.ReadLine();

            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text 
            //to search for in the List. Create a loop that iterates through the list and then displays the indices of the array 
            //that contain matching text on the screen.

            List<string> peopleNames = new List<string>() { "Bill", "Jimmy", "Danielle", "Bill" };
            Console.WriteLine("Enter a letter to search if that letter is in the name of any of the people in the List of people's names:");
            string peopleName = Console.ReadLine();
            //int index2 = peopleNames.FindIndex(a => a.Contains(peopleName)); //Ignore this, another way I found to search for Indices
            //foreach (var Name in peopleNames.Contains(r => r.IndexOf(peopleName) == 0))
            //    Console.WriteLine(Name);

            bool Name = true;
            while (Name)
            {
                for (int j = 0; j < peopleNames.Count; j++)
                {
                    if (peopleNames[j].Contains(peopleName))
                    {
                        Console.WriteLine("Index " + j + " has a name containing " + peopleName + ". That name is " + peopleNames[j] + ".");
                        Name = false;
                    }
                }
                //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
                if (Name)
                {
                    Console.WriteLine("Sorry, there is no name on this list containing the letter " + peopleName + ". Please try another letter.");
                    peopleName = Console.ReadLine();
                }
            }
            Console.ReadLine();


            //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates 
            //each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> fruits = new List<string>() { "Coconut", "Apple", "Dragon fruit", "Coconut" };
            List<string> duplicateFruits = new List<string>();
            
 
            foreach (string fruit in fruits)
            {
                if (!duplicateFruits.Contains(fruit))
                {
                    duplicateFruits.Add(fruit);
                    Console.WriteLine(fruit + " has not appeared in the list.");
                }
                else
                {
                    Console.WriteLine(fruit + " has appeared in the list.");
                }
            }
            Console.ReadLine();
        }
    }
}

