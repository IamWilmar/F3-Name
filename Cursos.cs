using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3_Name
{
    class Cursos
    {
        public Persona estudiante;
        public bool cent = false;
        public List<Persona> estudiantesIngles = new List<Persona>();
        public List<Persona> estudiantesFrances = new List<Persona>();
        public List<Persona> estudiantesMandarin = new List<Persona>();


        public void CursoChecker() {
            Console.Clear();
            if (estudiante.curso.ToLower() == "ingles")
            {
                estudiantesIngles.Add(this.estudiante);
                Console.WriteLine("\nRegistrado en el curso de Ingles\n");
                Imprimir();
            }
            else {
                if (estudiante.curso.ToLower() == "frances")
                {
                    estudiantesFrances.Add(this.estudiante);
                    Console.WriteLine("\nRegistrado en el curso de Frances\n");
                    Imprimir();
                }
                else {
                    if (estudiante.curso.ToLower() == "mandarin")
                    {
                        estudiantesMandarin.Add(this.estudiante);
                        Console.WriteLine("\nRegistrado en el curso de Mandarin\n");
                        Imprimir();
                    }
                    else {
                        Console.WriteLine("El Curso No Existe, Ingrese un Curso Valido\n");
                    }
                }
            }

        }


        public void Imprimir() {
            
            int i = 0;
            Console.WriteLine("\n\n-------------------------------------------------------");
            Console.WriteLine("Estudiantes de Ingles: {0}", estudiantesIngles.Count);
            foreach (Persona es in estudiantesIngles)
            {
                es.Imprimir(i);
                i++;
            }

            i = 0;
            Console.WriteLine("\n\n-------------------------------------------------------");

            Console.WriteLine("\n\nEstudiantes de Frances: {0}", estudiantesFrances.Count);
            foreach (Persona es in estudiantesFrances)
            {
                es.Imprimir(i);
                i++;
            }
            
            
            i = 0;
            Console.WriteLine("\n\n-------------------------------------------------------");
            Console.WriteLine("\n\nEstudiantes de Mandarin: {0}", estudiantesMandarin.Count);
            foreach (Persona es in estudiantesMandarin)
            {
                es.Imprimir(i);
                i++;
            }
            Console.WriteLine("\n\n-------------------------------------------------------");
            Console.WriteLine("\n");
        }


        public void Actualizar(string curso) {
            
            switch (curso.ToLower()) {
                case "ingles":
                    Eraser(estudiantesIngles, "Ingles");
                    break;

                case "frances":
                    Eraser(estudiantesFrances, "frances");
                    break;

                case "mandarin":
                    Eraser(estudiantesMandarin, "mandarin");
                    break;
                default:
                    Console.WriteLine("El curso no existe");
                    break;
            }
        }


        public void Eraser(List<Persona> dataBase, string name) {
            Console.Clear();
            int i = 0;
            int index;
            Console.WriteLine("Estudiantes de {0}: {1}",name, dataBase.Count);
            foreach (Persona es in dataBase)
            {
                es.Imprimir(i);
                i++;
            }
            Console.WriteLine("\n\nQue estudiante desea borrar?  id");
            index = Convert.ToInt32(Console.ReadLine());
            if (index >= 0 && index < dataBase.Count)
            {
                dataBase.RemoveAt(index);
                Console.WriteLine("\n\n-------------------------------------------------------");
                Console.WriteLine("El estudiante ha sido borado del curso de {0}", name);
                Console.WriteLine("\n\n-------------------------------------------------------");
                i = 0;
                Console.WriteLine("\n\n-------------------------------------------------------");
                foreach (Persona es in dataBase)
                {
                    es.Imprimir(i);
                    i++;
                }
                Console.WriteLine("\n\n-------------------------------------------------------");
            }
            else {
                Console.WriteLine("\n\n-------------------------------------------------------");
                Console.WriteLine("El estudiante no existe");
                Console.WriteLine("\n\n-------------------------------------------------------");

            }
        }

    }
}
