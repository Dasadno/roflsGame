using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    public class Character : IMovable
    {
        private static Character instance;
        public Character() { }
        public static Character getInstance()
        {
            if (instance == null)
                instance = new Character();
            return instance;
        }

        void IMovable.Move()
        {
            speed_ = 45;
            xAsic_ += 45;

            Stop();
        }

        void Stop()
        {
            speed_ = 0;
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

        public void getHealthInf() 
        {
            Console.WriteLine($"You have {hp_ + BASIC_HP_} Health");
        }
        public void getArmorInf()
        {
            Console.WriteLine($"You have {armor_ + BASIC_ARMOR_} armor");
        }
        public void getDamageInf()
        {
            Console.WriteLine($"You have {damage_ + BASIC_DMG_} damage");
        }


        public void tryHit(Enemy enemy)
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
            if (enemy.getHP() > 0)
            {
                Console.WriteLine($"Nice hit!, now monster have only {enemy.getHP()} hp!");
            }
            else
            {
                Console.WriteLine("oh, you're killed him :(");
                setLvl(enemy.getLvl() / LVL_DIV_COEFFICIENT);
                Console.WriteLine($"you got {enemy.getLvl() / LVL_DIV_COEFFICIENT} exp, now your lvl is {getLvl()}");
            }
            
            
            
        }

        static public void GettingHit(Enemy enemy, Character character)
        {
            character.hp_ -= enemy.getDmg();
            if (enemy.getDmg() > 1) 
            {
                Console.WriteLine("Ouch, it hurts");
            }
            character.getHealthInf();
        }



        private const int LVL_DIV_COEFFICIENT = 9;

        private const int BASIC_DMG_ = 2;
        private const int BASIC_ARMOR_ = 1;
        private const int BASIC_HP_ = 3;

       
        private int hp_;
        private int armor_;
        private int damage_;
        private float lvl_;
        
        private string name_;

        private int speed_;
        private int xAsic_ = 0;
    }
}
