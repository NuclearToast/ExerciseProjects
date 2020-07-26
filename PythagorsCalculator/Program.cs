using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagorsCalculator
{
    class Program
    {
        static public string sel;
        static public double a;
        static public double b;
        static public double c;
        static void Main(string[] args)
        {
            Console.WriteLine("Satz des Pythagoras: a²+b²=c²\n");
            Console.WriteLine("Welches Quadrat willst du berechnen?");
            Console.WriteLine("1. c²\n");
            Console.WriteLine("2. b²\n");
            Console.WriteLine("3. a²\n");
            sel = Console.ReadLine();
            switch (sel)
            {
                case "1":
                    Console.Write("a² Seitenlänge (a): ");
                    a = Console.Read();
                    Console.WriteLine("\n");
                    Console.Write("b² Seitenlänge (b): ");
                    b = Console.Read();
                    c = Math.Sqrt(sqr(a) + sqr(b));
                    if (sqr(a) + sqr(b) == sqr(c))
                    {
                        Console.Clear();
                        Console.WriteLine("c² ist : " + sqr(c) + " somit ist die Seitenlänge: " + c);
                        Console.WriteLine(a + "² + " + b + "² = " + sqr(a) + " + " + sqr(b) + " = " + (sqr(a) + sqr(b)) + " = " + c + "²");
                    }
                    else
                    {
                        Console.WriteLine("Dreieck ist nicht rechtwinklig!");
                        Console.WriteLine(a + "² + " + b + "² = " + sqr(a) + " + " + sqr(b) + " = " + (sqr(a) + sqr(b)) + " ≠ " + c + "²");
                    }
                    break;
                case "2":

                    break;
                case "3":

                    break;
                default:

                    break;
            }
            Console.ReadLine();
          
        }

        public static double CalculatePythagoras(double a, double b)
        {
           return sqr(a) + sqr(b);
        }

        public static double sqr(double d)
        {
            return d * d;
        }
    }
}
