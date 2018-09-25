using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Evaluacion
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

                    Console.Write("¿Cuantos numeros desea ingresar? ");
                    Nnum = Convert.ToInt32(Console.ReadLine());
                    int[] valores = new int[Nnum];

                    for (contador = 0; contador < Nnum; contador++)
                    {
                        Console.Write("Ingrese valor {0}: ", (contador + 1));
                        valores[contador] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Write("El valor Maximo es: " + valores.Max());
                    Console.Write("\nEl valor Minimo es: " + valores.Min());
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
