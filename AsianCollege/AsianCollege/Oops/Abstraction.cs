using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Class
{
    public abstract class NepalRastraBank
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public double Balance { get; set; }

        // Common implementation
        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer : {FirstName} {LastName}");
            Console.WriteLine($"Balance  : Rs.{Balance}");
        }

        // Different for every bank
        public abstract void ShowInterestRate();

        public abstract void ChargeServiceFee();
    }

    public class NabilBank : NepalRastraBank
    {
        public override void ShowInterestRate()
        {
            Console.WriteLine("Interest Rate : 6.5%");
        }

        public override void ChargeServiceFee()
        {
            Console.WriteLine("Service Charge : Rs.100");
        }
    }

    public class GlobalIme : NepalRastraBank        
    {
        public override void ShowInterestRate()
        {
            Console.WriteLine("Interest Rate : 7%");
        }

        public override void ChargeServiceFee()
        {
            Console.WriteLine("Service Charge : Rs.50");
        }
    }
}
