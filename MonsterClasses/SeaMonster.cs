using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SeaMonster : Monster
    {
        enum seaMonsters
        {
            suzy

        }
        private bool _hasGills;
        private string _seaName;
        private double _weight;
        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }


        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }



        public string SeaName
        {
            get { return _seaName; }
            set { _seaName = value; }
        }


        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
        }

        public SeaMonster() { }

        public Monster.MonsterTalk MonsterInteraction()
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);

            if (actionProbability >= 50)
            {
                return MonsterTalk.Waves;
            }
            else if (actionProbability >= 20)
            {
                return MonsterTalk.Yells;
            }
            else
            {
                return MonsterTalk.Burps;
            }
        }
        public override string Color()
        {
            return base.Color();
        }
        public override bool HasTeeth()
        {
            return false;
        }

        public override bool IsHappy()
        {
            return true;
        }
    }
}
