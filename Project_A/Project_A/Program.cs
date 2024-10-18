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
            bool GameLoop = true;

            while(GameLoop)
            {
                if(hp == 0)
                {
                    if (PlayerCount > 0)
                    {
                        hp = 10;
                        PlayerCount--;
                    }
                    else
                        GameLoop = false;
                }
            }
           
        }
    }
}
