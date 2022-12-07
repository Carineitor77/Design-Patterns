namespace Proxy
{
    public class Program
    {
        public static void Main()
        {
            IHuman Bruce = new Operator();
            IHuman surrogate = new Surrogate(Bruce);
            surrogate.Request();
        }
    }
}