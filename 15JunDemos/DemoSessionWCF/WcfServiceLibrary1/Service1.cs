using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//1 1 1percall
//1 ,2,3 PerSession
//1234567 //single
namespace WcfServiceLibrary1
{
    
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Service1 : IService1
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
       

    }
}
