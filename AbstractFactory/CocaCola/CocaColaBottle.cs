using System;

namespace AbstractFactory.CocaCola
{
    public class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractCover cover)
        {
            Console.WriteLine($"{this} interacts with {water} interacts with {cover}");
        }
    }
}