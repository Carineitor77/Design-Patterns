namespace TemplateMethod
{
    public class Program
    {
        public static void Main()
        {
            AbstractionClass instance = new ConcreteClass();
            instance.TemplateMethod();
        }
    }
}