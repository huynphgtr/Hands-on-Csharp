using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework002; 
public class DictionaryEx
{
    public static void Run()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter key {i + 1}: ");
            string key = Console.ReadLine();
            Console.Write($"Enter value for {key}: ");
            int value = int.Parse(Console.ReadLine());
            dictionary[key] = value;
        }
        Console.WriteLine("\nDictionary contents:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

