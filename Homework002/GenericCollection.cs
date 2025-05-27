using System;
using System.Collections.Generic;

namespace Homework002;
class GenericCollection
{
    public static void Run()
    {
        SortedSet<int> numbers = new SortedSet<int>();

        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
       
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter the element {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num); 
        }

        
        Console.WriteLine("\nSorted Set:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}
