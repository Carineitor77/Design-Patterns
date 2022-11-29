namespace FactoryMethod
{
    public class Program
    {
        public static void Main()
        {
            Creator? creator = null;
            Product? product = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();

            creator.AnOperation();
        }
    }
}