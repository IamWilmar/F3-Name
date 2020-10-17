using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F3_Name
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public string edad;
        public string curso;


        public void Registrar() {
            
            Console.WriteLine("Ingrese los datos:");
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Edad");
            edad = Console.ReadLine();
            Console.WriteLine("Curso");
            curso = Console.ReadLine();
        }

        public void Imprimir(int i) {
            Console.WriteLine("{0} Nombre: {1}, Apellido: {2}, Edad: {3}, Curso {4}\n", i, nombre, apellido, edad, curso);
        }




    }
}
