using Builder.Appartment;

namespace Builder.Pattern
{
    public class ConcreteBuilder : AbstractBuilder
    {
        private House _house = new();

        public override void BuildBasement()
        {
            _house.Add(new Basement());
        }

        public override void BuildRoof()
        {
            _house.Add(new Roof());
        }

        public override void BuildStorey()
        {
            _house.Add(new Storey());
        }

        public override House GetResult()
        {
            return _house;
        }
    }
}
