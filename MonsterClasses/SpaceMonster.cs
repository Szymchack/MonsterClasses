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

        public bool HasSpaceship
        {
            get { return _hasSpaceship; }
            set { _hasSpaceship = value; }
        }

        public new string Greeting()
        {
            return $"Hello, I am a Space Monster and my name is {Name}";
        }

        public override bool IsHappy()
        {
            //if (_hasSpaceship)
            // {
            //    return true;
            //}
            // else
            //{
            //     return false;
            //}
            return _hasSpaceship ? true : false;
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
