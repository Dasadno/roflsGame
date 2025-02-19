using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    internal class character
    {
        private static character instance;
        private character() { }
        public static character getInstance()
        {
            if (getInstance() == null)
                instance = new character();
            return instance;
        }
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

        public int getDmg() { return damage_; }
        public int getArm() { return armor_; }
        public int getHP() { return hp_; }
        public string getName() { return name_; }

        public void tryHit(monster enemy)
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
                setDmg(1 + BASIC_DMG_);
            }
            else if (HitTry >= 4 && HitTry != 6)
            {
                setDmg(2 + BASIC_DMG_);
            }
            else if (HitTry == 6)
            {
                setDmg(3 + BASIC_DMG_);
            }
            
            enemy.setHP(enemy.getHP() - damage_);
            Console.WriteLine($"-{damage_} hp");
            Console.WriteLine($"Nice hit!, now monster have only {enemy.getHP()} hp!");
        }




        private const int BASIC_DMG_ = 2;
        private const int BASIC_ARMOR_ = 1;
        private const int BASIC_HP_ = 3;

        private int hp_;
        private int armor_;
        private int damage_;
        
        private string name_;
    }
}
