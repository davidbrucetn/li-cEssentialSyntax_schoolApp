using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress; //backing variable
        public string TwitterAddress
        {
            //make sure that Twitter Address starts with @
            //backing variable with actual variable
            get { return _twitterAddress; }
            set
            {
                if(value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The Twitter address must begin with @");
                }
            }
        }

        //type ctor and hit TAB 2x
        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }
        
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        //function-bodied expression for simple returns
        //static can be seen outside of class w/o instantiation
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

                
        //overloading method with int instead of float
        public static int AverageThreeScores( int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);

            return sb.ToString();
        }

    }  //class
} //namespace
