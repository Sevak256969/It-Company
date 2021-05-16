using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{


    public class HumanResorceOperation
    {
        Employee director;
        string companyId = "";
        Dictionary<string, Employee> allEmployeeDictionary = new Dictionary<string, Employee>();
        Dictionary<string, Employee> employeesPool = new Dictionary<string, Employee>();
        Dictionary<string, Team> teamPool = new Dictionary<string, Team>();
        Dictionary<string, Department> departmentPool = new Dictionary<string, Department>();
        Dictionary<string, Company> companyPool = new Dictionary<string, Company>();


        public HumanResorceOperation(DepartmentName departmentName, string companyId)
        {
            this.companyId = companyId;
        }

        public bool AddTeam(Team team)
        {
            if (teamPool.ContainsKey(team.UnitId))
            {
                teamPool.Add(team.UnitId, team);
                return true;

            }
            else
            {
                Console.WriteLine($"We already have a team with this Id {team.UnitId}");
            }
            return false;

        }

        public bool RemoveTeam(Team team)
        {
            if (teamPool.ContainsKey(team.UnitId))
            {
                teamPool.Remove(team.UnitId);
                return true;
            }
            else
            {
                Console.WriteLine($"That team  Id {team.UnitId} is not found");
            }
            return false;
        }
        public Company CreatCompany(string name, string phone, string email, string address)
        {
            Company company = new Company(name, phone, email, address);
            companyPool.Add(company.UnitId, company);
            return company;
        }

        public void UpdateCompanyPhone(Company company, string phone)
        {
            company.Phone = phone;
        }
        public void UpdateCompanyEmail(Company company, string email)
        {
            company.Email = email;
        }

        public void AssignCompanyCeo(Company company, Employee ceo)
        {
            company.ChiefExecutiveOfficer = ceo;
        }

        public Department CreatDepartament(DepartmentName departmentName, string companyId)
        {
            Department department = new Department(departmentName, companyId);
            departmentPool.Add(department.UnitId, department);
            return department;
        }

        public void RemoveDepartament(Department department)
        {
            departmentPool.Remove(department.UnitId);
        }

        

        public Employee Hire(string personalId, string firstName, string lastName, string numberPhone, string email, 
            DateTime birthDate,SpecialistType specialistType, QualificationLevel qualificationLevel)
        {
            
            
            Employee employee = new Employee(specialistType, qualificationLevel, personalId, firstName,
                    lastName, numberPhone, email, birthDate);
            employeesPool.Add(employee.EmployeeId, employee);
            return employee;
                
            
        }
        //public bool hrAuthority = Convert.ToBoolean(DepartmentName.HumanResource);

        //public void Hire(Team team, SpecialistType specialistType, QualificationLevel qualificationLevel,
        //    string personalId, string firstName, string lastName, string numberPhone, string email, DateTime birthDate)
        //{
        //    if (hrAuthority)
        //    {
        //        Employee employee = new Employee(specialistType, qualificationLevel, personalId, firstName,
        //            lastName, numberPhone, email, birthDate);
        //        team.AddEmployee(employee);
        //        //Hire(team, employee);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Contact the HR department for that question");
        //    }
        //}

        public void Hire(Team team, Employee employee)
        {
            allEmployeeDictionary.Add(employee.EmployeeId, employee);
            team.AddEmployee(employee);
        }

        public bool Fire(Employee employee)
        {
            if (employeesPool.ContainsKey(employee.EmployeeId))
            {
                Team team = GetTeamById(employee.TeamId);
                if (team != null)
                {
                    team.RemoveEmployee(employee);
                }
                employeesPool.Remove(employee.EmployeeId);
                return true;
            }
            return false;
        }  
        //public void Fire(Employee employee, Team team)
        //{
        //    if (hrAuthority)
        //    {

        //        allEmployeeDictionary.Remove(employee.EmployeeId);
        //        team.RemoveEmployee(employee);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Contact the HR department for that question");
        //    }
        //}
        public void AssignToTeam(Employee employee, Team team)
        {
            if(employee.IsAssignToTeam())
            {
                Team oldTeam = GetTeamById(employee.EmployeeId);
                if(oldTeam!=null)
                {
                    oldTeam.RemoveEmployee(employee);
                    //employeesPool.Remove(employee.EmployeeId);
                }
            }
            team.AddEmployee(employee);
        }
        public void UpdateQualification(Employee employee, QualificationLevel qualificationLevel)
        {
            employee.QualificationLevel = qualificationLevel;
        }
        private Team GetTeamById(string teamId)
        {
            _ = new Team("default team");
            if (teamPool.ContainsKey(teamId))
            {
           
                teamPool.TryGetValue(teamId, out _);
            }
            return null;
        }
    }  
}
