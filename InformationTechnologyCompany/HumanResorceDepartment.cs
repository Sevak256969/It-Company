using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public class HumanResorceDepartment : Department
    {
        public HumanResorceDepartment(DepartmentName departmentName): base(DepartmentName.HumanResource)
        {
                
        }
        public void Hire(Team team, SpecialistType specialistType, QualificationLevel qualificationLevel,
            string personalId, string firstName, string lastName,string phoneNumber,string email, DateTime birthDate)
        {
            Employee employee = new Employee( specialistType, qualificationLevel,
                    phoneNumber, email, personalId, firstName, lastName, birthDate);
            team.AddEmployee(employee);
            Hire(team,employee);
        }
        public void Hire(Team team, Employee employee)
        {
            
            team.AddEmployee(employee);
        }
        //public void Fire(Department department)
        //{

            

        //}
    }
}
