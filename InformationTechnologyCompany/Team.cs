using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public class Team : Unit<Employee>
    {
        Employee manager;
        string companyId = "";
        string departmentId = "";
        public Team(string name, string departamentId, string companyId) : base(name, UnitType.Team)
        {
            this.companyId = companyId;
            this.departmentId = departamentId;
        }
        public Team(string name) : base(name, UnitType.Team)
        {
            
        }

        public Employee Manager
        {
            get => manager;
            set
            {
                manager = value;
                this.Head = value;
            }
        }
        public string DepartamentId { get => departmentId; set => departmentId = value; }
        public string CompanyId { get => companyId; set => companyId = value; }

        public void AddEmployee(Employee employee)
        {
            employee.CompanyId = this.companyId;
            employee.DepartmentId = this.departmentId;
            employee.TeamId = this.UnitId;
            this.AddMember(employee, true);
        }
        

        public void RemoveEmployee(Employee employee)
        {
            employee.CompanyId = this.companyId;
            employee.DepartmentId = this.departmentId;
            employee.TeamId = this.UnitId;
            this.RemoveMember(employee, true);
        }
        //override
        //public string ToString()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    stringBuilder.AppendFormat("manager = {0}, departamentId = {1}, " +
        //        "companyId = {2}", this.Manager, this.DepartamentId, this.CompanyId);
        //    return stringBuilder.ToString();
        //}

        //public void generateReport()
        //{
        //    Console.WriteLine(this.ToString());
        //}
    }
}
