using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                            //for IComparable<Employee> generic
namespace CoolelctionDemos
{
    //type-specific comparison for ordering or sorting
    class EmployeeOne : IComparable<EmployeeOne>
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        #region IComparable<Employee> Members

        public int CompareTo(EmployeeOne other)
        {
            if (this.Salary > other.Salary) return 1;
            else if (this.Salary < other.Salary) return -1;
            else return 0;
        }

        #endregion
    }

    class Employee_SortBySalaryByAscendingOrder : IComparer<EmployeeOne>
    {
        #region IComparer<EmployeeOne> Members

        public int Compare(EmployeeOne x, EmployeeOne y)
        {
            if (x.Salary > y.Salary) return 1;
            else if (x.Salary < y.Salary) return -1;
            else return 0;
        }

        #endregion
    }

    class Employee_SortBySalaryByDescendingOrder : IComparer<EmployeeOne>
    {
        #region IComparer<EmployeeOne> Members

        public int Compare(EmployeeOne x, EmployeeOne y)
        {
            if (x.Salary < y.Salary) return 1;
            else if (x.Salary > y.Salary) return -1;
            else return 0;
        }

        #endregion
    }
    //For Icomparer<T>
    class Employee_SortByName : IComparer<EmployeeOne>
    {
        #region IComparer<EmployeeOne> Members

        public int Compare(EmployeeOne x, EmployeeOne y)
        {
            return string.Compare(x.Name, y.Name);
        }

        #endregion
    }
}
