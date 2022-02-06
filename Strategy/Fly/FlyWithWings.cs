using Strategy.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Fly
{
    internal class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with my wings");            
        }
    }
}
