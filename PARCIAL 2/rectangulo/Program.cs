using System;
using System.Collections.Generic;

namespace rectangulo
{
    class Rectangulo
    {
        private int bace, altura,ar;
        public Rectangulo (int ba, int al)
        {
            this.bace=ba;
            this.altura=al;
            ar=ba*al;
        }
        public static Rectangulo operator + (Rectangulo a, Rectangulo l)
        {
            return new Rectangulo (a.ar + l.ar);
        }
        
    }    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo are = new Rectangulo (10,5);
            Rectangulo are1 = new Rectangulo (4,6);
            Rectangulo r = are+are1;
        }
    }
}
