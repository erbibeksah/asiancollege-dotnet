using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AsianCollege.Class
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }

        public Student(){
            this.name = "Name";
            this.age = 1;
        }

        public void DisplayName() {
            // Console.WriteLine("The Student class properties value is: {0}{1}", this.name, this.age);
            // int a = 20;
            // Console.WriteLine("Before Method: {0}", a);
            // 
            // // ChangeNumber(ref a);
            // Console.WriteLine("After Method: " + a);

            string[] names = { "Ram", "Shyam", "Hari" };

            // for (int i = 1; i <= 5; i++)
            // {
            //     Console.WriteLine(i);
            // }

            foreach(string name in names)
            {
                Console.WriteLine(name);
                switch (name)
                {
                    case "Ram":
                        Console.WriteLine("The name is Ram.");
                        break;

                    default:
                        Console.WriteLine(name);
                        break;
                }
            }
        }

        public void ChangeNumber(ref int number)
        {
            // Console.WriteLine(number);
            number = 30; // not able to write or modify
        }

    }

}
