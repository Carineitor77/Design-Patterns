namespace Prototype
{
    public abstract class Prototype
    {
        public Prototype(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

        public abstract Prototype Clone();
    }
}
