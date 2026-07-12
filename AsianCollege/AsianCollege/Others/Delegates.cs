using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Others
{
    public class Delegates
    {
        public delegate void MyDelegate();

        public static void Welcome()
        {
            Console.WriteLine("Welcome Studentsof method Welcome()");
        }
        public static void Welcome1()
        {
            Console.WriteLine("Welcome Students of method Welcome1()");
        }
    }
}
