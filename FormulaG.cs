using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Ingresa el numero a, tiene que ser diferente de 0");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el numero b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el numero c");
            double c = Convert.ToDouble(Console.ReadLine());
            double disc=Math.Pow(b,2)-4*a*c;

            if (a != 0)
            {
                if (disc < 0)
                {
                    Console.WriteLine("Tiene raices imaginarias");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                    Console.WriteLine("X1 = " + x1);
                    Console.WriteLine("X2 = " + x2);
                }
            }
            else
            {
                Console.WriteLine("El coeficiente cuadratico debe ser diferente de 0");
            }                    
           Console.ReadLine();
        }
    }
}
