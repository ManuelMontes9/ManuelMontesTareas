using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                                           //Define si es un buen Grupo o no
namespace Calificacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos;
            //float res = 0;
            //string grupo;
            Console.WriteLine("inserte el numero de alumnos: ");
            alumnos = int.Parse(Console.ReadLine());

            int[] calificaciones = RegistrarCalificaciones(alumnos);   // se guardan las calificaciones

            Evaluar(calificaciones);  //se envian las calificaciones

            PromedioGeneral(calificaciones, alumnos);

            Console.ReadKey();
        }

        static int[] RegistrarCalificaciones(int numeroCalificaciones)
        {
            int[] cAlum = new int[numeroCalificaciones];
            int nCal = 0;
            do
            {
                Console.WriteLine("inserte calificaion del alumno {0}", (nCal + 1));
                cAlum[nCal] = int.Parse(Console.ReadLine());
                nCal++;
            } while (nCal < numeroCalificaciones);

            return cAlum;
        }

        static void Evaluar(int[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] >= 9)
                    Console.WriteLine("\nel alumno " + (i + 1) + " es un excelente alumno");
                else if (alumnos[i] >= 7)
                    Console.WriteLine("\nel alumno " + (i + 1) + " es un buen alumno");
                else
                    Console.WriteLine("\nel alumno " + (i + 1) + " es un mal alumno");
            }

        }

        static void PromedioGeneral(int[] numeroCal, int alumnos)
        {
            float res = 0;
            string grupo;
            //int[] promedio = new int[numeroCal];	
            for (int i = 0; i < numeroCal.Length; i++)
            {
                res += numeroCal[i];
            }
            res /= alumnos;

            if (res >= 9)
                grupo = "un excelente grupo";
            else if (res >= 7)
                grupo = "un buen grupo";
            else
                grupo = "un mal grupo";

            Console.WriteLine("\nel promedio total es: {0} \nse considera {1}", res, grupo);

        }
    }
}
