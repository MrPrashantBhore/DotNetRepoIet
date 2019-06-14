using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callbackdel
{
   
    public class First
    {
        public delegate void mynumbercallbackdel(int i);
        public static void myLengthyMethod(mynumbercallbackdel objDel)
        { //int[] arrNum = new int[10000];
            //int result = 1;
            for (int i = 0; i < 10000; i++)
            {
                objDel(i);

            }
        }
    }
}
