using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    internal class Object
    {
        protected string Name;
        protected int Hp;
        protected int Def;
        protected int Atk;
        protected Random random = new Random();

        public Object() { }
        public Object(string name)
        { 
            Name = name;
            Hp = random.Next(100, 300);
            Def = random.Next(1, 4);
            Atk = random.Next(5, 15);
        }

        public void SetHp(int hp) { Hp = hp; }
        public void SetDef(int def) { Def = def; }
        public void SetAtk(int atk) { Atk = atk; }
        public void SetName(string name) { Name = name; }

        public int GetHp() { return Hp; }
        public int GetDef() { return Def; }
        public int GetAtk() { return Atk; }
        public string GetName() { return Name; }
        public virtual void Update() { }

        public void PrintStat()
        {
            Console.WriteLine($"Name : {Name} = Hp : {Hp}, Def : {Def}, Atk : {Atk}\n");
        }
    }
}
