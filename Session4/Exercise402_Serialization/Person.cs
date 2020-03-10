using System;
using System.Runtime.Serialization;

namespace Exercise402_Serialization
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Ssn { get; set; }
        public DateTime DOB { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int ssn, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
            DOB = dob;
        }


        public override string ToString()
        {
            return $"Firstname: {FirstName}, LastName: {LastName}, SSN: {Ssn}, DOB: {DOB:dd-MM-yyyy}";
        }
    }
}