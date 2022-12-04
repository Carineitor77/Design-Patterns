using System;

namespace Bridge.Implementors
{
    public class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ImplementorA");
        }
    }
}
