using System.Text.RegularExpressions;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton? _uniqueInstance;
        private string _singletonData = string.Empty;

        protected Singleton() 
        {
        }

        public static Singleton Instance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new Singleton();
            }

            return _uniqueInstance;
        }

        public void SingletonOperation()
        {
            _singletonData = "SingletonData";
        }

        public string GetSingletonData()
        {
            return _singletonData;
        }
    }
}
