using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolelctionDemos
{
    public class FootballPlayers
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public int Goals { get; set; }

    }

    //Custom collection that implements IEnumearble
    public class FootBallTeam : IEnumerable
    {
        private FootballPlayers[] _players;
        public FootBallTeam()
        {
            _players = new FootballPlayers[3];

            _players[0] = new FootballPlayers { Name = "Lionel", Age = 28, Goals = 100 };
            _players[1] = new FootballPlayers { Name = "Nemar", Age = 32, Goals = 75 };
            _players[2] = new FootballPlayers { Name = "Louis", Age = 34, Goals = 40 };
        }

        //Implements the GetEnumerator method of the IEnumerable interface
        public IEnumerator GetEnumerator()
        {
            return _players.GetEnumerator();
        }

        
    }
}



























//Uncomment this method to demostrate the use of "y" 

//public IEnumerator GetEnumerator()
//{
//    foreach (FootballPlayers p in _players)
//        yield return p;
//}