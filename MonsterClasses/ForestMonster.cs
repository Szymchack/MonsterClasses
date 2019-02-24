using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{

    class ForestMonster : Monster, IBattle
    {
        private string _continent;
        private double _weight;
        private bool _haslegs;
        private bool _eatsmeat;

        public bool EatsMeat
        {
            get { return _eatsmeat; }
            set { _eatsmeat = value; }
        }

        public bool HasLegs
        {
            get { return _haslegs; }
            set { _haslegs = value; }
        }



        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }


        public string Continent
        {
            get { return Continent1; }
            set { Continent1 = value; }
        }

        public string Continent1 { get => _continent; set => _continent = value; }

        public ForestMonster() { }

        public override bool HasTeeth()
        {
            return true;
        }
        public override bool IsHappy()
        {
            return false;
        }
        public override string Greeting()
        {
            return base.Greeting();
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random(4);
            int actionProbability = randomNumber.Next(0, 101);

            if (actionProbability >= 20)
            {
                return MonsterAction.Attack;
            }
            else if (actionProbability >= 40)
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