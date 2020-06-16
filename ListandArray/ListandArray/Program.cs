using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<string> sList = new List<string>();
        sList.Add("Hello");
        sList.Add("World");
        sList.Remove("It's me!");

        Console.WriteLine("Select an Index:");
        string selection = Console.ReadLine();
        int sSelect = Convert.ToInt32(selection);
        Console.WriteLine(sList[sSelect]);
        Console.ReadLine();


        string[] strArray = new string[] { "Hi", "there", "this", "that" };

        Console.WriteLine("Select an Index:");
        string sArray1 = Console.ReadLine();
        int sArray2 = Convert.ToInt32(sArray1);
       
        if (sArray2 > 3)
        {
            Console.WriteLine("This index does not exist");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(strArray[sArray2]);
            Console.ReadLine();
        }


        int[] numArray1 = new int[] { 5, 2, 10, 12 };

        Console.WriteLine("Select an Index:");
        string index1 = Console.ReadLine();
        int index2 = Convert.ToInt32(index1);

        if (index2 > 3)
        {
            Console.WriteLine("This index does not exist");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(numArray1[index2]);
            Console.ReadLine();
        }
    }
}
