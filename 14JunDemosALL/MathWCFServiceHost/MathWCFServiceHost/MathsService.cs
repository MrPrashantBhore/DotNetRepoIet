using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWCFServiceHost
{
    //service implementation of the contract
    public class MathsService : IMath
    {
        public int Addition(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public int Multiply(int Num1, int Num2)
        {
            return  Num1  * Num2;
        }
    }
}
