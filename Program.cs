namespace Gestion_de_estudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            Funcionalidades funcion = new Funcionalidades();

            Console.WriteLine("Programa para añadir estudiantes en un bloc de notas");
            bool bucle = false;
            while (bucle != true)
            {
                Console.WriteLine("¿Desea añadir un estudiante?");
                Console.WriteLine("Presione: \n1.Si \n2.No \n");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        funcion.AddUser();
                        Console.WriteLine("Proceso completado.\n");
                        bucle = false;
                        break;

                    case 2:
                        Console.WriteLine("Saliendo del programa...");
                        bucle = true;
                        break;

                    default:
                        bucle = false;
                        Console.WriteLine("Opcion incorrecta, intente nuevamente.\n");
                        break;

                }
            }
        }
    }
}