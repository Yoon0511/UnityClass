using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    internal class PLAYER : Object
    {
        private PET mPet;
        private MONSTER mTarget = null;
        public PLAYER() { }
        public PLAYER(string name) : base(name) 
        {
            Console.WriteLine("플레이어 생성");
            PrintStat();
            
            CreatePet();
        }

        public override void Update()
        {
            if(mTarget != null)
            {
                DoAttack(mTarget);
            }
        }

        public void SetTarget(MONSTER target)
        {
            if(mTarget == null)
            {
                mTarget = target;
            }
        }
        public void DoAttack(MONSTER enemy)
        {
            Console.WriteLine($"공격 : {GetName()} -> {enemy.GetName()}");
            enemy.Hit(GetAtk());
        }

        public void Hit(int dmg)
        {
            SetHp(GetHp() - (dmg - GetDef()));
            Console.WriteLine($"{GetName()}는 {dmg - GetDef()}를 받았다. 남은체력 {GetHp()}");
        }

        public void CreatePet()
        {
            mPet = new PET(this);
        }
    }
}
