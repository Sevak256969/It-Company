using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public enum DepartmentName
    {
        Undefined,
        Marketing,
        Finance,
        ProjectManagement,
        HumanResource,
        Development,
        QualityAssurance
    }

    public class Department : Unit<Team>
    {
        Employee director;
        string companyId = "";
        


        public Department(DepartmentName departmentName, string companyId) : base(departmentName.ToString(),UnitType.Department)
        {
            this.companyId = companyId;
        }
        public Department(DepartmentName departmentName) : base(departmentName.ToString(), UnitType.Department)
        {
           
        }

        public Employee Director
        {
            get => director;
            set
            {
                director = value;
                this.Head = value;
            }
        }
        public string CompanyId { get => companyId; set => companyId = value; }

        public void AddTeam(Team team)
        {
            team.DepartamentId = this.UnitId;
            this.AddMember(team,true);
        }

        public void RemoveTeam(Team team)
        {
            team.DepartamentId = this.UnitId;
            this.RemoveMember(team, true);
        }

        
        
    }
}
