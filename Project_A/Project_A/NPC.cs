using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_A
{
    enum STATTYPE
    {
        HP,
        DEF,
        ATK
    }
    internal class NPC : Object
    {
        private int IsPlayerSide = 0;       //1 = 플레이어편, 0 = 몬스터 편
        private static int NPC_Count = 0;   //생성된 NPC 수
        public NPC() 
        {
            NPC_Count++;
            mName = "NPC_" + NPC_Count;
            Init();
        }
        public NPC(string name)
        {
            NPC_Count++;
            mName = name + "_" + NPC_Count;
            Init();
        }

        public void Init()
        {
            mHp                 = random.Next(5, 20);
            mDef                = random.Next(1, 5);
            mAtk                = random.Next(5, 10);
            IsPlayerSide        = random.Next(1);
        }
        public override void Update()
        {
            
        }

        public void Mathing(Object other)
        {
            if (other == null) return;
            int RandomMathing = random.Next(0, 100);

            //if (RandomMathing > 30) return; //30%확률로 만난다.

            //만나면 NPC가 어느편인지에따라 다른 행동 실행

            if (IsTeam(other)) //같은 편 NPC를 만났을 경우 스탯 업그레이드
            {
                Console.WriteLine("같은편 NPC 만남");
                UpgradeToStat(other);
            }
            else //다른 편 NPC를 만났을 경우 스탯 다운
            {
                Console.WriteLine("상대편 NPC 만남");
                DowngradeToStat(other);
            }
        }

        public bool IsTeam(Object other)
        {
            if (IsPlayerSide == 1) //플레이어 편
            {
                if(other.GetType().Name.Equals("PLAYER"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else //몬스터편
            {
                if(other.GetType().Equals("MONSTER"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void UpgradeToStat(Object other)
        {
            int RandomUpgrade = random.Next(3); //012

            switch (RandomUpgrade)
            {
                case (int)STATTYPE.HP:
                    other.SetHp(other.GetHp() + mHp);
                    break;
                case (int)STATTYPE.DEF:
                    other.SetDef(other.GetDef() + mDef);
                    break;
                case (int)STATTYPE.ATK:
                    other.SetAtk(other.GetAtk() + mAtk);
                    break;
            }
        }

        public void DowngradeToStat(Object other)
        {
            int RandomDowngrade = random.Next(3); //012

            switch (RandomDowngrade)
            {
                case (int)STATTYPE.HP:
                    other.SetHp(other.GetHp() - mHp);
                    break;
                case (int)STATTYPE.DEF:
                    other.SetDef(other.GetDef() - mDef);
                    break;
                case (int)STATTYPE.ATK:
                    other.SetAtk(other.GetAtk() - mAtk);
                    break;
            }
        }
    }
}
