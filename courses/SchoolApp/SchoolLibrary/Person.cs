using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // abstract class
        public abstract float ComputeGradeAverage();

        // virtual class
        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            
            // It passes one value into two places, and it formats it in two ways
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);

            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ",");
            sb.AppendLine(message);
            return sb.ToString();
        }

    }
}
