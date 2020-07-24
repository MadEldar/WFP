using System;
using System.Collections.Generic;
using System.Text;

namespace QualityTest.Models
{
    class Student
    {
        public enum StudentStatus
        {
            Deactive = 0,
            Active = 1
        }
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }

        public Student(string rollNumber, string fullName, DateTime birthday, string email, string phone, DateTime createdAt, StudentStatus status)
        {
            RollNumber = rollNumber;
            FullName = fullName;
            Birthday = birthday;
            Email = email;
            Phone = phone;
            CreatedAt = createdAt;
            Status = status;
        }

        public Student() { }

        public bool isNewStudent()
        {
            return DateTime.Now.AddMonths(-2) > CreatedAt;
        }

        public bool isDeactive()
        {
            return Status == StudentStatus.Deactive;
        }
    }
}
