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
        string phone;
        string address;
        string email;
        public Company(string name) : base(name, UnitType.Company)
        {


        }
        public Company(string name,string email, string phone, string address) : base(name, UnitType.Company)
        {
            this.phone = phone;
            this.email = email;
            this.address = address;
           
               

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

        public string Phone { get => phone; set => phone = value; }
        public string Adress { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

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
