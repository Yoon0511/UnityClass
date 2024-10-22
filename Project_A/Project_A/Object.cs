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
            mHp = random.Next(100, 300);
            mDef = random.Next(1, 4);
            mAtk = random.Next(5, 15);
        }

        public void SetHp(int hp) { mHp = hp; }
        public void SetDef(int def) { mDef = def; }
        public void SetAtk(int atk) { mAtk = atk; }
        public void SetName(string name) { mName = name; }

        public int GetHp() { return mHp; }
        public int GetDef() { return mDef; }
        public int GetAtk() { return mAtk; }
        public string GetName() { return mName; }
        public virtual void Update() { }

        public void PrintStat()
        {
            Console.WriteLine($"Name : {mName} = Hp : {mHp}, Def : {mDef}, Atk : {mAtk}\n");
        }
    }
}
