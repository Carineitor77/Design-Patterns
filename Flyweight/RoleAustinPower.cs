namespace Flyweight
{
    public class RoleAustinPower : Flyweight
    {
        private Flyweight _flyweight;

        public RoleAustinPower(Flyweight flyweight)
        {
            _flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            _flyweight.Greeting(speech);
        }
    }
}