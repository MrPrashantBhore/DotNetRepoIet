using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    public delegate void MarksDel();
    class StudentMarks
    {
        public event MarksDel Pass;//Declaring event with MarksDel delegate
        public event MarksDel Fail;//Declaring event with MarksDel delegate

        //This method will raise the specific event
        public void ShowResult(int marks)
        {
            if (marks >= 40)
            {
                Pass();//This event will raise when user will enter marks>=40
            }
            else
            {
                Fail();//This event will raise when user will enter marks<40
            }
        }
    }
}
