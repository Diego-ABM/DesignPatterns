using Singleton;

namespace UserInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProveSingleton();

        }


        private static void ProveSingleton()
        {
            // Obtiene la instancia unica de la clase.
            ClassSingleton instanceSingleton = ClassSingleton.GetInstance();

            // Ejecuta una accion x
            instanceSingleton.GetAcction();

            // Aunque se intente obtener una nueva instancia, retorna la primera que se creo.
            ClassSingleton instanceSingleton2 = ClassSingleton.GetInstance();

            // Ejecuta una accion x
            instanceSingleton2.GetAcction();

            Console.WriteLine("¿Las instancias son la misma?");

            // Comparamos si las instancias son las mismas
            if (instanceSingleton == instanceSingleton2)
                Console.WriteLine("Son iguales.");
            else
                Console.WriteLine("El programador miente.");
        }
    }
}
