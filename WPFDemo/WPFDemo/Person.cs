using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace WPFDemo
{
    [ImplementPropertyChanged]
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="dateOfBirth">The date of birth.</param>
        /// <param name="gender">The gender.</param>
        public Person(string firstName, string lastName, DateTime dateOfBirth, GenderE gender)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                TimeSpan timeSpan = DateTime.Now - DateOfBirth;
                double years = timeSpan.TotalDays / 365;
                return (int)Math.Floor(years);
            }
        }

        public GenderE Gender { get; set; }
    }

    /// <summary>
    /// Represents gender of a person
    /// </summary>
    public enum GenderE
    {
        Male = 0,
        Female = 1
    }
}
