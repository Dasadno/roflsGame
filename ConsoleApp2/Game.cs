using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Game
    {
        private static Game instance;
        public Game() { }
        public static Game getInstance()
        {
            if (instance == null)
                instance = new Game();
            return instance;
        }
        public void CreateChar()
        {
            Character character;
            character = new Character();
            Console.Write("Enter name of your character: ");
            character.setName(Console.ReadLine());
            Console.Clear();
        }

        public void CreateEnemy()
        {
            Enemy enemy = new Enemy();
            Enemy.setTemplName(enemy);
            Random r = new Random();
            if (Character.getInstance().getLvl() < 30)
            {
                int RandNum1 = r.Next(1, 3);
                int RandNum2 = r.Next(1, 3);
                int RandNum3 = r.Next(1, 3);
                int RandNum4 = r.Next(1, 10);

                enemy.setAll(RandNum1, RandNum2, RandNum3, RandNum4);
            }

            else if (Character.getInstance().getLvl() < 60 && Character.getInstance().getLvl() > 30)
            {
                int RandNum1 = r.Next(1, 12);
                int RandNum2 = r.Next(1, 5);
                int RandNum3 = r.Next(1, 5);
                int RandNum4 = r.Next(1, 40);

                enemy.setAll(RandNum1, RandNum2, RandNum3, RandNum4);
            }
            else if (Character.getInstance().getLvl() < 80 && Character.getInstance().getLvl() > 60)
            {
                int RandNum1 = r.Next(1, 25);
                int RandNum2 = r.Next(1, 10);
                int RandNum3 = r.Next(1, 10);
                int RandNum4 = r.Next(1, 70);

                enemy.setAll(RandNum1, RandNum2, RandNum3, RandNum4);
            }
            else if (Character.getInstance().getLvl() < 80 && Character.getInstance().getLvl() > 60 )
            {
                int RandNum1 = r.Next(1, 25);
                int RandNum2 = r.Next(1, 10);
                int RandNum3 = r.Next(1, 10);
                int RandNum4 = r.Next(1, 70);

                enemy.setAll(RandNum1, RandNum2, RandNum3, RandNum4);
            }

        }
        public void Start()
        {


            CreateChar();

            char ch = Convert.ToChar(Console.ReadKey());
        }
    }
}
