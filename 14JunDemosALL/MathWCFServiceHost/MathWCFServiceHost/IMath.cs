using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MathWCFServiceHost
{
    //WCF servcie Contract
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        int Addition(int Num1, int Num2);

        [OperationContract]
        int Multiply(int Num1, int Num2);
    }
}
