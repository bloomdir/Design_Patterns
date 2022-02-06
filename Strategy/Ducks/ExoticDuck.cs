using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            quackBehaviour = new ExoticQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm an exotic duck.");
        }
    }
}
