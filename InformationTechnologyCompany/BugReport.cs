using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public enum BugStatsus
    {
        New,
        Assigned,
        Fixed,
        Verified,
        ClosedAsDuplicate,
        ClosedAsReproducible,
        ClosedObsolete
    }
    public class BugReport
    {
        string bugId = CompanyUtil.getGuid();
        DateTime timeStamp = DateTime.UtcNow;
        string title;
        string description;
        string createdById;
        string assignedToId = " ";
        BugStatsus status=BugStatsus.New;

        public BugReport(string createdById, string title, string description)
        {
            this.createdById = createdById;
            this.title = title;
            this.description = description;
        }
       
        public string BugId { get => bugId; set => bugId = value; }
        public DateTime TimesTamp { get => timeStamp; set => timeStamp = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string CreatedById { get => createdById; set => createdById = value; }
        public string AssignedToId { get => assignedToId; set => assignedToId = value; }
        public BugStatsus Status { get => status; set => status = value; }
    }
}
