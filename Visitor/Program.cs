namespace Visitor
{
    public class Program
    {
        public static void Main()
        {
            var structure = new ObjectStructure();

            structure.Add(new ElementA());
            structure.Add(new ElementB());

            structure.Accept(new ConcreteVisitor1());
            structure.Accept(new ConcreteVisitor2());
        }
    }
}