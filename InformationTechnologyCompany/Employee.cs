using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public enum QualificationLevel
    {
        Undefined,
        Intern,
        EntryLevel,
        Junior,
        Intermediate,
        Senior,
        Director,
        ChiefExecutiveOfficer
    }

    public enum SpecialistType
    {
        Undefined,
        HumanResourceSpecialist,
        FinancilSpecialist,
        SoftwareEngineer,
        QualityAssurenceEngineer,
        ProjectManagementSpecialist,
        MarketingingSpecialist
    }
    public class Employee : Person, IReportable
    {
        string  employeeId = CompanyUtil.getGuid();
        string companyId = "";
        string departmentId = "";
        string teamId = "";
        QualificationLevel qualificationLevel;
        SpecialistType specialistType;
        DateTime statDate = DateTime.UtcNow;
        DateTime updateDate;
        DateTime endDate;
        uint salary;


        public Employee(string companyId, string teamId, string departmentId, SpecialistType specialistType,
            QualificationLevel qualificationLevel, uint salary, string personalId, string firstName, string lastName,
            string phoneNumber, string email, DateTime birthDate)
            : base(specialistType, personalId, firstName, lastName, phoneNumber, email, birthDate)
        {
            this.companyId = companyId; 
            this.departmentId = departmentId;
            this.teamId = teamId;
            this.qualificationLevel = qualificationLevel;
            this.specialistType = specialistType;
            this.salary = salary;
        }
        // Prospective (candidate) employee
        public Employee(SpecialistType specialistType, QualificationLevel qualificationLevel,
            string personalId, string firstName, string lastName, string phoneNumber, string email, DateTime birthDate)
            : base(specialistType, personalId, firstName, lastName, phoneNumber, email, birthDate)
        {
            this.specialistType = specialistType;
            this.qualificationLevel = qualificationLevel;
        }

        public string EmployeeId { get => employeeId;  }
        public string CompanyId { get => companyId; set => companyId = value; }
        public string DepartmentId { get => departmentId; set => departmentId = value; }
        public string TeamId { get => teamId; set => teamId = value; }
        public QualificationLevel QualificationLevel { get => qualificationLevel; set => qualificationLevel = value; }
        public SpecialistType SpecialistType { get => specialistType; set => specialistType = value; }
        public DateTime StatDate { get => statDate; }
        public DateTime UpdateDate { get => updateDate;  }
        public uint Salary { get => salary; set => salary = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }

        //override
        //public string ToString()
        //{
        //    string employeeToString = this.FirstName + " " + this.LastName + " ";
        //    employeeToString += this.PersonalId + " " + this.qualificationLevel.ToString() + "";
        //    employeeToString += this.specialistType.ToString() + " " + this.BirthDate;
        //    return employeeToString;
        //}
        // Methods
        override
        public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("first name = {0}, last name = {1}, " +
                "birthdate = {2}, personal id = {3}, qualification = {4}, specialistType = {5}",
                this.FirstName, this.LastName, this.BirthDate, this.PersonalId, this.qualificationLevel, this.specialistType);
            return stringBuilder.ToString();
        }

        public void GenerateReport()
        {
            Console.WriteLine(this.ToString());
        }

        public bool IsAssignToTeam()
        {
            return this.teamId != null && this.teamId.Length > 0;
        }
    }
}
