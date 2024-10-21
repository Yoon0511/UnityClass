using System;

namespace Project_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hp = 10;
            int atk = 10;
            int PlayerCount = 2;
            bool GameLoop = false;

            PLAYER  Player = new PLAYER("Player");
            MONSTER Monster = new MONSTER("Monster"); 
            PET Pet = new PET(Player);
            NPC Npc = new NPC();

            Player.PrintStat();
            Monster.PrintStat();
            Pet.PrintStat();
            Npc.PrintStat();

            Npc.Mathing(Player);

            Player.PrintStat();

            while (GameLoop)
            {
                
            }
           
        }
    }
}
