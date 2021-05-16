using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public class Person
    {
        string  personalId;
        DateTime birthDate;
        DateTime deceasedDate;
        SpecialistType specialistType;


        string firstName;
        string lastName;
        string email;
        string phoneNumber;
        public Person(SpecialistType specialistType, string personalId, string firstName, string lastName,
            string phoneNumber, string email,  DateTime birthDate)
        {
            this.personalId = personalId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.birthDate = birthDate;
        }

        public string PersonalId { get => personalId;  }
        public DateTime BirthDate { get => birthDate;  }
        public DateTime DeceasedDate { get => deceasedDate; set => deceasedDate = value; }
        public string FirstName { get => firstName;  }
        public string LastName { get => lastName;  }
        public SpecialistType SpecialistType { get => specialistType; set => specialistType = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        override
        public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("first name = {0}, last name = {1}, " +
                "birthdate = {2}, personal id = {3}, deceasedDate = {4} ",
                this.FirstName, this.LastName, this.BirthDate, this.PersonalId, this.DeceasedDate);
            return stringBuilder.ToString();
        }

        //public void generateReport()
        //{
        //    Console.WriteLine(this.ToString());
        //}

    }
}
