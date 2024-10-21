using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    internal class PLAYER : Object
    {
        public PLAYER() { }
        public PLAYER(string name) : base(name) { }

        public override void Update()
        {
            Console.Write("Player\n");
        }

        public void DoAttack(MONSTER enemy)
        {
            enemy.Hit(GetAtk());
        }

        public void Hit(int dmg)
        {
            SetHp(GetHp() - (dmg - GetDef()));
        }
    }
}
