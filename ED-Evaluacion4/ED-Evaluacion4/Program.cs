using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Evaluacion4
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

                    string[] valores = new string[3] { "a", "b", "c" };

                    for (contador = 0; contador < 3; contador++)
                    {
                        Console.Write("Ingrese valor {0}: ", valores[contador]);
                        valores[contador] = (Console.ReadLine());
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
