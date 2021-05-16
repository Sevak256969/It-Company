using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public class PhoneNumberLength
    {
        static readonly int[] phoneNumberLengthArray = { 6, 8, 10, 11 };

        public static int PhoneLength()
        {
            var rand = new Random();
            int index = rand.Next(0, phoneNumberLengthArray.Length);
            int phoneLength = phoneNumberLengthArray[index];

            return phoneLength;
        }
    }
}
