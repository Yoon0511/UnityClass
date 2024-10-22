using System;
using System.Collections.Generic;
using System.Threading;

namespace Project_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool GameLoop = true;
            List<Object> ListObj = new List<Object>();

            PLAYER  Player = new PLAYER("Player");
            MONSTER Monster = new MONSTER("Monster"); 
            NPC Npc = new NPC();

            Player.SetTarget(Monster);
            Monster.SetTarget(Player);

            Player.PrintStat();
            Monster.PrintStat();

            ListObj.Add(Player);
            ListObj.Add(Monster);
            ListObj.Add(Npc);

            while (GameLoop)
            {
                foreach(Object obj in ListObj)
                {
                    if (obj.GetHp() <= 0)
                    {
                        Console.WriteLine($"{obj.GetName()} 사망. 게임종료");
                        GameLoop = false;
                        break;
                    }

                    obj.Update();

                    Thread.Sleep(500);
                }
                //Npc.Mathing(Player);
                //Npc.Mathing(Monster);
            }
            Console.WriteLine("--------------------------------------------");
            Player.PrintStat();
            Monster.PrintStat();
        }
    }
}
