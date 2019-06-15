using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace InstancindServiceDemo
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int GetData();
   
    }
}
