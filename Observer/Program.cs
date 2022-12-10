using Observer.Pull;

namespace Observer
{
    public class Program
    {
        public static void Main()
        {
            // pull and push models
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject));
            subject.Attach(new ConcreteObserver(subject));
            subject.State = "Some state ...";
            subject.Notify();
        }
    }
}