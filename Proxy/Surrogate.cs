namespace Proxy
{
    public class Surrogate : IHuman
    {
        private IHuman _operator;

        public Surrogate(IHuman @operator)
        {
            _operator = @operator;
        }

        public void Request()
        {
            _operator.Request();
        }
    }
}
