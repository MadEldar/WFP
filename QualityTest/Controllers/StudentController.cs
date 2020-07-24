using QualityTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityTest.Controllers
{
    class StudentController
    {
        public static List<Student> students = new List<Student>();

        public void PrintListStudent()
        {
            foreach (Student s in students)
            {
                Console.WriteLine(("").PadRight(100, '-'));
                Console.WriteLine("Roll number: {0, -9} Full name: {1, -30} Birthday: {2, 25}", s.RollNumber, s.FullName, s.Birthday);
                Console.WriteLine("Phone: {0, -15} Email: {1, -34} Created at: {2, 23}", s.Phone, s.Email, s.CreatedAt);
                Console.WriteLine("Status: {0, -10}", s.Status);
            }
            Console.WriteLine("\nPress any key to return to menu");
            Console.ReadKey();
        }

        public void CreateStudent(Student st)
        {
            students.Add(st);
        }
        public Student CreateStudentManually()
        {
            Console.WriteLine("Enter student's roll number: ");
            string rn = Console.ReadLine();
            Console.WriteLine("Enter student's full name: ");
            string fn = Console.ReadLine();
            Console.WriteLine("Enter student's email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter student's phone: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter student's birthday (yyyy/mm/dd): ");
            string bd = Console.ReadLine();
            while (!DateTime.TryParse(bd, out DateTime result))
            {
                Console.WriteLine("Not a date. Please re-enter student's birthday (yyyy/mm/dd):");
                bd = Console.ReadLine();
            }
            Console.WriteLine("Enter student's enrollment day (yyyy/mm/dd): ");
            string ca = Console.ReadLine();
            while (!DateTime.TryParse(ca, out DateTime result))
            {
                Console.WriteLine("Not a date. Please re-enter student's enrollment day:");
                ca = Console.ReadLine();
            }
            Student st = new Student(rn, fn, DateTime.Parse(bd), email, phone, DateTime.Parse(ca), Student.StudentStatus.Active);
            students.Add(st);
            return st;
        }
    }
}
