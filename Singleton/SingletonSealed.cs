namespace Singleton
{
    /// <summary>
    /// Clase que sirve para instancias multihilo
    /// </summary>
    public sealed class SingletonSealed
    {
        private static readonly SingletonSealed instance = new SingletonSealed();
        private static int _count = 0;

        private SingletonSealed() { }

        public static int Count()
        {
            return ++_count;
        }
    }
}
