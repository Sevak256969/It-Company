using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public interface IBugReport
    {
        void Create(string createdById, string title, string description);
        void Update(string createdById, string title, string description);
    }
}

