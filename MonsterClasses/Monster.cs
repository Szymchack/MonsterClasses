using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public abstract class Monster
    {
        public enum MonsterAction
        { Attack, Defend, Retreat }
        public enum MonsterTalk { Waves, Yells, Burps }

        private int _id;
        private string _name;
        private int _age;
        private bool _isAcvtive;


        public bool IsActive
        {
            get { return _isAcvtive; }
            set { _isAcvtive = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public Monster() { }

        public Monster(int Id, string Name)
        {
            _id = Id;
            _name = Name;
        }

        public virtual string Greeting()
        {
            return $"Hello my name is {_name}.";
        }


        public abstract bool IsHappy();

        public abstract bool HasTeeth();

        public virtual string Color()
        {
            return "color: green";
        }

    }

}
