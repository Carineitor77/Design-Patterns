namespace Prototype
{
    public class Program
    {
        public static void Main()
        {
            Prototype? prototype = null;
            Prototype? clone = null;

            prototype = new ConcretePrototype1(1);
            clone = prototype.Clone();

            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();
        }
    }
}