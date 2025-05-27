using Homework001_extend;
using System;

class Program()
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose a program to run:");
            Console.WriteLine("1. Type Casting Example");
            Console.WriteLine("2. Object Initialization Example");
            Console.WriteLine("3. Record Example");
            Console.WriteLine("4. Expression Member Example");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    TypeCastTest.Run();
                    break;
                case "2":
                    ObjectInitializeTest.Run();
                    break;
                case "3":
                    RecordTest.Run();
                    break;
                case "4":
                    ExpressionTest.Run();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

        }
        
    }
}
