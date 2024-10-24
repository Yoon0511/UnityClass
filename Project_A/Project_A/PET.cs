using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    enum BUFFTYPE
    {
        HP_BUFF,
        DEF_BUFF,
        ATK_BUFF
    }
    internal class PET : Object
    {
        private PLAYER          Owner;                   //펫을 소유중인 플레이어
        private int             IsPermanentPet;             //펫 버프 타입(영구/일시)
        private static int      PetCount = 0;        //생성 펫의 수
        private static int      BuffCount = 0;
        public PET(PLAYER owner) 
        {
            PetCount++;
            Owner               = owner;
            Name                = "Pet_" + PetCount;
            Hp                  = random.Next(1, 5);
            Def                 = random.Next(1, 3);
            Atk                 = random.Next(1, 3);
            IsPermanentPet      = random.Next(1);
            BuffCount           = random.Next(3,5);

            if (owner != null)
            {
                GiveBuffToPlayer();
            }

            Console.WriteLine($"펫 생성({Name}) - {IsPermanentPet}");
        }

        public int GetPetCount() { return PetCount; }
        public override void Update()
        {
            if (IsPermanentPet == 1) return;

            BuffCount--;
            if (Owner != null && BuffCount == 0)
            {
                BuffCount = random.Next(3, 5);
                GiveBuffToPlayer();
            }
        }

        public void GiveBuffToPlayer()
        {
            int RandomBuff = random.Next(3); //012

            switch (RandomBuff)
            {
                case (int)BUFFTYPE.HP_BUFF:
                    Owner.SetHp(Owner.GetHp() + Hp);
                    break;
                case (int)BUFFTYPE.DEF_BUFF:
                    Owner.SetDef(Owner.GetDef() + Def);
                    break;
                case (int)BUFFTYPE.ATK_BUFF:
                    Owner.SetAtk(Owner.GetAtk() + Atk);
                    break;
            }
        }

        public void PrintOwnerName()
        {
            Console.Write(Owner.GetName());
        }
    }
}
