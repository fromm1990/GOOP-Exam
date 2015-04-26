using System;
using TennisExam.Data;

namespace TennisExam.People
{
    internal abstract class Person
    {     
        private string firstName;
        private string lastName;

        public string FirstName
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
        public string FullName 
        {
            get
            {
                if (MiddleName == "")
                {
                    return firstName + " " + LastName;
                }
                return firstName + " " + MiddleName[0] + ". " + LastName;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public int Nationality { get; set; }
        public Genders Gender { get; set; }

        public int CalcAge(DateTime DOB)
        {
            DateTime today = DateTime.Today;
            int days = (int)today.Subtract(DOB).TotalDays;
            int years = days / 365;
            return years;
        }

    }
}
