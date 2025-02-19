using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    internal class Enemy
    {
        public void setName(string arg)
        {
            name_ = arg;
        }

        public void setHP(int hp)
        {
            hp_ = hp;
        }

        public void setDmg(int dmg)
        {
            damage_ = dmg;
        }

        public void setArmor(int arm)
        {
            armor_ = arm;
        }

        public void setLvl(float lvl)
        {
            lvl_ = lvl;
        }

        public void popLvl(float exp)
        {
            lvl_ += exp;
        }

        public int getDmg() { return damage_; }
        public int getArm() { return armor_; }
        public int getHP() { return hp_; }
        public string getName() { return name_; }
        public float getLvl() { return lvl_; }

        public void tryHit()
        {
            setDmg(0);
            Random r = new Random();
            int HitTry = r.Next(1, 6);
            if (HitTry == 1)
            {
                Console.WriteLine("miss!");
            }
            else if (HitTry <= 3 && HitTry != 1)
            {
                setDmg(1);
            }
            else if (HitTry >= 4 && HitTry != 6)
            {
                setDmg(2);
            }
            else if (HitTry == 6)
            {
                setDmg(3);
            }
        }

        public int Death()
        {

        }


        private int hp_;
        private int armor_;
        private int damage_;
        private float lvl_;
        private string name_;
    }
}
