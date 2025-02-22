using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IMovable
    {
        public const int minSpeed_ = 0;
        private static int maxSpeed_ = 60;

        protected static int speed_;
        protected static int x_asic_;

      

        public void Move();
    }
}
