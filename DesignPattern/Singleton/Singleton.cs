namespace DesignPattern.Singleton
{
    sealed class Singleton
    {
        public int Id { get; private set; }
        private static Singleton _instance;
        private static readonly object _instanceLock = new object();

        private Singleton() { }

        public static Singleton Instance(int id)
        {
            if(_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.Id = id;
                    }
                }
            }
            return _instance;
        }
    }
}
