using System;

namespace TemplateMethod
{
    public class ConcreteClass : AbstractionClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("PrimitiveOperation1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("PrimitiveOperation2");
        }
    }
}
