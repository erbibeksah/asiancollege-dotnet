using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Class
{
    #region Single level Inheritance
    #region Hierarchical Inheritance
    #region Multi-level  Inheritance
    class Parent
    {
        public int a;
        protected Parent(string name)
        {
            this.a = 10;
            Console.WriteLine("This is the parent class.");
        }

        public void DisplayName()
        {
            Console.WriteLine("This is the Parent Display Method");
        }
    }
    class Child : Parent
    {
        public int b;
        public Child(string name) : base(name)
        {
            this.b = 20;
            Console.WriteLine("This is the child class.");
        }

        public void Display()
        {
            int aaa = base.a;
            base.DisplayName();
            Console.WriteLine("Value of a & b: {0} {1}", aaa, b);
            Console.WriteLine("This is the child Display method");
        }
    }
    #endregion End Single level Inheritance
    
    class Child1 : Parent
    {
        public int c;
        public Child1(string name) : base(name)
        {
            this.c = 30;
            Console.WriteLine("This is the child class.");
        }

        public void Display()
        {
            Console.WriteLine("Value of a & c: {0} {1}", a, c);
        }
    }
    #endregion End Hierarchical Inheritance

    class Child2 : Child1
    {
        public int d;
        public Child2(string name) : base(name)
        {
            this.d = 40;
            Console.WriteLine("This is the grandchild class.");
        }

        public void Display()
        {
            Console.WriteLine("Value of a, c, and d: {0} {1} {2}", a, c, d);
        }
    }
    #endregion End Multi-level  Inheritance
}