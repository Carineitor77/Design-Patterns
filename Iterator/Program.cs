using System;

namespace Iterator
{
    public class Program
    {
        public static void Main()
        {
            Aggregate a = new ConcreteAggregate();

            a[0] = "El A";
            a[1] = "El B";
            a[2] = "El C";
            a[3] = "El D";

            Iterator i = a.CreateIterator();

            for (object e = i.First(); !i.IsDone(); e = i.Next())
            {
                Console.WriteLine(e);
            }
        }
    }
}