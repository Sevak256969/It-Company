using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public class TestUtil

    {
        static HashSet<string> phoneNumberSet = new HashSet<string>();
        static HashSet<string> emailNameSet = new HashSet<string>();

        // Minimum valid applicant age
        static byte APPLICANT_MIN_AGE = 18;
        // Maximum valid applicant age
        static byte APPLICANT_MAX_AGE = 70;

        static readonly string[] syllables = { "ab", "sa", "de", "po", "rub", "ask",
            "mam", "ket", "zar", "lu", "te", "col", "sar", "vol", "ver" };

        static readonly string[] firstNames = { "Sevak", "Nina", "Grisha", "Karine",
            "Arevshat", "Margarita", "Karen", "Smbat", "Rouben", "Garegin",
            "Narine", "Nane", "Marina", "Suren", "Arkadij" };

        /// <summary>Generates random date of birth values within the specified age range.</summary>
        /// <param name="minAge">The minimum age.</param>
        /// <param name="maxAge">The maximum age.</param>
        /// <returns>The DateTime value within specified range.</returns>
        public static DateTime GetDateOfBirth(byte minAge, byte maxAge)
        {
            // input's validation: check age limits, make sure their within
            // the allowed range

            minAge = Math.Max(APPLICANT_MIN_AGE, minAge);
            maxAge = Math.Min(APPLICANT_MAX_AGE, maxAge);

            var rand = new Random();
            DateTime currentDateTime = DateTime.Now;
            //DateTime date1 = DateTime.Now;
            //DateTime date2 = DateTime.UtcNow;
            //DateTime date3 = DateTime.Today;

            int applicantAge = rand.Next(minAge, maxAge + 1);
            int year = currentDateTime.Year - applicantAge;
            int day;
            int month = rand.Next(1, 13);
            if (month == 2)
            {
                day = rand.Next(1, 29);
            }
            else
            {
                day = rand.Next(1, 30);

            }


            DateTime applicantDateOfBirth = new DateTime(year, month, day);
            Console.WriteLine("Generated birthDate is {0}", applicantDateOfBirth.ToString());
            return new DateTime(year, month, day);
        }

        public static string GetLastName()
        {
            var rand = new Random();
            int index = rand.Next(0, syllables.Length);
            string lastName = syllables[index].Substring(0, 1).ToUpper();
            index = rand.Next(0, syllables.Length);
            lastName += syllables[index];
            lastName += "yan";
            Console.WriteLine(lastName);
            return lastName;
        }
        public static string GetFirstName()
        {
            var rand = new Random();
            int index = rand.Next(0, firstNames.Length);
            string firstName = firstNames[index];
            Console.WriteLine(firstName);
            return firstName;

        }

        public static QualificationLevel GetQualificationLevel()
        {
            var rand = new Random();
            var qualificationLevelCount = Enum.GetNames(typeof(QualificationLevel)).Length;
            return (QualificationLevel)rand.Next(1, qualificationLevelCount);
        }

        public static SpecialistType GetSpecialistType()
        {
            var rand = new Random();
            var specialistTypelCount = Enum.GetNames(typeof(QualificationLevel)).Length;
            return (SpecialistType)rand.Next(1, specialistTypelCount);
        }

        
        //public static string GetEmail()
        //{
        //    var rand = new Random();
        //    int index = rand.Next(0, syllables.Length);
        //    int number = rand.Next(0, 1000);
        //    string email = syllables[index];
        //    index = rand.Next(0, syllables.Length);
        //    email += syllables[index];
        //    email += number;
        //    email += "@gmail.com";
        //    Console.WriteLine(email);
        //    return email;

        //}
        public static string GetRandomStringOfSybbols(int size)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var rand = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(74 * rand.NextDouble() + 48)));
                stringBuilder.Append(ch);
            }
            return stringBuilder.ToString();
        }
        public static int GetRandomNumber(int minValue, int maxValue)
        {
            var rand = new Random();
            return rand.Next(minValue, maxValue);
        }


        public static string GenerateRandomString(int size)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 97)));
                stringBuilder.Append(ch);
            }

            return stringBuilder.ToString();
        }

        public static string GenerateRandomUpperCase(int size = 1)
        {
            StringBuilder upperCase = new StringBuilder();
            Random random = new Random();
            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                upperCase.Append(ch);
            }
            return upperCase.ToString();
        }

               
        public static string GetRandomEmail(int size = 10)
        {

            int attemptCount = 0;
            string randomEmail;
            do
            {
                randomEmail = GetRandomStringOfSybbols(size) + NameDomen.EndOfEmail();
                attemptCount++;
                if (attemptCount > 100)
                {
                    randomEmail = "";
                    break;
                }
            } while (emailNameSet.Contains(randomEmail));//!-?

            emailNameSet.Add(randomEmail);
            return randomEmail;
        }

        public static int GenerateRandomNumber(int minValue, int maxValue)
        {
            var random = new Random();
            return random.Next(minValue, maxValue);
        }

        public static string GetRandomPhoneNumber()
        {
            int attempCount = 0;
            var random = new Random();
            int[] array = new int[PhoneNumberLength.PhoneLength()];
            string phoneNumber = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerateRandomNumber(0, 9);
                phoneNumber += array[i];
            }
            do
            {
                phoneNumber = CountryCode.OneCountryCode() + OperatorCode.Operator() + phoneNumber;
                attempCount++;
                if (attempCount > 100)
                {
                    phoneNumber = "";
                    break;
                }
            } while (phoneNumberSet.Contains(phoneNumber));

            phoneNumberSet.Add(phoneNumber);
            return phoneNumber;
        }

        public static string getGuid()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        
        
    }
}
