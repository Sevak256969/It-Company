using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public class Company : Unit<Department>
    {
        Employee chiefExecutiveOfficer;
        public Company(string name) : base(name, UnitType.Company)
        {


        }

        public Employee ChiefExecutiveOfficer
        {
            get => chiefExecutiveOfficer;
            set
            {
                chiefExecutiveOfficer = value;
                this.Head = value;
            }
        }



        public void AddDepartament(Department department)
        {
            department.CompanyId = this.UnitId;
            this.AddMember(department, true);
        }

        public void RemoveDepartment(Department department)
        {
            department.CompanyId = this.UnitId;
            this.RemoveMember(department, true);
        }


        //override
        //public string ToString()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    stringBuilder.AppendFormat(" name = {0} ", this.Name);
        //    return stringBuilder.ToString();
        //}
        //public void SetCeo(Employee ceo)
        //{
        //    this.chiefExecutiveOfficer = ceo;
        //    this.Head = ceo;
        //}

        //public void generateReport()
        //{
        //    Console.WriteLine(this.ToString());
        //}
    } 
}
