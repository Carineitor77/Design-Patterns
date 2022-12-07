namespace Flyweight
{
    public class Program
    {
        public static void Main()
        {
            ActorMikeMyers mike = new ActorMikeMyers();

            RoleAustinPower austin = new RoleAustinPower(mike);
            austin.Greeting("Hello! I'm Austin Powers!");

            RoleDoctorEvil dr = new RoleDoctorEvil(mike);
            dr.Greeting("Hello! I'm Dr.Evir");
        }
    }
}