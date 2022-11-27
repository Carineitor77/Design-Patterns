using Builder.Appartment;
using Builder.Pattern;

namespace Builder
{
    public class Program
    {
        public static void Main()
        {
            AbstractBuilder builder = new ConcreteBuilder();
            Foreman foreman = new Foreman(builder);

            foreman.Construct();

            House house = builder.GetResult();
        }
    }
}