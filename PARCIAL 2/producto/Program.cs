using System;
using System.Collections.Generic;

namespace Producto
{
    class Producto
    {
        private string codigo;
        private string nombre, descripcion;
        private int precio;
        public void print()
        {
            Console.WriteLine("Codigo: {0}", codigo);
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Descripción: {0}",descripcion);
            Console.WriteLine("Precio: {0}", precio);
        }
        public void init (string codigo, string nombre, string descripcion, int precio)
        {
            this.codigo=codigo;
            this.nombre=nombre;
            this.descripcion=descripcion;
            this.precio=precio;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Producto pro = new Producto();
           pro.init("pl750001", "Boing","Jugo de Mango, 125 ml", 03);
           Producto pro1 = new Producto();
           pro1.init("pl750002", "Totis","Con sal y limón, 225 ml", 09);
           Producto pro2 = new Producto();
           pro2.init("pl750003", "Doritos","Con extra queso, 455 ml", 38);

           List <Producto> productos=new List<Producto>();
           productos.Add(pro);
           productos.Add(pro1);
           productos.Add(pro2);

           foreach (Producto o in productos)
           {
               o.print();
               Console.WriteLine("   ");
           }
        }
    }
}
