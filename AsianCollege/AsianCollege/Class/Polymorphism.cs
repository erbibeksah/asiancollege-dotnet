using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Class
{
    public class Polymorphism
    {
        // method overloading is an example of compile time polymorphism
        #region Different types of parameters
        //public void Display(int a, float b)
        //{
        //    Console.WriteLine("This is a polymorphism example of Different types of parameters.");
        //}
        //public void Display(int a, string b)
        //{
        //    Console.WriteLine("This is a polymorphism example of Different types of parameters.");
        //}
        #endregion

        #region Different numbers of parameters
        //public void Display(int a)
        //{
        //    Console.WriteLine("This is a polymorphism example of method a.");
        //}

        //public void Display(int a, int b)
        //{
        //    Console.WriteLine("This is a polymorphism example of method b.");
        //}
        #endregion

        #region Different Sequence of parameters

        public void Display(int a, float b)
        {
            Console.WriteLine("This is a polymorphism example of method a.");
        }

        public void Display(float b, int a)
        {
            Console.WriteLine("This is a polymorphism example of method b.");
        }

        #endregion
    }
}
