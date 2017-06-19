namespace Singleton
{
    public sealed class SingletonChild : SingletonFather
    {
        private static SingletonChild instance;

        public SingletonChild() { }

        public new static SingletonChild Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonChild();
                }
                return instance;
            }
        }

        public override int Count()
        {
            return --_count;
        }
    }
}
