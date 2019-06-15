using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmpService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        Employee GetDataUsingDataContract(Employee emp);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary1.ContractType".
    [DataContract]
    public class Employee
    {
        private string FName;
        private string LName;
        private string gender;
        private string details;

        [DataMember]
        public string FirstName
        {
            get { return FName; }
            set { this.FName = value; }
        }

        [DataMember]
        public string LastName
        {
            get { return LName; }
            set { this.LName = value; }
        }

        [DataMember]
        public string Gender
        {
            get { return gender; }
            set { this.gender = value; }
        }

        [DataMember]
        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }
    }
}
