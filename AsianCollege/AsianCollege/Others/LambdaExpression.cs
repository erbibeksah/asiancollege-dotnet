using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Others
{
    public class LambdaExpression
    {
        public Func<int, int, int> add = (a, b) =>
        {
            int value = a + b;
            Console.WriteLine("The Sum is: {0}",value);
            return value;
        };

        public Action greet = () => Console.WriteLine("Welcome to BSCSIT");

        public Predicate<int> isEven = number => number % 2 == 0;
    }
}
