using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Homework002; 
class  List <T> where T : struct
{
    LinkedList<T> list = new LinkedList<T>();
    public void Add(T item)
    {
        list.AddLast(item);
    }

    public void Display()
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

class LinkedListDemo
{
    public static void Run()
    {
        List<int> intList = new List<int>();
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        Console.WriteLine("Linked List Contents:");
        intList.Display();


        List<Double> doubleList = new List<Double>();
        doubleList.Add(1.4);
        doubleList.Add(2.3);
        doubleList.Add(3.0);
        Console.WriteLine("\nLinked List Contents:");
        doubleList.Display();

        List<bool> boolList = new List<bool>();
        boolList.Add(true);
        boolList.Add(false);
        Console.WriteLine("\nLinked List Contents:");
        intList.Display();

        List<char> charList = new List<char>();
        charList.Add('A');
        charList.Add('B');
        charList.Add('C');
        Console.WriteLine("\nLinked List Contents:");
        charList.Display();

    }
}
