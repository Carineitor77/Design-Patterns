using Bridge.Implementors;

namespace Bridge.Abstractions
{
    public abstract class Abstraction
    {
        protected readonly Implementor _implementor;

        public Abstraction(Implementor implementor)
        {
            _implementor = implementor;
        }

        public virtual void Operation()
        {
            _implementor.OperationImp();
        }
    }
}
