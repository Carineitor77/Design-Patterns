namespace Adapter
{
    public class Program
    {
        public static void Main()
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}