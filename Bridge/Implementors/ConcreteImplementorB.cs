using System;

namespace Bridge.Implementors
{
    public class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorB");
        }
    }
}
