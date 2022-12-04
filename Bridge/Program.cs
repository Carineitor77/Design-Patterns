using Bridge.Abstractions;
using Bridge.Implementors;

namespace Bridge
{
    public class Program
    {
        public static void Main()
        {
            Abstraction? abstraction = null;

            abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Operation();

            abstraction = new RefinedAbstraction(new ConcreteImplementorB());
            abstraction.Operation();
        }
    }
}