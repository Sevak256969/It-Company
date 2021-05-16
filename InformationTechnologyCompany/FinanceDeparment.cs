using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public class FinanceDeparment: Department, IFinance
    {
       
        List<Employee> employeeList = new List<Employee>();
        public FinanceDeparment() : base(DepartmentName.Finance)
        {
           
        }
        public List<Employee> EmployeeList { get => employeeList; set => employeeList = value; }

        public void RaiseSalary(int amount)
        {

        }
        

        void IFinance.RaiseSalary(int amount)
        {
            throw new NotImplementedException();
        }

        //void IFinance.AddBouns(Employee employee, uint amount, uint bounsAmount)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
