using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IMovable
    {
        protected static int speed_;
        protected static int x_asic_ = 0;
        public void Move();
    }
}
