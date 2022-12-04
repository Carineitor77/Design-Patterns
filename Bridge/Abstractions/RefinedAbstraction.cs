using Bridge.Implementors;

namespace Bridge.Abstractions
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor imp) : base(imp)
        {
        }

        public override void Operation()
        {
            // ...
            base.Operation();
            // ...
        }
    }
}
