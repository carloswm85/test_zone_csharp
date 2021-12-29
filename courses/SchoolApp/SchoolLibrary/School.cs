using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    // This is a class library
    public class School
    {
        #region PROPERTIES

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        private string _twitterAddress; // backing variable

        #endregion

        #region PROPERTY, with encapsulation logic
        public string TwitterAddress
        {
            // make sure the twitter address starts with @
            get { return _twitterAddress;  }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The Twitter address must begin with @");
                }
            }
        }
        #endregion

        #region EMPTY CONSTRUCTOR
        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }
        #endregion

        #region CONSTRUCTOR with arguments
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }
        #endregion

        #region METHODS, with overload
        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
        #endregion

        #region OVERRIDING methods: ToString()
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(this.Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append(" ");
            sb.Append(Zip);

            return sb.ToString();
        }
        #endregion
    }
}
