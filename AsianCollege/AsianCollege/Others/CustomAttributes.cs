using System;
using System.Collections.Generic;
using System.Text;

namespace AsianCollege.Others
{
    public class CheckLength : Attribute
    {
        public int MaxLength { get; set; }
    }

    public class TestValidation
    {
        [CheckLength(MaxLength = 10)]
        public string Name { get; set; }
    }
}
