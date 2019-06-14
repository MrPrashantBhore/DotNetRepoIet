using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoolelctionDemos
{
    //type specific comparison -int CompareTo(object obj)
    public class CricketPlayers : IComparable
    {

        public String Name { get; set; }
        public int Age { get; set; }
        public int Runs { get; set; }

        public int CompareTo(object obj)
        {
            CricketPlayers objStudent = (CricketPlayers)obj;
            if (this.Runs > objStudent.Runs)
            {
                return 1;
            }

            if (this.Runs < objStudent.Runs)
            {
                return -1;
            }

            else
            {
                return 0;
            }

        }
    }
}

