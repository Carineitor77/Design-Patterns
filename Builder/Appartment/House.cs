using System.Collections;

namespace Builder.Appartment
{
    public class House
    {
        private ArrayList _parts = new();

        public void Add(object part)
        {
            _parts.Add(part);
        }
    }
}
