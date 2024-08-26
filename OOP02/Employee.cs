using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Employee : IComparable<Employee>
    {
        public int ID;
        public string? Name;
        public SecurityLevel SecurityLevel;
        public decimal Salary;
        public HireDate? HireDate;
        public Gender Gender;


        public int CompareTo(Employee other)
        {
            if (other == null)
                return 1;


            return HireDate.CompareTo(other.HireDate);
        }
        public override string ToString()
        {
            return $"Name : {Name}\nID : {ID}\nGender : {Gender}\nSalary : {Salary:c}\nSecurity Level : {SecurityLevel}\nHire Date : {HireDate}";
        }
    }
}
