using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Class
{
    #region Struct
    struct CollegeStudent
    {
        public int CollegeStudentId;
        public string Name;
        public string Faculty;
        public int Semester;
        public double GPA;

    }

    public class GetStudentDetails
    {
        public void DisplayStudentDetails()
        {
            // for single student details
            CollegeStudent student = new CollegeStudent();
            student.CollegeStudentId = 1;
            student.Name = "Hari";
            student.Faculty = "Science";
            student.Semester = 4;
            student.GPA = 3.5;
            Console.WriteLine($"Student ID: {student.CollegeStudentId}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Faculty: {student.Faculty}");
            Console.WriteLine($"Semester: {student.Semester}");
            Console.WriteLine($"GPA: {student.GPA}");

            // for multiple student details
            List<CollegeStudent> students = new List<CollegeStudent>();
            students.AddRange(new CollegeStudent
            {
                CollegeStudentId = 2,
                Name = "Sita",
                Faculty = "Arts",
                Semester = 3,
                GPA = 3.8
            },
            new CollegeStudent
            {
                CollegeStudentId = 3,
                Name = "Gita",
                Faculty = "Commerce",
                Semester = 2,
                GPA = 3.6
            });

            // enums called 
            Days day = Days.Monday;
            Console.WriteLine($"Day: {day}");
        }
    }
    #endregion struct

    #region Enums
    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    #endregion
}
