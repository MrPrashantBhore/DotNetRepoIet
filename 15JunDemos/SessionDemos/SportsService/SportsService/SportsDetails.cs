using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SportsService
{
     [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Service1 : IService1, IDisposable
    {
        int _counter = 0;
        public Service1()
        {

        }
        public int GetData()
        {
            _counter++;
            return _counter;

        }
        public void Dispose()
        {
        }


    }
}
