using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, resul;

            Console.WriteLine("Calcula el Area de un cubo \n" +
                    "Ingresa un lado de la figura del Cuadrado");
            lado = double.Parse(Console.ReadLine());
            resul = (lado * lado) * 6;
            Console.WriteLine("El resultado es: " + resul);
        }
    }
}
