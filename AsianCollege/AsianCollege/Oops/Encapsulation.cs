using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Class
{
    public class Account 
    {
        // Concept of encapsulation in C#
        int AccBalance = 1000;

        public void SetBalance(int balance)
        {
            if (balance < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
            }
            else
            {
                AccBalance = balance;
                Console.WriteLine($"AccBalance set to: {AccBalance}");
            }
        }

        public int GetBalance() { return AccBalance; }



        // Another way to implement encapsulation using properties

        //public int Balance
        //{
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            Console.WriteLine("Balance cannot be negative.");
        //        }
        //        else
        //        {
        //            AccBalance = value;
        //            Console.WriteLine($"AccBalance set to: {AccBalance}");
        //        }
        //    }

        //    get { return AccBalance; }
        //}
    }
}
