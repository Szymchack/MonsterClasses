using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SpaceMonster : Monster, IBattle
    {
        private bool _hasSpaceship;
        private int _length;
        private string _galaxy;
        private bool _canbreatheinspace;

        public bool CanBreathInSpace
        {
            get { return _canbreatheinspace; }
            set { _canbreatheinspace = value; }
        }


        public string Galaxy
        {
            get { return _galaxy; }
            set { _galaxy = value; }
        }


        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }



        public bool Spaceship
        {
            get { return _hasSpaceship; }
            set { _hasSpaceship = value; }
        }

        public SpaceMonster() { }

        public override string Greeting()
        {
            return $"Hello I am a Space Monster and my name is {Name}.";
        }

        public override bool IsHappy()
        {
            return _hasSpaceship ? true : false;

        }
        public override bool HasTeeth()
        {
            return true;
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);

            if (actionProbability >= 40)
            {
                return MonsterAction.Attack;
            }
            else if (actionProbability >= 20)
            {
                return MonsterAction.Retreat;
            }
            else
            {
                return MonsterAction.Defend;
            }

        }
    }
}
