using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFTCPServiceDemo
{
    public class HelloService : IHelloService
    {
        string IHelloService.DoWork(string nm)
        {
            return  nm + " to the world of WCF";
        }
    }
}
