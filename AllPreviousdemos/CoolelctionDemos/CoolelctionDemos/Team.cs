using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolelctionDemos
{
    public class Players
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public int Runs { get; set; }

    }

    //Custom collection that implements IEnumearator
    public class Team : IEnumerator
    {
        private Players[] _players;
        int position = -1;
        public Team()
        {
            _players = new Players[3];

            _players[0] = new Players { Name = "Lionel", Age = 28, Runs = 500 };
            _players[1] = new Players { Name = "Nemar", Age = 32, Runs = 700 };
            _players[2] = new Players { Name = "Sachin", Age = 34, Runs = 600 };
        }
        //Property of IEnumerator
        public object Current
        {
            get
            {
                try
                {
                    return _players[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        //Method of IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < _players.Length);
        }

        //Method of IEnumerator
        public void Reset()
        {
            position = -1;
        }
    }
}
