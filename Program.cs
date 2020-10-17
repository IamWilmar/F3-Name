using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Debugger.Launch();
            string cent = "";
            List<Persona> estudiantesIngles = new List<Persona>();
            List<Persona> estudiantesFrances = new List<Persona>();
            List<Persona> estudiantesMandarin = new List<Persona>();
            Cursos curso = new Cursos();
            Presentacion me = new Presentacion(curso: "Curso 1", numFase: "3", nombre: "Wilmar", codigo: "1234");
            string cursoActualizar = "";
            me.Intro();
            while(cent.ToLower() != "q"){
                Console.WriteLine("\n\nBienvenido al programa de Idiomas");
                Console.WriteLine("\n\nCursos Ofertados: Ingles, Frances, Mandarin\n\n");
                Console.WriteLine("Presione cualquier tecla para inscribirse\n Presione [A] para actualizar curso\n Presione [Q] para cerrar Programa");
                cent = Console.ReadLine();

                if (cent.ToLower() == "q")
                {
                    break;
                }
                else {

                    if (cent.ToLower() == "a")
                    {
                        Console.WriteLine("Que curso desea actualizar?: Ingles, Frances o Mandarin");
                        cursoActualizar = Console.ReadLine();
                        curso.Actualizar(cursoActualizar);
                    }
                    else {
                        Persona cliente = new Persona();
                        cliente.Registrar();
                        cliente.Imprimir(0);
                        curso.estudiante = cliente;
                        curso.estudiantesIngles = estudiantesIngles;
                        curso.estudiantesFrances = estudiantesFrances;
                        curso.estudiantesMandarin = estudiantesMandarin;
                        curso.CursoChecker();
                    }
                }
            }
        }
    }
}
