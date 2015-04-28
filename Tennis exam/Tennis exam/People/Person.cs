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
                if (value == "")
                {
                    throw new Exception("You will have to type a first name.");
                }

                firstName = value;
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
                if (value == "")
                {
                    throw new Exception("You will have to type a last name.");
                }

                lastName = value;
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
        public string Nationality { get; set; }
        public Genders Gender { get; set; }

        public int CalculateAge(DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (dob > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

    }
}
