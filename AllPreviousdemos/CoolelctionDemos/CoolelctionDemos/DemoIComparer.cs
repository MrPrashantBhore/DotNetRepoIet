using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;                                 

                          //For Icomparer
namespace CoolelctionDemos
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

    }

    //IComparer compares two objects -non generic
    class CompareEmpByName : IComparer
    {
        public int Compare(object x, object y)
        {
            
               Employee e1 = (Employee)x;
            Employee e2 = (Employee)y;
           
            return string.Compare(e1.Name, e2.Name);
        }
    }

    class CompareEmpBySalary : IComparer
    {
        int a;
        public int Compare(object x, object y)
        {
            
            Employee e1 = (Employee)x;
            Employee e2 = (Employee)y;
            if (e1.Salary > e2.Salary)
                return 1;
            if (e1.Salary < e2.Salary)
                return -1;
            else
                a = 0;
            return a;
        }
    }
}
