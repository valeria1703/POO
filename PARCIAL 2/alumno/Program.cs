using System;
using System.Collections.Generic;
namespace alumno
{
    class Alumno
    {
        private int numero_control;
        private string nombre, apellido, correo;
        public void print()
        {
            Console.WriteLine("# control: {0}", numero_control);
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Apellido: {0}", apellido);
            Console.WriteLine("Correo: {0}", correo);
        }
        public void init (int num, string nombre, string apellido, string correo)
        {
            this.numero_control=num;
            this.nombre=nombre;
            this.apellido=apellido;
            this.correo=correo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno al = new Alumno();
            al.init(19215687, "Juan","Lopez","juan.lopez@gmail.com");
            Alumno al1 = new Alumno();
            al1.init(19215688, "Jose","Hernandez","jose.hernandez@gmail.com");
            Alumno al2 = new Alumno();
            al2.init(19215689, "Eduardo","Castillo","eduardo.castillo@gmail.com");

            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(al);
            alumnos.Add(al1);
            alumnos.Add(al2);

            foreach (Alumno o in alumnos)
            {
                o.print();
                Console.WriteLine("   ");
            }
        }
    }
}
