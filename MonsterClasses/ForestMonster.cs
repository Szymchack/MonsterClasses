using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    
        public class ForestMonster : Monster, IBattle
        {
            private bool _hasCave;

            public bool HasCave
            {
                get { return _hasCave; }
                set { _hasCave = value; }
            }

            public new string Greeting()
            {
                return $"Hello, I am a Forest Monster and my name is {Name}";
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
                return _hasCave ? true : false;
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

