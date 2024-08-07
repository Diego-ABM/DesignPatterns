namespace Singleton
{
    public class ClassSingleton
    {

        private static ClassSingleton? _instance;
        // Este patron de diseño debe tener un constructor privado para que no se puedan crear instancias directamente.
        private ClassSingleton()
        {
            Console.WriteLine("Se crea la instancia unica de la clase singleton.");
        }

        // Metodo static para que se puede crear la instancia de la clase
        public static ClassSingleton GetInstance()
        {
            // Crea la instancia a la clase en caso de que no este creada
            if (_instance == null) _instance = new ClassSingleton();

            // Retorna la instancia
            return _instance;
        }

        public void GetAcction(ClassSingleton instance)
        {
            Console.WriteLine("Se esta ejecutando una acción de la clase singleton.");
        }

    }
}
