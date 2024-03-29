﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EmployeeService : IEmpService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Employee GetDataUsingDataContract(Employee emp)
        {
            emp.Details = string.Format("Name - {0}  {1} \t Gender-{1}", emp.FirstName, emp.LastName, emp.Gender);
            return emp;
        }
    }
}
