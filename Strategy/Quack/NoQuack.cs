using Strategy.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Quack
{
    public class NoQuack : IQuackable
    {
        public void Quack()
        {
        }
    }
}
