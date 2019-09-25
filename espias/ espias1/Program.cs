using System;

namespace espias1
{
    class persona
    {
        public string nombre, apellido;

        public persona()
        {
            nombre="Leha";
            apellido="Luis";
        }
    }
    class Anonymous
    {
        public static void anomiza (persona p)
        {
            p.nombre="****";
            p.apellido="****";
        }
        public static void cambia(ref persona p)
        {
            p =new persona();
            p.nombre="new";
        }
    }
    class Duplicador
        {
        static public void duplica(int x)
        {
            x=x*2;
        }
        }
    class Program
    {
        static void duplica(ref int x)
        {
            x=x*2;
        }
        static int suma (int x, int y)
        {
            return x=y;
        }
        static void suma (int x, int y, out int resultado)
        {
            resultado =x+y;
        }
        
        static void Main(string[] args)
        {
            /*/Duplicador.duplica(2);
            int x=2;
            Duplicador.duplica(x);
            Console.WriteLine("x es {0}", x);
            persona p =new persona();
            Console.WriteLine(p.nombre);
            Anonymous.anomiza(p);
            Anonymous.cambia(ref p);
            Console.WriteLine(p.nombre);*/

            int a=2, b=3, r=suma(a,b), r2;
            Console.WriteLine(r, out r2);
        }
    }
}
