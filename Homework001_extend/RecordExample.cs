using System;
using System.Collections.Generic;


namespace Homework001_extend;
public record RStudent(int Id, string Name, DateTime DateOfBirth);

class RecordExample
{
    private static List<RStudent> students = new List<RStudent>();
    public static void AddStudent(int id, string name, DateTime dob)
    {
        students.Add(new RStudent(id, name, dob));

        Console.WriteLine("Add success!");
    }

    public static void DisplayStudents()
    {
        Console.WriteLine("\nStudent List:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Birth: {student.DateOfBirth:dd/MM/yyyy}");
        }
    }
}

class RecordTest
{
    public static void Run()
    {
        var students = new List<Student>();

        while (true)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Student Management");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Display students");
            Console.WriteLine("3. Exit");
            Console.Write("Choose function: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter birthday (dd/MM/yyyy): ");
                    DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    RecordExample.AddStudent(id, name, dob);
                    break;
                case "2":
                    RecordExample.DisplayStudents();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Your choice is invalid!");
                    break;
            }
        }
    }
}