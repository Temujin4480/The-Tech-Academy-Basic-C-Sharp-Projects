using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        string[] stringArray = { "Pineapple", "Apple", "Coconut", "Watermelon" };
        Console.WriteLine("Please write 0, 1, 2 or 3 to find out what fruit is listed at that index.");
        int indArray = Convert.ToInt32(Console.ReadLine());
        if (indArray == 0 || indArray == 1 || indArray == 2 || indArray == 3)
        { Console.WriteLine(stringArray[indArray]); }
        else 
        { Console.WriteLine("This index does not exist."); }
        Console.ReadLine();

        int[] intArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Please write 0, 1, 2, 3 or 4 to find out what integer is at that index.");
        int indArray2 = Convert.ToInt32(Console.ReadLine());
        if (indArray2 == 0 || indArray2 == 1 || indArray2 == 2 || indArray2 == 3 || indArray2 == 4)
        { Console.WriteLine(intArray[indArray2]); }
        else
        { Console.WriteLine("This index does not exist."); }
        Console.ReadLine();

        List<string> stringList = new List<string>();
        stringList.Add("chicken wings");
        stringList.Add("t-bone steak");
        stringList.Add("reuben");
        Console.WriteLine("Please write 0, 1 or 2 to find out what food is at that index of the list.");
        int food = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringList[food]);
        Console.ReadLine();
        }
    }

