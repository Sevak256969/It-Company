using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public interface IHumanResource
    {
        void Hire(Team team, SpecialistType specialistType, QualificationLevel qualificationLevel, string personalId, string firstName,
           string lastName, string numberPhone, string email, DateTime birthDate);

        void Fire(Team team, string companyId, string teamId, string departmentId, SpecialistType specialistType,
            QualificationLevel qualificationLevel, uint salary, string personalId, string firstName,
            string lastName, string numberPhone, string email, DateTime birthDate);


    }
}
