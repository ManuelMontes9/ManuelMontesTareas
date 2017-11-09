using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, aux=0;
            int[] arr = new int[9];
            Console.WriteLine("Ingresa 9 valores");
            a = int.Parse(Console.ReadLine());
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = a %10;
                a /= 10;
                aux += arr[i];
            }
            Console.WriteLine("Los numeros que agregaste se descompusieron y son estos");

            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Numeros: "+arr[i]);
            }
            Console.WriteLine("Los numeros se sumaron y el resultado es este: "+aux);
            
            Console.ReadKey();
        }
    }
}
