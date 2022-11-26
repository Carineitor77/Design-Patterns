namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractCover CreateCover();
    }
}
