using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPTER
{
    class MallardDuck: IDuck
    {
        public void quack()
        {
            Console.WriteLine("QUACK-QUACK-QUACK");
        }

        public void fly()
        {
            Console.WriteLine("I'm flying, man");
        }
    }
}
