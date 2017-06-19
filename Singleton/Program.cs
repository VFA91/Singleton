namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int singletonSealed = SingletonSealed.Count();


            int singletonFather = SingletonFather.Instance.Count();
            int singletonChild = SingletonChild.Instance.Count();

            // El patrón singleton indica que la clase gestiona la creación de la instancia
            // El cliente no puede crear ninguna instancia, por esto se crea un constructor privado
            // La creación del constructor protected nos sirve para poder heredar dicha clase
            // Por otro lado la palabra sealed evita que nadie pueda modificar la clase.

            //SingletonSealed singleton = new SingletonSealed(); Este código nos dará error
        }
    }
}
