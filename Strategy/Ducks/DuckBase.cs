using Strategy.Fly;
using Strategy.Quack;
using System;

namespace Strategy.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyable flyBehaviour;
        protected IQuackable quackBehaviour;
        public DuckBase()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new SimpleQuack();
        }
        public void SetQuackBehaviour(IQuackable newQuackBehaviour)
        {
            quackBehaviour = newQuackBehaviour;
        }
        public void SetFlyBehaviour(IFlyable newFlyBehaviour)
        {
            flyBehaviour = newFlyBehaviour;
        }
        public void Quack()
        {
            quackBehaviour.Quack();
        }
        public  void Fly()
        {
            flyBehaviour.Fly();
        }
        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }
        public abstract void Display();
    }
}
