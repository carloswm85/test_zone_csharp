using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    // Inheritance example
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            // TODO: fix the implementation later
            return 8.0f;
        }
    }
}
