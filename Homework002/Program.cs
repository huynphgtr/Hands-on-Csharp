namespace Homework002;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Generic Collection");
            Console.WriteLine("2. Dictionary Example");
            Console.WriteLine("3. Linked List");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option:");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    GenericCollection.Run();
                    break;
                case "2":
                    DictionaryEx.Run();
                    break;
                case "3":
                    LinkedListDemo.Run();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
