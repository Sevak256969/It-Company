using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public class OperatorCode
    {
        static readonly string[] operatorCodes = { "93", "94", "91", "96", "99", "77", "43", "44", "55" };

        public static string Operator()
        {
            var rand = new Random();
            int index = rand.Next(0, operatorCodes.Length);
            string operatorCode = operatorCodes[index];

            return operatorCode;
        }
    }
}
