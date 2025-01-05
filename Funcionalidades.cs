using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_estudiantes
{
    internal class Funcionalidades
    {
        public void AddUser()
        {
            Console.WriteLine("Introduce el nombre del Estudiante");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce la matricula del Estudiante");
            string matricula = Console.ReadLine();
            Console.WriteLine("Introduce la carrera del Estudiante");
            string carrera = Console.ReadLine();
            Console.WriteLine("Introduce la materia del Estudiante");
            string materia = Console.ReadLine();
            Console.WriteLine("Introduce la nota del Estudiante");
            int nota = Convert.ToInt32(Console.ReadLine());

            Alumnos Estudiante = new Alumnos(nombre, matricula, carrera, materia, nota);

            BlocNotas(Estudiante);
        }

        private void BlocNotas(Alumnos Estudiante)
        {
            string path = "C:\\Users\\Maiki\\OneDrive\\Desktop\\MIKIS DOCUMENTS\\C# PRUEBAS\\EJERCICIOS_PATRON_SINGLETON\\GESTION_DE_ESTUDIANTES\\Estudiante.txt";

            using(StreamWriter sw = new StreamWriter(path, true))
            {               
                sw.WriteLine($"Nombre: {Estudiante.Name}");
                sw.WriteLine($"Matrícula: {Estudiante.Matricula}");
                sw.WriteLine($"Carrera: {Estudiante.Carrera}");
                sw.WriteLine($"Materia: {Estudiante.Materia}");
                sw.WriteLine($"Nota: {Estudiante.Nota}");
                sw.WriteLine("-----------------------------------");               
            }
            Console.WriteLine("Estudiante guardado en el archivo Estudiantes.txt");
        }
    }
}
