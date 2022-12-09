using System.Collections;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();

        public override object this[int index] 
        { 
            get
            {
                return items[index];
            }
            set
            {
                items.Insert(index, value);
            }
        }

        public override int Count => items.Count;

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
