﻿using System;
using System.Collections.Generic;

namespace poo
{
   class Pelicula
   {
       public String  titulo, pais, director;
       public Int16 año;

       public void setTitulo(string titulo)
       {
           this.titulo = titulo;
       }
       public string getTitulo()
       {
           return this.titulo;
       }
       public void setAño(Int16 año)
       {
           this.año=año;
        }
        public Int16 getAño()
       {
           return this.año=año;
        }
   }
   class Program
   {
       static void Main(string[] args)
       {
           Pelicula w;
           w=new Pelicula();
           Pelicula x=new Pelicula();

           w.setTitulo("La forma del agua");
           x.setTitulo("Gladiador");
           w.setAño(2017);
           x.setAño(2000);
           Console.WriteLine(w.getTitulo());
           Console.WriteLine(w.getAño());
           Console.WriteLine(x.getTitulo());
           Console.WriteLine(x.getAño());
            
       }
   }
}
