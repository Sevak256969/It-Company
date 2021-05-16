using InformationTechnologyCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TestSimulateionUtil.GenerateCompany("").GenerateReport();
            Console.ReadKey();
            int a = 3;
            int b = a;
            a = 5;
            List<Employee> list1 = new List<Employee>();
            List<Employee> list2 = list1;
            list1.Add(new Employee());
            int size1 = list1.Count();
            int size2 = list2.Count();
            list1 = null;
            Team team = new Team("Sevak");
            Unit<Team> unit = (Unit<Team>)team;
            Object object1 = team;
            IReportable iReportable = team;
            iReportable.GenerateReport();


        }
    }

}
