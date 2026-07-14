using AsianCollege.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Others
{
    public class Linq
    {
        public void Display()
        {
            // try catch block to handle exceptions
            try
            {
                List<StudentCard> result = new List<StudentCard>();
                result.Add(new StudentCard { Name = "Hari", Mark = 90 });
                result.Add(new StudentCard { Name = "Shyam", Mark = 85 });
                result.Add(new StudentCard { Name = "Gita", Mark = 80 });
                // picks all 
                var data = result.Where(s => s.Mark > 80);
                // picks the first or default one 
                var data1 = result.FirstOrDefault(s => s.Mark > 80);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null) {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
                throw;
            }
            
        }
    }

    public class StudentCard
    {
        public string Name { get; set; }
        public int Mark { get; set; }
    }
}
