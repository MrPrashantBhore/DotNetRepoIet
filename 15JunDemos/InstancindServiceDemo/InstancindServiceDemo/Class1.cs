using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace InstancindServiceDemo
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
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
