using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Evaluacion7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ban = true;
            do
            {
                try
                {
                    int contador = 0;
                    int Nnum = 0;

                    Console.Write("¿Cuantos numeros aleatorios desea ordenar? ");
                    Nnum = Convert.ToInt32(Console.ReadLine());
                    int[] vector = new int[Nnum];

                    Random aleatorios = new Random();
                    for (contador = 0; contador < Nnum; contador++)
                    {
                        vector[contador] = Convert.ToInt32(aleatorios.Next(1, 100));
                    }
                    Console.Write("Los numeros random son: ");
                    for (contador = 0; contador < Nnum; contador++)
                    {
                        Console.Write("\n" + vector[contador]);
                    }
                    Console.Write("\nLos numeros ordenados son: ");
                    Array.Sort(vector);
                    Array.Reverse(vector);
                    for (contador = 0; contador < Nnum; contador++)
                    {
                        Console.Write("\n" + vector[contador]);
                    }
                    ban = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor no valido" + e.Message);
                } 
            } while (ban==true);
            Console.ReadKey();
        }
    }
}
