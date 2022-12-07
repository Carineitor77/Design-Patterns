namespace Flyweight
{
    public class RoleDoctorEvil : Flyweight
    {
        private Flyweight _flyweight;

        public RoleDoctorEvil(Flyweight flyweight)
        {
            _flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            _flyweight.Greeting(speech);
        }
    }
}