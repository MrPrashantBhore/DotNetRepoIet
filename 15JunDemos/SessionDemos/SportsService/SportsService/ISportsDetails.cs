using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SportsService
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IService1
    {

        [OperationContract]
        int GetData();

    }
}
