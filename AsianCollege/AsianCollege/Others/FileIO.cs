using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AsianCollege.Others
{
    public class FileIO
    {
        // Write in file
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
}
