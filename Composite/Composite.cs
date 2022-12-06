using System;
using System.Collections;

namespace Composite
{
    public class Composite : Component
    {
        private ArrayList _nodes = new ArrayList();

        public Composite(string name) : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(_name);

            foreach (Component component in _nodes)
            {
                component.Operation();
            }
        }

        public override void Add(Component component)
        {
            _nodes.Add(component);
        }

        public override void Remove(Component component)
        {
            _nodes.Remove(component);
        }

        public override Component GetChild(int index)
        {
            return _nodes[index] as Component;
        }
    }
}
