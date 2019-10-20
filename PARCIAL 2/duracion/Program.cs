using System;
using System.Collections.Generic;

namespace Duracion
{
    class Duracion
    {
        private int Horas;
        private int Minutos;
        private int Segundos;

        public Duracion(int H, int M, int S)
        {
            Horas = H;
            Minutos = M;
            Segundos = S;
        }    

        public void print ()
        {
            Console.WriteLine(Horas + ":" + Minutos + ":" + Segundos);
        }

    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Duracion Pelicula = new Duracion(2, 15, 12);
            Duracion Cancion = new Duracion(0, 02, 15);
            Duracion Partido = new Duracion(2, 00, 10);

            Pelicula.print();
            Cancion.print();
            Partido.print();
        }
    }
}
