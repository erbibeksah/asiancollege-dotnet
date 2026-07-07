using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Class
{
    class Teacher
    {
        public void Team()
        {
            Console.WriteLine("Teacher leads a team");
        }
    }
    class Students : Teacher
    {
        public new void Team()
        {
            Console.WriteLine("Students work in a team");
        }
    }
}
