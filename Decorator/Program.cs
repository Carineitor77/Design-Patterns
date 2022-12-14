namespace Decorator
{
    public class Program
    {
        public static void Main()
        {
            Component component = new ConcreteComponent();
            Decorator decoratorA = new ConcreteDecoratorA();
            Decorator decoratorB = new ConcreteDecoratorB();

            decoratorA.Component = component;
            decoratorB.Component = decoratorA;
            decoratorB.Operation();
        }
    }
}