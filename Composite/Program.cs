namespace Composite
{
    public class Program
    {
        public static void Main()
        {
            Composite root = new Composite("ROOT");
            Composite branch1 = new Composite("BR1");
            Composite branch2 = new Composite("BR2");
            Composite leaf1 = new Composite("L1");
            Composite leaf2 = new Composite("L2");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch2.Add(leaf2);
            root.Operation();
        }
    }
}