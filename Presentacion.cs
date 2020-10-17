using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3_Name
{
    class Presentacion
    {
        public string nombreCurso;
        public string numeroFase;
        public string nombreEstudiante;
        public string codigoEstudiante;

        public Presentacion(string curso, string numFase, string nombre, string codigo) {
            nombreCurso = curso;
            numeroFase = numFase;
            nombreEstudiante = nombre;
            codigoEstudiante = codigo;
        }

        public void Intro() {

            Console.WriteLine("Nombre del curso: {0}",nombreCurso);
            Console.WriteLine("Numero de Fase: {0}", numeroFase);
            Console.WriteLine("Nombre: {0}", nombreEstudiante);
            Console.WriteLine("Codigo: {0}", codigoEstudiante);
        }

    }
}
