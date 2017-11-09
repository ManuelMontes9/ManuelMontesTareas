using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioA
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0, b;
            Console.WriteLine("Cuantos alumnos tienes?");
            b = int.Parse(Console.ReadLine());
            int[] al;
            al = new int[b];
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("ingresa la calificacion del alumno " + (i + 1));
                al[i] = int.Parse(Console.ReadLine());
                a += al[i];
            }
            a /= b;
            Console.WriteLine("El Promedio deneral de los alumnos fue: " + a);
            Console.ReadKey();
        }
    }
}
