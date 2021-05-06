using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        //backing field for the last name property
        private string _LastName
        {
            get
            {
                //returns info from last name
                return _LastName;
            }
            set
            {
                //value comes from LastName, sets private field _lastName as LastName
                _LastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{ FirstName} { LastName }";
            }
        }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;
            }
        }

        public DateTime DateOfBirth { get; set; }

        //using a class as a type
        public Vehicle Transport { get; set; }

    }
}
