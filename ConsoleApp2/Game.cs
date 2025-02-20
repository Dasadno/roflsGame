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
            if (Character.getInstance().getLvl() < 5)
            {
               
            }
            
        }
        public void Start()
        {
            

            CreateChar();

            char ch = Convert.ToChar(Console.ReadKey());
        }

        private const int D16_SIZE = 16;
        

    }
}
