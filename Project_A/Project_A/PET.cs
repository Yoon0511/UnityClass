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
        private PLAYER mOwner;                   //펫을 소유중인 플레이어
        private int mIsPermanentPet;             //펫 버프 타입(영구/일시)
        private static int mPetCount = 0;        //생성 펫의 수
        private static int mBuffCount = 0;
        public PET(PLAYER owner) 
        {
            mPetCount++;
            mOwner               = owner;
            mName               = "Pet_" + mPetCount;
            mHp                 = random.Next(1, 5);
            mDef                = random.Next(1, 3);
            mAtk                = random.Next(1, 3);
            mIsPermanentPet      = random.Next(1);
            mBuffCount           = random.Next(3,5);

            if (owner != null)
            {
                GiveBuffToPlayer();
            }

            Console.WriteLine($"펫 생성({mName}) - {mIsPermanentPet}");
        }

        public int GetPetCount() { return mPetCount; }
        public override void Update()
        {
            if (mIsPermanentPet == 1) return;

            mBuffCount--;
            if (mOwner != null && mBuffCount == 0)
            {
                mBuffCount = random.Next(3, 5);
                GiveBuffToPlayer();
            }
        }

        public void GiveBuffToPlayer()
        {
            int RandomBuff = random.Next(3); //012

            switch (RandomBuff)
            {
                case (int)BUFFTYPE.HP_BUFF:
                    mOwner.SetHp(mOwner.GetHp() + mHp);
                    break;
                case (int)BUFFTYPE.DEF_BUFF:
                    mOwner.SetDef(mOwner.GetDef() + mDef);
                    break;
                case (int)BUFFTYPE.ATK_BUFF:
                    mOwner.SetAtk(mOwner.GetAtk() + mAtk);
                    break;
            }
        }

        public void PrintOwnerName()
        {
            Console.Write(mOwner.GetName());
        }
    }
}
