namespace State
{
    public class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            State = state;
        }

        public void Request()
        {
            this.State.Handle(this);
        }
    }
}
