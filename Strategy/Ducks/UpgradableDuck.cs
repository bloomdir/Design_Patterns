using Strategy.Fly;
using Strategy.Quack;
using System;

namespace Strategy.Ducks
{
    internal class UpgradableDuck : DuckBase
    {
        public UpgradableDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm an upgadable duck.");
        }
    }
}
