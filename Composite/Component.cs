namespace Composite
{
    public abstract class Component
    {
        protected readonly string _name;

        public Component(string name)
        {
            _name = name;
        }

        public abstract void Operation();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GetChild(int index);
    }
}
