﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public class LastNameEnding
    {
        static readonly string[] endOfLastName = { "yan", "ov", "ova" };

        public static string EndOfLastName()
        {
            var rand = new Random();
            int index = rand.Next(0, endOfLastName.Length);
            string endingOfLastName = endOfLastName[index];

            return endingOfLastName;
        }
    }
}
