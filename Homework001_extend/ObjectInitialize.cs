using System;
using System.Collections.Generic;
using System;

namespace Homework001_extend; 

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}


class ObjectInitializeTest
{
    public static void Run()
    {
        Student student = new Student
        {
            Id = 1,
            Name = "Alice",
            Age = 20
        };

        Student student1 = new Student();
        student1.Id = 1;
        student1.Name = "Alice";
        student.Age = 20;

        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");

        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");

    }

}
