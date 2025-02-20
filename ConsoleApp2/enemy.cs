using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    public class Enemy
    {
        public Enemy() { }

        public Enemy(String name) 
        {
            name_ = name;
            lvl_ = 0;
            damage_ = 0;
            armor_ = 0;
            hp_ = 1;
        }
        public void setName(String arg)
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

        public void setAll(String name, int hp, int dmg, int arm, float lvl)
        {
            name_ = name;
            hp_ = hp;
            int dmg_ = dmg;
            int arm_ = arm;
            float lvl_ = lvl;
        }
        public void popLvl(float exp)
        {
            lvl_ += exp;
        }

        public int getDmg() { return damage_; }
        public int getArm() { return armor_; }
        public int getHP() { return hp_; }
        public String getName() { return name_; }
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

        static public void Death(Enemy enemy)
        {
            enemy = null;
        }


        private int hp_;
        private int armor_;
        private int damage_;
        private float lvl_; // lvl can't be larger than 80 
        private String name_;
       
    }
}
