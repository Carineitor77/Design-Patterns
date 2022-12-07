using System;

namespace Proxy
{
    public class Operator : IHuman
    {
        public void Request()
        {
            Console.WriteLine("Operator");
        }
    }
}
