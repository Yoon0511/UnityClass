using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    internal class MONSTER : Object
    {
        private PLAYER Target = null;
        public MONSTER() { }
        public MONSTER(string name) : base(name) 
        {
            Console.WriteLine("몬스터 생성");
            PrintStat();
        }
        public override void Update()
        {
            if (Target != null)
            {
                DoAttack(Target);
            }

        }
        public void SetTarget(PLAYER target)
        {
            if (Target == null)
            {
                Target = target;
            }
        }
        public void DoAttack(PLAYER enemy)
        {
            Console.WriteLine($"공격 : {GetName()} -> {enemy.GetName()}");
            enemy.Hit(GetAtk());
        }

        public void Hit(int dmg)
        {
            SetHp(GetHp() - (dmg - GetDef()));
            Console.WriteLine($"{GetName()}는 {dmg - GetDef()}를 받았다. 남은체력 {GetHp()}");
        }
    }
}
