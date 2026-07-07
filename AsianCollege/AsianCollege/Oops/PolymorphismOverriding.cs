using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Class
{
    class Animal
    {
        // method overriding is an example of runtime polymorphism
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    
}
