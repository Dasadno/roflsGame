using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IMovable
    {
        public const int minSpeed = 0;
        private static int maxSpeed = 60;

        protected static int x_asic;
        
        public void Move();
    }
}
