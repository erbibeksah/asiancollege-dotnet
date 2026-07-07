using AsianCollege.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Oops
{
    // multiple inheritance is not possible in C# but we can achieve multiple inheritance using interface
    public class Esewa : PaymentSystem, PanIdentification
    {
        public void Pay(int balance)
        {
            Console.WriteLine("The balance is: {0}", balance);
        }

        public void Refund(double balance)
        {
            Console.WriteLine("The refund balance is: {0}", balance);
        }

        public void GetBalance() {
            Console.WriteLine("The refund balance is: 100");
        }

        public void WhopaysAmount(int balance)
        {
            Console.WriteLine("The balance is: {0}", balance);
        }
        public void WhomTransferredAmount(double balance)
        {
            Console.WriteLine("The balance is: {0}", balance);
        }
    }
}
