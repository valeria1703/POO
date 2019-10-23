﻿using System;
using System.Collections.Generic;

namespace face
{
    abstract class Publicacion
    {
        public string usuario;
        public string hora;
        public string fecha;
        public Publicacion (string usu, string ho, string fe)
        {
            this.usuario=usu;
            this.hora=ho;
            this.fecha=fe;
        }
        abstract public void print();
    }
    class Estado:Publicacion
    {
        public void print()
        {
            Console.WriteLine("")
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
