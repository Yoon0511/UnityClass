using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    internal class Object
    {
        protected string mName;
        protected int mHp;
        protected int mDef;
        protected int mAtk;
        protected Random random = new Random();

        public Object() { }
        public Object(string name)
        { 
            mName = name;
            mHp = random.Next(150, 200);
            mDef = random.Next(5, 15);
            mAtk = random.Next(10, 30);
        }

        public void SetHp(int hp) { mHp = hp; }
        public void SetDef(int def) { mDef = def; }
        public void SetAtk(int atk) { mAtk = atk; }
        public void SetName(string name) { mName = name; }

        public int GetHp() { return mHp; }
        public int GetDef() { return mDef; }
        public int GetAtk() { return mAtk; }
        public string GetName() { return mName; }
        virtual public void Update() { }

        public void PrintStat()
        {
            Console.WriteLine($"Name : {mName} = Hp : {mHp}, Def : {mDef}, Atk : {mAtk}\n");
        }
    }
}
