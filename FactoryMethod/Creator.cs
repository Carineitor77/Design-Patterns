namespace FactoryMethod
{
    public abstract class Creator
    {
        private Product? _product;

        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            _product = FactoryMethod();
        }
    }
}