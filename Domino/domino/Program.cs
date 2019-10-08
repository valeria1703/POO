using System;
using System.Collections.Generic;

namespace domino
{
class Domino
{
    public readonly int num;
    public readonly int den;
    public Domino (int numerador, int denominador)
    {
        if (denominador == 0)
        {
            throw new ArgumentException ("No Cero");
        }
        num = numerador;
        den=denominador;
    }
    public static int operator + (Domino a, Domino b)
    {
        return (a.num + b.den + b.num + a.den + b.den);
    }
    public static Domino operator (Domino a, Domino b)
    {
       Domino (a.num, a.den);
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Domino a=new Domino (2,0);
            Domino b=new Domino (4,1);
            Console.WriteLine();
        }
    }
}
