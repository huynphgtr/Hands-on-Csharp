using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentManagement
{
    public class Student
    {
        private static int _lastId = 0;
        private int _id;
        private List<double> _scores = new List<double>();

        // Properties 
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        // Auto-implemented properties
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<double> Scores
        {
            get { return _scores; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Scores cannot be null");
                }
                _scores = value;
            }
        }
        //Read-only property for age
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year - (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear ? 1 : 0);
            }
        }


        public Student(string fullName, DateTime dateOfBirth)
        {
            Id = ++_lastId;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
        }

        // Default constructor
        public Student()
        {
            Id = ++_lastId;
            FullName = "None create";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {FullName}, Birth: {DateOfBirth.ToShortDateString()}, Age: {Age}");
        }


    }

    public class StudentManage()
    {
        public List<Student> studentList = new List<Student>();
        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentException("Student should not be null");
            }
            studentList.Add(student);
            Console.WriteLine("Student added successfully!");
        }
        public void DisplayAllStudents()
        {
            foreach (var student in studentList)
            {
                student.DisplayInfo();
            }
        }

        public void AddScoreToStudent(int studentId, double score)
        {
            var student = studentList.Find(s => s.Id == studentId);
            if (student != null)
            {
                student.Scores.Add(score);

            }
            else
            {
                Console.WriteLine("Student not found.");
            }

        }

        // Static method to calculate average score
        public static double CalculateAverageScore(List<double> scores)
        {
            if (scores == null || scores.Count == 0)
            {
                return 0;
            }
            return scores.Average();
        }

        // Extension Method to convert student name to uppercase
        public static string ToUpperCaseName(Student student)
        {
            return student.FullName.ToUpper();
        }

        //Anynomous Type Example
        public void DisplayAnonymous()
        {
            var anonymousStudent = new { Id = 323, Name = "John Doe", Birth = "20/05/2003" };
            Console.WriteLine($"Anonymous Student - ID: {anonymousStudent.Id}, Name: {anonymousStudent.Name}, Birth: {anonymousStudent.Birth}");
        }

    }


    public class DemoStudentManagement
    {
        public static void Main(string[] args)
        {
            StudentManage studentManage = new StudentManage();
            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Student Management");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Display all students");
                Console.WriteLine("3. Return uppercase name");
                Console.WriteLine("4. Add score");
                Console.WriteLine("5. Calculate average score");
                Console.WriteLine("6. Display anonymous student");
                Console.WriteLine("7. Read Student File"); 
                Console.WriteLine("0. Exit");
                Console.Write("Choose a function: ");

                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student birth date (dd/MM/yyyy): ");
                        string birthDate = Console.ReadLine();
                        DateTime date = DateTime.ParseExact(birthDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        studentManage.AddStudent(new Student(name, date));
                        break;
                    case "2":
                        studentManage.DisplayAllStudents();
                        break;
                    case "3":
                        Console.Write("Enter student ID to convert name to uppercase: ");
                        int id = int.Parse(Console.ReadLine());
                        var student = studentManage.studentList.Find(s => s.Id == id);
                        if (student != null)
                        {
                            string upperName = StudentManage.ToUpperCaseName(student);
                            Console.WriteLine($"Uppercase Name: {upperName}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;
                    case "4":
                        Console.Write("Enter student ID to add score: ");
                        int studentId = int.Parse(Console.ReadLine());
                        if (studentManage.studentList.Find(s => s.Id == studentId) == null)
                        {
                            Console.WriteLine("Student not found.");
                            break;
                        }
                        Console.Write("Enter Math score: ");
                        double mathScore = double.Parse(Console.ReadLine());
                        Console.Write("Enter English score: ");
                        double englishScore = double.Parse(Console.ReadLine());
                        studentManage.AddScoreToStudent(studentId, mathScore);
                        studentManage.AddScoreToStudent(studentId, englishScore);
                        Console.Write("Add Success");
                        break;
                    case "5":
                        Console.Write("Enter student ID to calculate average score: ");
                        int avgStudentId = int.Parse(Console.ReadLine());
                        var avgStudent = studentManage.studentList.Find(s => s.Id == avgStudentId);
                        if (avgStudent != null)
                        {
                            if (avgStudent.Scores.Count == 0)
                            {
                                Console.WriteLine("No scores available for this student.");
                                break;
                            }
                            double average = StudentManage.CalculateAverageScore(avgStudent.Scores);
                            Console.WriteLine($"Average Score: {average:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;
                    case "6":
                        studentManage.DisplayAnonymous();
                        break;
                    case "7":
                        // using declaration 
                        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\students.txt");
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] parts = line.Split(',');
                                if (parts.Length > 0)
                                {
                                    int Id = int.Parse(parts[0]);
                                    string fullName = parts[1];                                
                                    DateTime bDate = DateTime.ParseExact(parts[2], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                                    studentManage.AddStudent(new Student(fullName, bDate) { Id = Id });                                }
                            }
                        }
                        break;
                    case "0":
                        Console.WriteLine("Exit the program");
                        return;
                    default:
                        Console.WriteLine("Your choice is invalid. Enter again");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
