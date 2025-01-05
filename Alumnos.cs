using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_estudiantes
{
    internal class Alumnos
    {
        private string name;
        private string matricula;
        private string carrera;
        private string materia;
        private int nota;

        public string Name { get => name; set => name = value; }
        public string Matricula { get => matricula; set=> matricula = value; }
        public string Carrera{ get => carrera; set => carrera = value; }
        public string Materia{ get => materia; set => materia = value; }
        public int Nota { get => nota; set => nota = value; }

        public Alumnos() { }

        public Alumnos(string name, string matricula, string carrera, string materia, int nota)
        {
            Name = name;
            Matricula = matricula;
            Carrera = carrera;
            Materia = materia;
            Nota = nota;
        }
    }
}
