using Strategy.Fly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    internal class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a rubber duck.");
        }
    }
}
