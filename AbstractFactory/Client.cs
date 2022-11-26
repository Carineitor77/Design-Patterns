namespace AbstractFactory
{
    public class Client
    {
        private readonly AbstractWater _water;
        private readonly AbstractBottle _bottle;
        private readonly AbstractCover _cover;

        public Client(AbstractFactory factory)
        {
            _water = factory.CreateWater();
            _bottle = factory.CreateBottle();
            _cover = factory.CreateCover();
        }

        public void Run()
        {
            _bottle.Interact(_water, _cover);
        }
    }
}
