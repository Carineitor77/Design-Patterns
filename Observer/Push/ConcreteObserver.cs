namespace Observer.Push
{
    public class ConcreteObserver : Observer
    {
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update(string state)
        {
            observerState = state;
        }
    }
}
