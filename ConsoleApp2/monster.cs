using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class monster
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

        public int getDmg() { return damage_; }
        public int getArm() { return armor_; }
        public int getHP() { return hp_; }
        public string getName() { return name_; }



        private int hp_;
        private int armor_;
        private int damage_;

        private string name_;
    }
}
