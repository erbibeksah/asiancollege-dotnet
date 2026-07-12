using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Others
{
    class Events
    {
        public delegate void BellHandler();
        public event BellHandler? BellRang;
        public void RingBell()
        {
            // signup process
            Console.WriteLine("School Bell Rang!");

            BellRang?.Invoke();
        }
    }

    class ClosedEvents
    {
        public void School()
        {
            Console.WriteLine("The School is Closed.");
        }
    }

    class Security
    {
        public void OpenGate()
        {
            Console.WriteLine("Security opened the gate.");
        }
    }


    // partial class
    partial class BankingCore
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Test";
        public string? CitizenId { get; set; }
        public string? Address { get; set; }
        
        public void GetName()
        {
            Console.WriteLine("The name is : {0}", Name);
        }
    }

    // partial class
    partial class BankingCore
    {
        public string? DOB { get; set; }
        public string? PinCode { get; set; }
        public string? MobNumber { get; set; } = "";

        public int TotalNominees { get; set; }
        
        public void GetMobileNumber()
        {
            Console.WriteLine("The name is : {0}", MobNumber);
        }
    }

}
