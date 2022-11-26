using System;

namespace AbstractFactory.Pepsi
{
    public class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractCover cover)
        {
            Console.WriteLine($"{this} interacts with {water} interacts with {cover}");
        }
    }
}