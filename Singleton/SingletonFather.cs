namespace Singleton
{
    /// <summary>
    /// No sirve para instancias multihilo
    /// </summary>
    public class SingletonFather
    {
        private static SingletonFather instance;
        protected static int _count = 0;

        protected SingletonFather() { }

        public static SingletonFather Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonFather();
                }
                return instance;
            }
        }

        public virtual int Count()
        {
            return ++_count;
        }
    }
}
