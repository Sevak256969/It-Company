using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
   public class TestSimulateionUtil
    {


        public static Employee GenerateFutureEmployee()
        {
            var rand = new Random();
            var qualificationLevelCount = Enum.GetNames(typeof(QualificationLevel)).Length;
            QualificationLevel qualificationLevel = (QualificationLevel)rand.Next(1, qualificationLevelCount + 1);
            var specialistTypeCount = Enum.GetNames(typeof(SpecialistType)).Length;
            SpecialistType specialistType = (SpecialistType)rand.Next(1, specialistTypeCount + 1);

           
            string firstName = TestUtil.GetFirstName();
            string lastName = TestUtil.GetLastName();
            DateTime birthDate = TestUtil.GetDateOfBirth(18, 70);
            string email = TestUtil.GetRandomEmail(10);
            string phoneNumber = TestUtil.GetRandomPhoneNumber();
            string personalId = TestUtil.getGuid();
            Employee employee = new Employee(specialistType, qualificationLevel, personalId, firstName,
               phoneNumber, email, lastName, birthDate);
            // Console.WriteLine(employee.ToString());
            return employee;
        }
        public static List<Employee> GenerateFutureEmployeePool(uint futureEmployeeCount)
        {
            List<Employee> futureEmployeeList = new List<Employee>();
            for (uint i = 0; i <= futureEmployeeCount; i++)
            {
                futureEmployeeList.Add(GenerateFutureEmployee());
            }
            return futureEmployeeList;
        }


        public static Team GenerateTeam(string teamName)
        {
            Team team = new Team(teamName);
            team.Manager = GenerateFutureEmployee();
            team.AddEmployee(GenerateFutureEmployee());
            team.AddEmployee(GenerateFutureEmployee());
            team.AddEmployee(GenerateFutureEmployee());
            return team;


        }
        public static Department GenerateDepartment(DepartmentName departmentName)
        {
            Department department = new Department(departmentName);
            department.Director = GenerateFutureEmployee();
            department.AddTeam(GenerateTeam(departmentName + "Team A"));
            department.AddTeam(GenerateTeam(departmentName + "Team B"));
            return department;
        }
        public static Company GenerateCompany(string companyName)
        {
            // generate a company with four departments : HR, Finance, Development, QA
            Company company = new Company(companyName);
            company.ChiefExecutiveOfficer= GenerateFutureEmployee();
            company.AddDepartament(GenerateDepartment(DepartmentName.HumanResource));
            company.AddDepartament(GenerateDepartment(DepartmentName.Development));
            company.AddDepartament(GenerateDepartment(DepartmentName.Finance));
            company.AddDepartament(GenerateDepartment(DepartmentName.QualityAssurance));
            return company;
        }

    }
}
