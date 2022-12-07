using System;

namespace Flyweight
{
    public class ActorMikeMyers : Flyweight
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}