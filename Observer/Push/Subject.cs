using System.Collections;

namespace Observer.Push
{
    public abstract class Subject
    {
        private ArrayList observers = new ArrayList();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public abstract string State { get; set; }

        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(State);
            }
        }
    }
}
