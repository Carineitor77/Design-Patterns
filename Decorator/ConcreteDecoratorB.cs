using System;

namespace Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        void AddedBehavior()
        {
            Console.WriteLine("Behavior");
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}
