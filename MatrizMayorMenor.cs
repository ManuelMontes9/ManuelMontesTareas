using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            int[,] arreglo = new int[3, 3];

            Console.WriteLine("Ingresa 9 numeros");

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    arreglo[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    if (arreglo[i, j] == arreglo[0, 0])
                        resultado += arreglo[0, 0];
                    else
                    if (arreglo[i, j] == arreglo[1, 1])
                        resultado += arreglo[1, 1];
                    else
                    if (arreglo[i, j] == arreglo[2, 2])
                        resultado += arreglo[2, 2];
                }
            }

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    Console.Write(arreglo[i, j] + " ");

                }
                Console.Write("\n");
            }

            if (arreglo[0, 0] > arreglo[1, 1] && arreglo[0, 0] > arreglo[2, 2])
                Console.WriteLine(arreglo[0, 0] + " es el mas grande");
            else
            if (arreglo[1, 1] > arreglo[0, 0] && arreglo[1, 1] > arreglo[2, 2])
                Console.WriteLine(arreglo[1, 1] + " es el mas grande");
            else
            if (arreglo[2, 2] > arreglo[0, 0] && arreglo[2, 2] > arreglo[1, 1])
                Console.WriteLine(arreglo[2, 2] + " es el mas grande");



            if (arreglo[0, 0] < arreglo[1, 1] && arreglo[0, 0] < arreglo[2, 2])
                Console.WriteLine(arreglo[0, 0] + " es el mas pequeño");
            else
            if (arreglo[1, 1] < arreglo[0, 0] && arreglo[1, 1] < arreglo[2, 2])
                Console.WriteLine(arreglo[1, 1] + " es el mas pequeño");
            else
            if (arreglo[2, 2] < arreglo[0, 0] && arreglo[2, 2] < arreglo[1, 1])
                Console.WriteLine(arreglo[2, 2] + " es el mas pequeño");




            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }
    }
}
