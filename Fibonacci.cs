using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, aux;
            Console.WriteLine("Cuantos Numeros quieres?");
            n = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for(int i=0; i<n; i++)
            {
                aux = a;
                a = b;
                b = aux +a;
                Console.Write(a+" ");
            }
            Console.ReadKey();
        }
    }
}
