using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    abstract class Person
    {
        public enum Nationalities { Albania, Belgium, Colombia, Denmark, England, France, Greece, Holland, Italy }
        public enum Genders { Male, Female }
        private string firstName;
        private string lastName;

        public string FristName
        {
            get { return firstName; }
            set
            {
                if (value.Contains(" "))
                {
                    throw new Exception("Only one first name is allowed.");
                }
                else if (value == "")
                {
                    throw new Exception("You will have to type a first name.");
                }
                else
                {
                    firstName = value;
                };
            }
        }

        public string MiddleName { get; set; }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Contains(" "))
                {
                    throw new Exception("Only one last name is allowed.");
                }
                else if (value == "")
                {
                    throw new Exception("You will have to type a last name.");
                }
                else
                {
                    lastName = value;
                };
            }
        }
        public DateTime DateOfBirth { get; set; }
        public int Nationality { get; set; }
        public int Gender { get; set; }

        public int CalcAge(DateTime DOB)
        {
            DateTime today = DateTime.Today;
            int days = (int)today.Subtract(DOB).TotalDays;
            int years = days / 365;
            return years;
        }
    }
}
