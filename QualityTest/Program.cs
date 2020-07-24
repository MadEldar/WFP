using QualityTest.Controllers;
using QualityTest.Models;
using System;
using System.Collections.Generic;

namespace QualityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentController studentController = new StudentController();
            studentController.CreateStudent(new Student(
                "T012",
                "Le Huy Hai",
                new DateTime(1998, 1, 6),
                "hai@fpt.edu.vn",
                "0931234567",
                new DateTime(2019, 4, 20),
                Student.StudentStatus.Active
            ));
            while (true)
            { 
                GenerateMenu();
                var choice = Console.ReadLine();
                while (!Int32.TryParse(choice, out int result))
                {
                    Console.WriteLine("Not a choice. Re-enter:");
                    choice = Console.ReadLine();
                }
                switch (Int32.Parse(choice))
                {
                    case 1:
                        studentController.CreateStudentManually();
                        break;
                    case 2:
                        studentController.PrintListStudent();
                        break;
                    case 3:
                        Console.WriteLine("\nEnter student's roll number:");
                        studentController.ChangeStudentStatus(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("\nEnter student's roll number:");
                        studentController.CheckNewStudent(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("\nProgram exited successfully.");
                        return;
                    default:
                        Console.WriteLine("Not a choice");
                        break;
                }
            }
        }

        private static void GenerateMenu()
        {
            Console.WriteLine("\n\n" + "".PadRight(100, '-'));
            Console.WriteLine("{0, 58}", "Student menu");
            Console.WriteLine("".PadRight(100, '-'));
            Console.WriteLine("\n01. Insert new student.\n02. Student list.\n03. Change student's status.\n04. Check if student is new.\n05. Exit.");
        }
    }
}
