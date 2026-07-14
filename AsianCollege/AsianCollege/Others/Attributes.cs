using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Others
{
    public class Attributes
    {
        // Write in file
        [Obsolete("This method is obsolete. Use WriteFile instead.")]
        public void WriteFile()
        {
            File.WriteAllText("Student.txt", "Welcome to C#");

        }

        // Read File
        public void ReadFile()
        {
            string data = File.ReadAllText("Student.txt");

            Console.WriteLine(data);
        }

        // Delete File
        public void DeleteFile()
        {
            File.Delete("Student.txt");
        }
    }

    // Positional Attribute
    class Author : Attribute
    {
        public Author(string name)
        {
            Console.WriteLine(name);
        }
    }

    [Author("BSC CSIT")]
    class StudentTest
    {
    }

    // named attribute
    class Studentss : Attribute
    {
        // attribute on fields
        [Obsolete("This property is obsolete.")]
        public string College { get; set; }

        public int Semester { get; set; }
    }

    [Studentss(College = "Asian College", Semester = 6)]
    [Serializable]
    class StudentTest1
    {
    }
}
