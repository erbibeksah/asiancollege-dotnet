using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Others
{
    public class Collections
    {
        public void DisplayCollections()
        {
            // Non Generic Type Collections
            ArrayList list = new ArrayList();

            list.Add(10);
            list.Add("Ram");
            list.Add(true);
            list.Add(25.5);

            Console.WriteLine("Non Generic Type Collections: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            // Generic Type Collections
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);

            // not accepted 
            // numbers.Add("30");

            Console.WriteLine("\nGeneric Type Collections: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


        }
    }
}
