using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesDemo
{
    [AttributeUsage(AttributeTargets.All)]

    //Creating custom attribute class inherited from System.Attribute
    public class DevInfo : System.Attribute
    {
        //private fields
        private string devloperName;
        private double versionNumber;

        //parameterized constructor
        public DevInfo(string DevloperName, double VersionNumber)
        {
            this.devloperName = DevloperName;
            this.versionNumber = VersionNumber;
        }

        public virtual string DeveloperName
        {
            get
            {
                return this.devloperName;
            }
        }

        public virtual double VersionNo
        {
            get
            {
                return this.versionNumber;
            }
        }
    }
}
