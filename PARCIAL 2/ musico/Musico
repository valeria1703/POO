using System;
using System.Collections.Generic;

namespace Musico
{
    class Musico
    {
        protected string nombre;

        public Musico (string n)
        {
            nombre=n;
        }
        public virtual String Saluda()
        {
           return String.Format("Hola, soy {0}", nombre);
        }
        public virtual void Afina()
        {
            Console.WriteLine("{0}, afina su instrumento", nombre);
        }
    }
    class Bajista:Musico
    {
        private string bajo;

        public Bajista (string no, string bajo):base(no)
        {
            this.bajo=bajo;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}, afinando su bajo {1}", nombre, bajo);
        }
        public override String Saluda()
        {
            return base.Saluda()+ "y soy bajista";
        }
    }
    class Guitarrista:Musico
    {
        private string guitarra;

        public Guitarrista (string no, string guitarra):base(no)
        {
            this.guitarra=guitarra;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}, esta probando su guitarra {1}", nombre, guitarra);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Musico tom=new Musico ("Tom");
            Bajista flea = new Bajista ("Flea", "Gibson");
            Guitarrista luca = new Guitarrista ("Luca", "Ibanez");
            Console.WriteLine(tom.Saluda());
            Console.WriteLine(flea.Saluda());
            Console.WriteLine(luca.Saluda());

            tom.Afina(); flea.Afina(); luca.Afina();

            List <Musico> grupo = new List<Musico>();
            grupo.Add(tom);
            grupo.Add(flea);
            grupo.Add(luca);
            foreach(Musico m in grupo)
            {
                m.Saluda();
                m.Afina();
            }
        }
    }
}
