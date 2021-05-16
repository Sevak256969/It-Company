using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
     class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employeeList = TestGenerator.GenerateFutureEmployeePool(10);
            //foreach(Employee employee in employeeList)
            //{
            //    employee.generateReport();
            //}
            //Team team = new Team("web app", "123", "456");
            //team.AddEmployee(employeeList[0]);
            //team.AddEmployee(employeeList[1]);
            //team.AddEmployee(employeeList[2]);
            //team.GenerateReport();
            CompanySimulateionUtil.GenerateCompany("").GenerateReport();
            Console.ReadKey();
        }
    }
}
