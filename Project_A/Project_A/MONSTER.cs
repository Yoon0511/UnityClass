using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    internal class MONSTER : Object
    {
        public MONSTER() { }
        public MONSTER(string name) : base(name) { }
        public override void Update()
        {
            Console.Write("Monster\n");
        }

        public void DoAttack(PLAYER enemy)
        {
            enemy.Hit(GetAtk());
        }

        public void Hit(int dmg)
        {
            SetHp(GetHp() - (dmg - GetDef()));
        }
    }
}
