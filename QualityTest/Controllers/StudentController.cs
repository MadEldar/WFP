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
        public void CheckNewStudent(string rollNumber)
        {
            foreach (Student st in students)
            {
                if (st.RollNumber == rollNumber)
                {
                    Console.WriteLine("Student of roll number {0} is {1}a new student.", rollNumber, st.isNewStudent() ? "not " : "");
                    return;
                }
            }
            Console.WriteLine("Cannot find student in the student list");
        }
        public bool ChangeStudentStatus(string rollNumber)
        {
            foreach (Student st in students)
            {
                if (st.RollNumber == rollNumber)
                {
                    Console.WriteLine("Roll number {0, -10} Full name: {1, -25} Current status: {2}", st.RollNumber, st.FullName, st.Status);
                    Console.WriteLine("Change this student's status to {0} (y/n)?",
                        st.isDeactive() ? Student.StudentStatus.Active : Student.StudentStatus.Deactive
                    );
                    string choice = Console.ReadLine();
                    while (choice != "y" && choice != "n")
                    {
                        Console.WriteLine("Incorrect choice. Please choose again:");
                        choice = Console.ReadLine();
                    }
                    if (choice == "y")
                    {
                        st.Status = st.isDeactive() ? Student.StudentStatus.Active : Student.StudentStatus.Deactive;
                        Console.WriteLine("Changed student's status successfully.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Student's status was not changed.");
                        return false;
                    }
                }
            }
            Console.WriteLine("Cannot find student in the student list");
            return false;
        }
    }
}
