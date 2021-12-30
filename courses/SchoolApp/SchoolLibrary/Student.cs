using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophomore, Junior, Senior }
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

        // This method is overriding a virtual method
        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidential.");
            sb.AppendLine("(This is a new line.)");
            sb.Append("{This is appending a line.}");
            sb.AppendLine("[This is a new line again.]");
            return sb.ToString();
        }
    }
}
