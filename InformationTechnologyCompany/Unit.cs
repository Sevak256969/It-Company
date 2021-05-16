using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTechnologyCompany
{
    public enum UnitType
    {
        Undefined,
        Company,
        Department,
        Team
    }
    public class Unit<T> : IReportable
    {
        string unitId = CompanyUtil.getGuid();
        UnitType unitType;

        DateTime createDate = DateTime.UtcNow;
        DateTime updateDate;
        DateTime endDate;

        int minCapacity = 1;
        int maxCapacity = 100;
        int size;
        string name;
        Employee head;
        List<T> memberList = new List<T>();
        
        public Unit(string name, UnitType unitType, int minCapacity, int maxCapacity)
        {
            this.name = name;
            this.unitType = unitType;
            this.minCapacity = minCapacity;
            this.maxCapacity = maxCapacity;
        }

        public static explicit operator Unit<T>(Team v)
        {
            throw new NotImplementedException();
        }

        public Unit(string name, UnitType unitType)
        {
            this.name = name;
            this.unitType = unitType;

        }

        public List<T> MemberList { get => memberList; }
        protected string Name { get => name; set => name = value; }
        protected int MinCapacity { get => minCapacity; set => minCapacity = value; }
        protected int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }
        public int Size { get => memberList.Count;  }
        public string UnitId { get => unitId;  }
        protected UnitType UnitType { get => unitType;  }
        protected DateTime CreateDate { get => createDate; }
        protected DateTime UpdateDate { get => updateDate; set => updateDate = value; }
        protected DateTime EndDate { get => endDate; }
        protected Employee Head { get => head; set => head = value; }



        //  Methods
        protected bool AddMember(T member, bool updateMaxCapacity)
        {
            if (this.memberList.Contains(member))
            {
                return false;
            }
            if (memberList.Count == this.maxCapacity)
            {
                if (updateMaxCapacity)
                {
                    this.maxCapacity = memberList.Count + 1;
                }else
                {
                    return false;
                }
            }
            // add the member
            memberList.Add(member);
            // update the timestamp
            updateDate = DateTime.UtcNow;

            return true;
        }
        protected bool RemoveMember(T member, bool updateMinCapacity)
        {
            if (!this.memberList.Contains(member))
            {
                return false;
            }
            if (memberList.Count == this.minCapacity)
            {
                if (updateMinCapacity)
                {
                    this.minCapacity = memberList.Count - 1;
                }else
                {
                    return false;
                }
            }
            // remove the member
            memberList.Remove(member);
            // update the timestamp
            updateDate = DateTime.UtcNow;

            return true;
        }
        override
        public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string uType = this.unitType.ToString();
            if (head != null)
            {
                stringBuilder.Append("The Head of Unit is " + head.ToString());
            }
            stringBuilder.AppendFormat("{0} name is {1}", uType, this.name).AppendLine();
            stringBuilder.AppendFormat("{0} members are", uType).AppendLine();
            foreach(var member in this.memberList)
            {
                stringBuilder.Append(member.ToString()).AppendLine();
            }
            
            return stringBuilder.ToString().Trim();
        }

        public void GenerateReport()
        {
            Console.WriteLine(this.ToString());
        }


        //stringBuilder.AppendFormat("name = {0}, unit id = {1}, " +
        //    "create date = {2}, update date  = {3}, end date = {4} {5}",
        //    this.Name, this.UnitId, this.CreateDate, this.UpdateDate, this.EndDate, this.UnitType);

        /*  protected bool AddMember( T member,bool updateMaxCompany)
          {
              int count = memberList.Count;
              //memberList.Add(member);
              //Console.WriteLine(member.ToString());
              if(count== maxCapacity)
              {
                  if(updateMaxCompany)
                  {
                      memberList.Add(member);
                      maxCapacity++;
                  }else
                  {
                      return false;
                  }
              }else
              {
                  memberList.Add(member);
              }return true;
          }

          protected bool RemoveMember(T member, bool updateMinCompany)
          {
              int count = memberList.Count;
              memberList.Add(member);
              //Console.WriteLine(member.ToString());
              if(!this.memberList.Contains(member))
              {
                  return false;
              }
              if (count == minCapacity)
              {
                  if (updateMinCompany)
                  {
                      memberList.Remove(member);
                      minCapacity++;
                  }
                  else
                  {
                      return false;
                  }
              }
              else
              {
                  memberList.Remove(member);
              }
              return true;
          }*/


    }

}
