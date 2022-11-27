namespace Builder.Pattern
{
    public class Foreman
    {
        private readonly AbstractBuilder _builder;

        public Foreman(AbstractBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildBasement();
            _builder.BuildStorey();
            _builder.BuildRoof();
        }
    }
}
